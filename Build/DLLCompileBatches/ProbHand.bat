@Echo off

Echo Clearing Build directory....
Del "..\DLLS\ProbHand.dll" /Q
Del "..\DLLS\Temp\ProbHand.dll" /Q
Del "..\DLLS\Logs\ProbHand.txt" /Q

echo .
Echo Compile and copy ....
"C:\Program Files (x86)\Microsoft Visual Studio .NET 2003\Common7\IDE\devenv.exe" "..\..\CodeLibrary\SharedLibraries\ProbHand\ProbHand.sln" /rebuild release /out ..\DLLS\Logs\ProbHand.txt
copy "..\..\CodeLibrary\SharedLibraries\ProbHand\bin\ProbHand.dll" "..\DLLS\Temp\ProbHand.dll"
echo .

echo turn off validation with public keys..
"C:\Program Files (x86)\Microsoft Visual Studio .NET 2003\SDK\v1.1\Bin\sn.exe" -Vr "..\DLLS\Temp\ProbHand.dll"

Echo Obfuscate ....
copy "..\DLLS\AppBasic.dll" "..\DLLS\Temp\AppBasic.dll"
copy "..\DLLS\WinOnly.dll" "..\DLLS\Temp\WinOnly.dll"
"..\BuildTools\ObfuscatorBook\Executables\QNDObfuscate.exe" "..\DLLS\Temp\ProbHand.dll" "..\DLLS\ProbHand.dll"
echo .

Echo Signing with MCL Key....
"C:\Program Files (x86)\Microsoft Visual Studio .NET 2003\SDK\v1.1\Bin\sn.exe" -R "..\DLLS\ProbHand.dll" "..\..\CodeLibrary\SharewareProjs\IdeasPad\IdeasPad.snk"
echo .

Echo Adding CRC Footer ....
"..\..\CodeLibrary\SharewareProjs\CRCStamp\bin\CRCStamp.exe" "..\DLLS\ProbHand.dll"
echo .

echo Finished and Tidying up
Del "..\DLLS\Temp\ProbHand.dll" /Q
Del "..\DLLS\Temp\AppBasic.dll" /Q
Del "..\DLLS\Temp\WinOnly.dll" /Q
echo .
type ..\DLLS\Logs\ProbHand.txt
pause