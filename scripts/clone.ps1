

$gitLink = "{GITLINK}"

# Change directory to the desired location
Set-Location "C:\VTI PC\System Software"

# Execute git clone command
try {
    git clone --recursive $gitLink
}
catch {
    Write-Host "Failed to execute git clone command. Error: $_"
    exit 1
}