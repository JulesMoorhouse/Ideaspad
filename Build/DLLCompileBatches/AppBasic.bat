@Echo off

Echo Clearing Build directory....
Del "..\DLLS\AppBasic.dll" /Q
Del "..\DLLS\Temp\AppBasic.dll" /Q
Del "..\DLLS\Logs\AppBasic.txt" /Q

echo .
Echo Compile and copy ....
"C:\Program Files (x86)\Microsoft Visual Studio .NET 2003\Common7\IDE\devenv.exe" "..\..\CodeLibrary\SharedLibraries\AppBasic\AppBasic.sln" /rebuild release /out ..\DLLS\Logs\AppBasic.txt
copy "..\..\CodeLibrary\SharedLibraries\AppBasic\bin\AppBasic.dll" "..\DLLS\Temp\AppBasic.dll"
echo .

echo turn off validation with public keys..
"C:\Program Files (x86)\Microsoft Visual Studio .NET 2003\SDK\v1.1\Bin\sn.exe" -Vr "..\DLLS\Temp\AppBasic.dll"

Echo Obfuscate ....
"..\BuildTools\ObfuscatorBook\Executables\QNDObfuscate.exe" "..\DLLS\Temp\AppBasic.dll" "..\DLLS\AppBasic.dll"
echo .

Echo Signing with MCL Key....
"C:\Program Files (x86)\Microsoft Visual Studio .NET 2003\SDK\v1.1\Bin\sn.exe" -R "..\DLLS\AppBasic.dll" "..\..\CodeLibrary\SharewareProjs\IdeasPad\IdeasPad.snk"
echo .

Echo Adding CRC Footer ....
"..\..\CodeLibrary\SharewareProjs\CRCStamp\bin\CRCStamp.exe" "..\DLLS\AppBasic.dll"
echo .

echo Finished and Tidying up
Del "..\DLLS\Temp\AppBasic.dll" /Q
echo .
type ..\DLLS\Logs\AppBasic.txt
pause