# Define the parent folder path
$ParentFolderPath = "."

# Check if the parent folder exists
if (-Not (Test-Path $ParentFolderPath)) {
    Write-Host "Parent folder does not exist: $ParentFolderPath" -ForegroundColor Red
    exit
}

# Get all subfolders matching the pattern LoyaltyManagement.*.Application
$Subfolders = Get-ChildItem -Path $ParentFolderPath -Directory | Where-Object {
    $_.Name -match "^LoyaltyManagement\.(.+?)\.Application$"
}

# Loop through each matching subfolder
foreach ($Subfolder in $Subfolders) {
    # Extract the folder name part after "LoyaltyManagement." and before ".Application"
    if ($Subfolder.Name -match "^LoyaltyManagement\.(.+?)\.Application$") {
        $FolderName = $Matches[1]
        $QueriesFolderPath = Join-Path -Path $Subfolder.FullName -ChildPath "Queries"

        # Check if the Queries folder exists
        if (Test-Path $QueriesFolderPath) {
            Write-Host "Processing folder: $FolderName" -ForegroundColor Green

            # Define the names of the query classes
            $Queries = @(
                "GetAll${FolderName}sQuery",
                "Get${FolderName}ByIdQuery"
            )

            # Create each query class using dotnet new
            foreach ($Query in $Queries) {
                $QueryFilePath = Join-Path -Path $QueriesFolderPath -ChildPath "$Query.cs"

                if (-Not (Test-Path $QueryFilePath)) {
                    dotnet new class -n $Query -o $QueriesFolderPath | Out-Null
                    Write-Host "Created query class: $Query" -ForegroundColor Yellow
                } else {
                    Write-Host "Query class already exists: $Query" -ForegroundColor Cyan
                }
            }
        } else {
            Write-Host "Queries folder not found in: $Subfolder" -ForegroundColor Red
        }
    }
}
