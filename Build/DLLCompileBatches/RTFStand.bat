@Echo off

Echo Clearing Build directory....
Del "..\DLLS\RTFStand.dll" /Q
Del "..\DLLS\Temp\RTFStand.dll" /Q
Del "..\DLLS\Logs\RTFStand.txt" /Q

echo .
Echo Compile and copy ....
"C:\Program Files (x86)\Microsoft Visual Studio .NET 2003\Common7\IDE\devenv.exe" "..\..\CodeLibrary\SharedLibraries\RTFStand\RTFStand.sln" /rebuild release /out ..\DLLS\Logs\RTFStand.txt
copy "..\..\CodeLibrary\SharedLibraries\RTFStand\bin\RTFStand.dll" "..\DLLS\Temp\RTFStand.dll"
echo .

echo turn off validation with public keys..
"C:\Program Files (x86)\Microsoft Visual Studio .NET 2003\SDK\v1.1\Bin\sn.exe" -Vr "..\DLLS\Temp\RTFStand.dll"

Echo Obfuscate ....
copy "..\DLLS\AppBasic.dll" "..\DLLS\Temp\AppBasic.dll"
copy "..\DLLS\WinOnly.dll" "..\DLLS\Temp\WinOnly.dll"
"..\BuildTools\ObfuscatorBook\Executables\QNDObfuscate.exe" "..\DLLS\Temp\RTFStand.dll" "..\DLLS\RTFStand.dll"
echo .

Echo Signing with MCL Key....
"C:\Program Files (x86)\Microsoft Visual Studio .NET 2003\SDK\v1.1\Bin\sn.exe" -R "..\DLLS\RTFStand.dll" "..\..\CodeLibrary\SharewareProjs\IdeasPad\IdeasPad.snk"
echo .

Echo Adding CRC Footer ....
"..\..\CodeLibrary\SharewareProjs\CRCStamp\bin\CRCStamp.exe" "..\DLLS\RTFStand.dll"
echo .

echo Finished and Tidying up
Del "..\DLLS\Temp\RTFStand.dll" /Q
Del "..\DLLS\Temp\AppBasic.dll" /Q
Del "..\DLLS\Temp\WinOnly.dll" /Q
echo .

type ..\DLLS\Logs\RTFStand.txt
pause