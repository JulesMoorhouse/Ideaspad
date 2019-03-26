@echo off

Echo Clearing Build directory....
Del "..\DLLS\Winonly.dll" /Q
Del "..\DLLS\Temp\Winonly.dll" /Q
Del "..\DLLS\Logs\WinOnly.txt" /Q

echo .
Echo Compile and copy ....
"C:\Program Files (x86)\Microsoft Visual Studio .NET 2003\Common7\IDE\devenv.exe" "..\..\CodeLibrary\SharedLibraries\WinOnly\WinOnly.sln" /rebuild release /out ..\DLLS\Logs\WinOnly.txt
copy "..\..\CodeLibrary\SharedLibraries\WinOnly\bin\WinOnly.dll" "..\DLLS\Temp\WinOnly.dll"
echo .

echo turn off validation with public keys..
"C:\Program Files (x86)\Microsoft Visual Studio .NET 2003\SDK\v1.1\Bin\sn.exe" -Vr "..\DLLS\Temp\Winonly.dll"

Echo Obfuscate ....
copy "..\..\CodeLibrary\Components\AxInterop.SHDocVw.dll" "..\DLLS\Temp\AxInterop.SHDocVw.dll" > nul
copy "..\..\CodeLibrary\Components\Interop.SHDocVw.dll" "..\DLLS\Temp\Interop.SHDocVw.dll" > nul
copy "..\..\CodeLibrary\Components\SHDocVw.dll" "..\DLLS\Temp\SHDocVw.dll" > nul
"..\BuildTools\ObfuscatorBook\Executables\QNDObfuscate.exe" "..\DLLS\Temp\WinOnly.dll" "..\DLLS\WinOnly.dll"
echo .
del "..\DLLS\Temp\AxInterop.SHDocVw.dll" /Q
del "..\DLLS\Temp\Interop.SHDocVw.dll" /Q
del "..\DLLS\Temp\SHDocVw.dll" /Q
echo .

Echo Signing with MCL Key....
"C:\Program Files (x86)\Microsoft Visual Studio .NET 2003\SDK\v1.1\Bin\sn.exe" -R "..\DLLS\WinOnly.dll" "..\..\CodeLibrary\SharewareProjs\IdeasPad\IdeasPad.snk"
echo .


echo Finished and Tidying up
Del "..\DLLS\Temp\WinOnly.dll" /Q
echo .
type ..\DLLS\Logs\WinOnly.txt
pause