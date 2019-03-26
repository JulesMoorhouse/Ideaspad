@Echo off

Echo Clearing Build directory....
Del "..\DLLS\MCLKeys.dll" /Q
Del "..\DLLS\Temp\MCLKeys.dll" /Q
Del "..\DLLS\Logs\MCLKeys.txt" /Q

echo .
Echo Compile and copy ....
"C:\Program Files (x86)\Microsoft Visual Studio .NET 2003\Common7\IDE\devenv.exe" "..\..\CodeLibrary\SharewareProjs\MCLKeys\MCLKeys.sln" /rebuild release /out ..\DLLS\Logs\MCLKeys.txt
copy "..\..\CodeLibrary\SharewareProjs\MCLKeys\bin\mclkeys.dll" "..\DLLS\Temp\MCLKeys.dll"
echo .

echo turn off validation with public keys..
"C:\Program Files (x86)\Microsoft Visual Studio .NET 2003\SDK\v1.1\Bin\sn.exe" -Vr "..\DLLS\Temp\MCLKeys.dll"

Echo Obfuscate ....
"..\BuildTools\ObfuscatorBook\Executables\QNDObfuscate.exe" "..\DLLS\Temp\MCLKeys.dll" "..\DLLS\MCLKeys.dll"
echo .

Echo Signing with MCL Key....
"C:\Program Files (x86)\Microsoft Visual Studio .NET 2003\SDK\v1.1\Bin\sn.exe" -R "..\DLLS\MCLKeys.dll" "..\..\CodeLibrary\SharewareProjs\IdeasPad\IdeasPad.snk"
echo .

echo Finished and Tidying up
Del "..\DLLS\Temp\MCLKeys.dll" /Q
echo .
type ..\DLLS\Logs\MCLKeys.txt
pause