

try{
	$netAdapters = Get-NetAdapter -Physical | Where-Object {$_.Status -eq 'Up' -and $_.Name -notlike "Wi-Fi*"}
	$dnsClient = $netAdapters | Get-DnsClient | Where-Object {$_.ConnectionSpecificSuffix -ne 'vti.local'} | select -last 1
	New-NetIPAddress -AddressFamily IPv4 -InterfaceIndex $dnsClient.InterfaceIndex -IPAddress 192.168.0.7 -PrefixLength 16
} catch {
	Write-Host "Failed to set static IP for PLC ethernet adapter. Error: $_"
}