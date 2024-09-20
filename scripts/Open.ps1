# Change directory to the desired location
Set-Location "C:\VTI PC\System Software"

$slnFile = gci ./*.sln -Recurse | Where-Object {$_.Name -ne 'VTIWindowsControlLibrary.sln' -and $_.Name -ne 'VtiMccInterface.sln'} | sort LastWriteTime | select -last 1

Start-Process $slnFile.Fullname

$ckpFile = gci ./*.ckp -Recurse | sort LastWriteTime | select -last 1

Start-Process $ckpFile.Fullname
