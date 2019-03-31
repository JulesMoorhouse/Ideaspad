@Echo off

Echo Clearing Build directory....
Del "..\DLLS\IPIconsPack.dll" /Q
Del "..\DLLS\Temp\IPIconsPack.dll" /Q
Del "..\DLLS\Logs\IPIconsPack.txt" /Q

echo .

echo .
Echo Compile and copy ....
"C:\Program Files (x86)\Microsoft Visual Studio .NET 2003\Common7\IDE\devenv.exe" "..\..\CodeLibrary\SharedLibraries\IPIconsPack\IPIconsPack.sln" /rebuild release /out ..\DLLS\Logs\IPIconsPack.txt

echo -------- Results --------
type ..\DLLS\Logs\IPIconsPack.txt
echo -------- Results --------

copy "..\..\CodeLibrary\SharedLibraries\IPIconsPack\bin\IPIconsPack.dll" "..\DLLS\Temp\IPIconsPack.dll"
echo .

echo turn off validation with public keys..
"C:\Program Files (x86)\Microsoft Visual Studio .NET 2003\SDK\v1.1\Bin\sn.exe" -Vr "..\DLLS\Temp\IPIconsPack.dll"

Echo Obfuscate ....
"..\BuildTools\ObfuscatorBook\Executables\QNDObfuscate.exe" "..\DLLS\Temp\IPIconsPack.dll" "..\DLLS\IPIconsPack.dll"
echo .

Echo Signing with MCL Key....
"C:\Program Files (x86)\Microsoft Visual Studio .NET 2003\SDK\v1.1\Bin\sn.exe" -R "..\DLLS\IPIconsPack.dll" "..\..\CodeLibrary\SharewareProjs\IdeasPad\IdeasPad.snk"
echo .

echo Finished and Tidying up
Del "..\DLLS\Temp\IPIconsPack.dll" /Q
echo .
type ..\DLLS\Logs\IPIconsPack.txt
pause

