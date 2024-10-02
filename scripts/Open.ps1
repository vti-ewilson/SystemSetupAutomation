

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
