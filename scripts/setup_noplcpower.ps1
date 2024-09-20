$gitLink = "git@github.com:vacuumtechnology/LNX-SAL-19240-A2L_SMRC1.git"
$sourceFolder = "\\vac-controls\Central Storage\Engineering\Lennox\.ssh"


try{
	$netAdapters = Get-NetAdapter -Physical | Where-Object {$_.Name -notlike "Wi-Fi*"}
	$dnsClient = $netAdapters | Get-DnsClient | Where-Object {$_.ConnectionSpecificSuffix -ne 'vti.local'} | select -last 1
	New-NetIPAddress -AddressFamily IPv4 -InterfaceIndex $dnsClient.InterfaceIndex -IPAddress 192.168.0.7 -PrefixLength 16
} catch {
	Write-Host "Failed to set static IP for PLC ethernet adapter. Error: $_"
}


$destinationFolder = "C:\Users\VTI\.ssh"
$sourceCredential = Get-Credential -Message "Enter credentials for the source folder"
$sourceUsername = $sourceCredential.UserName
$sourcePassword = $sourceCredential.GetNetworkCredential().Password

$net = new-object -ComObject WScript.Network
$net.MapNetworkDrive("Z:", $sourceFolder, $false, $sourceUsername, $sourcePassword)

if(Test-Path "Z:\"){
    Copy-Item "\\vac-controls\Central Storage\Engineering\Lennox\.ssh\*" -Destination $destinationFolder -Recurse -Force
    $net.RemoveNetworkDrive("Z:")
    Write-Host "SSH files copied successfully. Press any key to continue..."
    $null = $Host.UI.RawUI.ReadKey('NoEcho,IncludeKeyDown')
} else {
    Write-Error "Failed to connect to source folder."
}


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

$slnFile = gci ./*.sln -Recurse | Where-Object {$_.Name -ne 'VTIWindowsControlLibrary.sln' -and $_.Name -ne 'VtiMccInterface.sln'} | sort LastWriteTime | select -last 1

#Start-Process $slnFile.Fullname
explorer $slnFile.Directory

$ckpFile = gci ./*.ckp -Recurse | sort LastWriteTime | select -last 1

Start-Process $ckpFile.Fullname

# Pause before closing
Read-Host "Press Enter to exit..."
