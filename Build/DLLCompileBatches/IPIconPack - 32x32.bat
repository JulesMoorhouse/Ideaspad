@Echo off

Echo Clearing Build directory....
Del "..\DLLS\OtherIconPacks\IPIconsPack32x32\IPIconsPack.dll" /Q
Del "..\DLLS\OtherIconPacks\IPIconsPack32x32\Temp\IPIconsPack.dll" /Q
Del "..\DLLS\OtherIconPacks\IPIconsPack32x32\Logs\IPIconsPack.txt" /Q

echo .

echo .
Echo Compile and copy ....
"C:\Program Files (x86)\Microsoft Visual Studio .NET 2003\Common7\IDE\devenv.exe" "..\..\CodeLibrary\SharewareProjs\IPIconsPack32x32\IPIconsPack.sln" /rebuild release /out ..\DLLS\OtherIconPacks\IPIconsPack32x32\Logs\IPIconsPack.txt

echo -------- Results --------
type ..\DLLS\OtherIconPacks\IPIconsPack32x32\Logs\IPIconsPack.txt
echo -------- Results --------

copy "..\..\CodeLibrary\SharewareProjs\IPIconsPack32x32\bin\IPIconsPack.dll" "..\DLLS\OtherIconPacks\IPIconsPack32x32\Temp\IPIconsPack.dll"
echo .

echo turn off validation with public keys..
"C:\Program Files (x86)\Microsoft Visual Studio .NET 2003\SDK\v1.1\Bin\sn.exe" -Vr "..\DLLS\OtherIconPacks\IPIconsPack32x32\Temp\IPIconsPack.dll"

Echo Obfuscate ....
"..\BuildTools\ObfuscatorBook\Executables\QNDObfuscate.exe" "..\DLLS\OtherIconPacks\IPIconsPack32x32\Temp\IPIconsPack.dll" "..\DLLS\OtherIconPacks\IPIconsPack32x32\IPIconsPack.dll"
echo .

Echo Signing with MCL Key....
"C:\Program Files (x86)\Microsoft Visual Studio .NET 2003\SDK\v1.1\Bin\sn.exe" -R "..\DLLS\OtherIconPacks\IPIconsPack32x32\IPIconsPack.dll" "..\..\CodeLibrary\SharewareProjs\IdeasPad\IdeasPad.snk"
echo .

echo Finished and Tidying up
Del "..\DLLS\OtherIconPacks\IPIconsPack32x32\Temp\IPIconsPack.dll" /Q
echo .
type ..\DLLS\OtherIconPacks\IPIconsPack32x32\Logs\IPIconsPack.txt
pause

