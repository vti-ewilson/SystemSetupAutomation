

try {
   $configFolder = ls Config -Recurse -Directory | select -last 1
   cp -r -force $configFolder "C:\VTI PC\"
}
catch {
    Write-Host "Failed to copy config folder. Error: $_"
    Read-Host "Press Enter to continue..."
}