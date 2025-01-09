# Define the parent folder path
$ParentFolderPath = " ."

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
        $CommandsFolderPath = Join-Path -Path $Subfolder.FullName -ChildPath "Commands"

        # Check if the Commands folder exists
        if (Test-Path $CommandsFolderPath) {
            Write-Host "Processing folder: $FolderName" -ForegroundColor Green

            # Define the names of the handler classes
            $Handlers = @(
                "Create${FolderName}Handler",
                "Delete${FolderName}Handler",
                "Update${FolderName}Handler"
            )

            # Create each handler class using dotnet new
            foreach ($Handler in $Handlers) {
                $HandlerFilePath = Join-Path -Path $CommandsFolderPath -ChildPath "$Handler.cs"

                if (-Not (Test-Path $HandlerFilePath)) {
                    dotnet new class -n $Handler -o $CommandsFolderPath | Out-Null
                    Write-Host "Created handler class: $Handler" -ForegroundColor Yellow
                } else {
                    Write-Host "Handler class already exists: $Handler" -ForegroundColor Cyan
                }
            }
        } else {
            Write-Host "Commands folder not found in: $Subfolder" -ForegroundColor Red
        }
    }
}
