$gitLink = "{GITLINK}"



try{
	$netAdapters = Get-NetAdapter -Physical | Where-Object {$_.Status -eq 'Up' -and $_.Name -notlike "Wi-Fi*"}
	$dnsClient = $netAdapters | Get-DnsClient | Where-Object {$_.ConnectionSpecificSuffix -ne 'vti.local'} | select -last 1
	New-NetIPAddress -AddressFamily IPv4 -InterfaceIndex $dnsClient.InterfaceIndex -IPAddress 192.168.0.7 -PrefixLength 16
} catch {
	Write-Host "Failed to set static IP for PLC ethernet adapter. Error: $_"
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

Start-Process $slnFile.Fullname
explorer $slnFile.Directory

$ckpFile = gci ./*.ckp -Recurse | sort LastWriteTime | select -last 1

Start-Process $ckpFile.Fullname

# Pause before closing
Read-Host "Press Enter to exit..."
