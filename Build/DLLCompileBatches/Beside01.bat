@Echo off

Echo Clearing Build directory....
Del "..\DLLS\Beside01.exe" /Q
Del "..\DLLS\Temp\Beside01.exe" /Q
Del "..\DLLS\Logs\Beside01.txt" /Q

echo .
Echo Compile and copy ....
"C:\Program Files (x86)\Microsoft Visual Studio .NET 2003\Common7\IDE\devenv.exe" "..\..\CodeLibrary\SharewareProjs\DBmaint\DBmaint.sln" /rebuild release /out ..\DLLS\Logs\Beside01.txt
copy "..\..\CodeLibrary\SharewareProjs\DBmaint\bin\beside01.exe" "..\DLLS\Temp\Beside01.exe"
echo .

echo turn off validation with public keys..
"C:\Program Files (x86)\Microsoft Visual Studio .NET 2003\SDK\v1.1\Bin\sn.exe" -Vr "..\DLLS\Temp\Beside01.exe"

Echo Obfuscate ....
"..\BuildTools\ObfuscatorBook\Executables\QNDObfuscate.exe" "..\DLLS\Temp\Beside01.exe" "..\DLLS\Beside01.exe"
echo .

Echo Signing with MCL Key....
"C:\Program Files (x86)\Microsoft Visual Studio .NET 2003\SDK\v1.1\Bin\sn.exe" -R "..\DLLS\Beside01.exe" "..\..\CodeLibrary\SharewareProjs\IdeasPad\IdeasPad.snk"
echo .

Echo Adding CRC Footer ....
"..\..\CodeLibrary\SharewareProjs\CRCStamp\bin\CRCStamp.exe" "..\DLLS\Beside01.exe"
echo .

echo Finished and Tidying up
Del "..\DLLS\Temp\Beside01.exe" /Q
echo .
type ..\DLLS\Logs\Beside01.txt
pause