@Echo off

Echo Clearing Build directory....
Del "..\DLLS\Beside02.exe" /Q
Del "..\DLLS\Temp\Beside02.exe" /Q
Del "..\DLLS\Logs\Beside02.txt" /Q

echo .
Echo Compile and copy ....
"C:\Program Files (x86)\Microsoft Visual Studio .NET 2003\Common7\IDE\devenv.exe" "..\..\CodeLibrary\SharewareProjs\UpdateRestart\UpdateRestart.sln" /rebuild release /out ..\DLLS\Logs\Beside02.txt
copy "..\..\CodeLibrary\SharewareProjs\UpdateRestart\bin\beside02.exe" "..\DLLS\Temp\Beside02.exe"
echo .

echo turn off validation with public keys..
"C:\Program Files (x86)\Microsoft Visual Studio .NET 2003\SDK\v1.1\Bin\sn.exe" -Vr "..\DLLS\Temp\Beside02.exe"

Echo Obfuscate ....
"..\BuildTools\ObfuscatorBook\Executables\QNDObfuscate.exe" "..\DLLS\Temp\Beside02.exe" "..\DLLS\Beside02.exe"
echo .

Echo Signing with MCL Key....
"C:\Program Files (x86)\Microsoft Visual Studio .NET 2003\SDK\v1.1\Bin\sn.exe" -R "..\DLLS\Beside02.exe" "..\..\CodeLibrary\SharewareProjs\IdeasPad\IdeasPad.snk"
echo .

Echo Adding CRC Footer ....
"..\..\CodeLibrary\SharewareProjs\CRCStamp\bin\CRCStamp.exe" "..\DLLS\Beside02.exe"
echo .

echo Finished and Tidying up
Del "..\DLLS\Temp\Beside02.exe" /Q
echo .
type ..\DLLS\Logs\Beside02.txt
pause