

$sourceFolder = "{SSHFOLDER}"
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