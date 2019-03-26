@Echo off

Echo Clearing Build directory....
Del "..\DLLS\UIStyle.dll" /Q
Del "..\DLLS\Temp\UIStyle.dll" /Q
Del "..\DLLS\Logs\UIStyle.txt" /Q

echo .

echo .
Echo Compile and copy ....
"C:\Program Files (x86)\Microsoft Visual Studio .NET 2003\Common7\IDE\devenv.exe" "..\..\CodeLibrary\SharewareProjs\UIStyle\UIStyle.sln" /rebuild release /out ..\DLLS\Logs\UIStyle.txt
copy "..\..\CodeLibrary\SharewareProjs\UIStyle\bin\UIStyle.dll" "..\DLLS\Temp\UIStyle.dll"
echo .

echo turn off validation with public keys..
"C:\Program Files (x86)\Microsoft Visual Studio .NET 2003\SDK\v1.1\Bin\sn.exe" -Vr "..\DLLS\Temp\UIStyle.dll"

Echo Obfuscate ....
"..\BuildTools\ObfuscatorBook\Executables\QNDObfuscate.exe" "..\DLLS\Temp\UIStyle.dll" "..\DLLS\UIStyle.dll"
echo .

Echo Signing with MCL Key....
"C:\Program Files (x86)\Microsoft Visual Studio .NET 2003\SDK\v1.1\Bin\sn.exe" -R "..\DLLS\UIStyle.dll" "..\..\CodeLibrary\SharewareProjs\IdeasPad\IdeasPad.snk"
echo .

echo Finished and Tidying up
Del "..\DLLS\Temp\UIStyle.dll" /Q
echo .
type ..\DLLS\Logs\UIStyle.txt
pause

