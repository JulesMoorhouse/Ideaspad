@Echo off

Echo Clearing Build directory....
Del "..\DLLS\MCLCore.dll" /Q
Del "..\DLLS\Temp\MCLCore.dll" /Q
Del "..\DLLS\Logs\MCLCore.txt" /Q

echo .
Echo Compile and copy ....
"C:\Program Files (x86)\Microsoft Visual Studio .NET 2003\Common7\IDE\devenv.exe" "..\..\CodeLibrary\SharewareProjs\MCLCore\MCLCore.sln" /rebuild release /out ..\DLLS\Logs\MCLCore.txt
copy "..\..\CodeLibrary\SharewareProjs\MCLCore\bin\MCLCore.dll" "..\DLLS\Temp\MCLCore.dll"
echo .

echo turn off validation with public keys..
"C:\Program Files (x86)\Microsoft Visual Studio .NET 2003\SDK\v1.1\Bin\sn.exe" -Vr "..\DLLS\Temp\MCLCore.dll"

Echo Obfuscate ....
"..\BuildTools\ObfuscatorBook\Executables\QNDObfuscate.exe" "..\DLLS\Temp\MCLCore.dll" "..\DLLS\MCLCore.dll"
echo .

Echo Signing with MCL Key....
"C:\Program Files (x86)\Microsoft Visual Studio .NET 2003\SDK\v1.1\Bin\sn.exe" -R "..\DLLS\MCLCore.dll" "..\..\CodeLibrary\SharewareProjs\IdeasPad\IdeasPad.snk"
echo .


echo Finished and Tidying up
Del "..\DLLS\Temp\MCLCore.dll" /Q
echo .
type ..\DLLS\Logs\MCLCore.txt
pause