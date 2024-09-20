$gitLink = "git@github.com:vacuumtechnology/RHE-19320-Dual-A2L-Charger.git"

<#
$sourceFolder = "\\vac-controls\Central Storage\Engineering\Lennox\.ssh"
$destinationFolder = "C:\Users\VTI\.ssh"

$sourceCredential = Get-Credential -Message "Enter credentials for the source folder"
$sourceUsername = $sourceCredential.UserName
$sourcePassword = $sourceCredential.GetNetworkCredential().Password

$net = new-object -ComObject WScript.Network
$net.MapNetworkDrive("Z:", $sourceFolder, $false, $sourceUsername, $sourcePassword)

if(Test-Path "Z:\"){
    Copy-Item "Z:\*" -Destination $destinationFolder -Recurse -Force
    $net.RemoveNetworkDrive("Z:")
    Write-Host "SSH files copied successfully. Press any key to continue..."
    $null = $Host.UI.RawUI.ReadKey('NoEcho,IncludeKeyDown')
} else {
    Write-Error "Failed to connect to source folder."
}
#>

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

# Pause before closing
Read-Host "Press Enter to exit..."


# Reset execution policy
Set-ExecutionPolicy Default -Scope Process -Force
