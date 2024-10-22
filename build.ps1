# Variables
$projectPath = "D:\AWS\LoyaltyManagement"
$nugetSource = "http://ec2-13-233-97-29.ap-south-1.compute.amazonaws.com:8082/artifactory/api/nuget/v3/nuget-local"
$apiKey = "" # or username:password if using basic auth
$versionFilePath = "$projectPath\version.txt" # File to store the current version

# Navigate to the mono repo directory
Set-Location $projectPath

# Delete old .nupkg files from the output directory
Get-ChildItem -Path $outputDirectory -Filter *.nupkg | Remove-Item -Force

# Read the current version from version.txt
$currentVersion = Get-Content $versionFilePath

# Find all .csproj files in the repository
$projects = Get-ChildItem -Recurse -Filter *.csproj

# Iterate over each project
foreach ($project in $projects) {
    # Check if the project is a class library
    [xml]$csproj = Get-Content $project.FullName


    # Check for TargetFramework element to determine if it's a class library
    $sdk = $csproj.Project.Sdk

    if ($sdk -eq "Microsoft.NET.Sdk") {
        Write-Host "Packing project: $($project.FullName)"

        # Pack the project into a NuGet package with the new version
        dotnet pack $project.FullName --configuration Release --output "$($project.Directory)\packages" /p:Version=$currentVersion

        # Navigate to the output directory
        Set-Location "$($project.Directory)\packages"

        # Get all .nupkg files in the output directory
        $packages = Get-ChildItem -Filter *.nupkg

        # Push each package to Artifactory
        foreach ($package in $packages) {
            Write-Host "Pushing package: $($package.FullName) to Artifactory..."

            nuget push $package.FullName -Source $nugetSource -ApiKey $apiKey

            if ($?) {
                Write-Host "Package pushed successfully!"
            } else {
                Write-Host "Failed to push the package: $($package.Name)"
            }
        }

        # Return to the repo directory for the next project
        Set-Location "$($project.Directory)\packages"
    } else {
        Write-Host "Skipping project (not a class library): $($project.FullName)"
    }
}

# Increment the PATCH version (you can customize this logic)
$versionParts = $currentVersion -split '\.'
$versionParts[2] = [int]$versionParts[2] + 1 # Increment PATCH
$newVersion = "$($versionParts[0]).$($versionParts[1]).$($versionParts[2])"

# Write the new version back to version.txt
$newVersion | Set-Content $versionFilePath

Set-Location $projectPath