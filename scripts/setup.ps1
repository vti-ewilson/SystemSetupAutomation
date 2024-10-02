#SSH KEYS

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


#STATIC IP

try{
	$netAdapters = Get-NetAdapter -Physical | Where-Object {$_.Status -eq 'Up' -and $_.Name -notlike "Wi-Fi*"}
	$dnsClient = $netAdapters | Get-DnsClient | Where-Object {$_.ConnectionSpecificSuffix -ne 'vti.local'} | select -last 1
	New-NetIPAddress -AddressFamily IPv4 -InterfaceIndex $dnsClient.InterfaceIndex -IPAddress 192.168.0.7 -PrefixLength 16
} catch {
	Write-Host "Failed to set static IP for PLC ethernet adapter. Error: $_"
}


#CLONE

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

try {
   $configFolder = ls Config -Recurse -Directory | select -last 1
   cp -r -force $configFolder "C:\VTI PC\"
}
catch {
    Write-Host "Failed to copy config folder. Error: $_"
    Read-Host "Press Enter to continue..."
}

$slnFile = gci ./*.sln -Recurse | Where-Object {$_.Name -notlike '*VTIWindowsControlLibrary*' -and $_.Name -notlike '*VtiMccInterface*'} | sort LastWriteTime | select -last 1

Set-Location $slnFile.Directory

$vsPath = cmd /c "C:\Program Files (x86)\Microsoft Visual Studio\Installer\vswhere.exe" -property productPath

Start-Process $vsPath -ArgumentList $slnFile.Name
explorer $slnFile.Directory

try {
   $ckpFile = gci ./*.ckp -Recurse | sort LastWriteTime | select -last 1
   Start-Process $ckpFile.Fullname
}
catch {

}

# Pause before closing
Read-Host "Press Enter to exit..."
