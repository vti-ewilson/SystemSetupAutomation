

$slnFile = gci ./*.sln -Recurse | Where-Object {$_.Name -notlike 'VTIWindowsControlLibrary' -and $_.Name -notlike 'VtiMccInterface'} | sort LastWriteTime | select -last 1

$vsPath = cmd /c "C:\Program Files (x86)\Microsoft Visual Studio\Installer\vswhere.exe" -property productPath

Start-Process $vsPath -ArgumentList $slnFile.Fullname
explorer $slnFile.Directory

$ckpFile = gci ./*.ckp -Recurse | sort LastWriteTime | select -last 1

Start-Process $ckpFile.Fullname

# Pause before closing
Read-Host "Press Enter to exit..."
