@Echo off

Echo Clearing Build directory....
Del "..\DLLS\Beside03.exe" /Q
Del "..\DLLS\Temp\Beside03.exe" /Q
Del "..\DLLS\Logs\Beside03.txt" /Q

echo .
Echo Compile and copy ....
"C:\Program Files (x86)\Microsoft Visual Studio .NET 2003\Common7\IDE\devenv.exe" "..\..\CodeLibrary\SharewareProjs\UninQuest\UninQuest.sln" /rebuild release /out ..\DLLS\Logs\Beside03.txt
copy "..\..\CodeLibrary\SharewareProjs\UninQuest\bin\beside03.exe" "..\DLLS\Temp\Beside03.exe"
echo .

echo turn off validation with public keys..
"C:\Program Files (x86)\Microsoft Visual Studio .NET 2003\SDK\v1.1\Bin\sn.exe" -Vr "..\DLLS\Temp\Beside03.exe"

Echo Obfuscate ....
"..\BuildTools\ObfuscatorBook\Executables\QNDObfuscate.exe" "..\DLLS\Temp\Beside03.exe" "..\DLLS\Beside03.exe"
echo .

Echo Signing with MCL Key....
"C:\Program Files (x86)\Microsoft Visual Studio .NET 2003\SDK\v1.1\Bin\sn.exe" -R "..\DLLS\Beside03.exe" "..\..\CodeLibrary\SharewareProjs\IdeasPad\IdeasPad.snk"
echo .

Echo Adding CRC Footer ....
"..\..\CodeLibrary\SharewareProjs\CRCStamp\bin\CRCStamp.exe" "..\DLLS\Beside03.exe"
echo .

echo Finished and Tidying up
Del "..\DLLS\Temp\Beside03.exe" /Q
echo .
type ..\DLLS\Logs\Beside03.txt
pause