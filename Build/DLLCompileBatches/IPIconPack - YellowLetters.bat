@Echo off

Echo Clearing Build directory....
Del "..\DLLS\OtherIconPacks\YellowLetters\IPIconsPack.dll" /Q
Del "..\DLLS\OtherIconPacks\YellowLetters\Temp\IPIconsPack.dll" /Q
Del "..\DLLS\OtherIconPacks\YellowLetters\Logs\IPIconsPack.txt" /Q

echo .

echo .
Echo Compile and copy ....
"C:\Program Files (x86)\Microsoft Visual Studio .NET 2003\Common7\IDE\devenv.exe" "..\..\CodeLibrary\SharewareProjs\IPIconsPackOne\IPIconsPack.sln" /rebuild release /out ..\DLLS\OtherIconPacks\YellowLetters\Logs\IPIconsPack.txt

echo -------- Results --------
type ..\DLLS\OtherIconPacks\YellowLetters\Logs\IPIconsPack.txt
echo -------- Results --------

copy "..\..\CodeLibrary\SharewareProjs\IPIconsPackOne\bin\IPIconsPack.dll" "..\DLLS\OtherIconPacks\YellowLetters\Temp\IPIconsPack.dll"
echo .

echo turn off validation with public keys..
"C:\Program Files (x86)\Microsoft Visual Studio .NET 2003\SDK\v1.1\Bin\sn.exe" -Vr "..\DLLS\OtherIconPacks\YellowLetters\Temp\IPIconsPack.dll"

Echo Obfuscate ....
"..\BuildTools\ObfuscatorBook\Executables\QNDObfuscate.exe" "..\DLLS\OtherIconPacks\YellowLetters\Temp\IPIconsPack.dll" "..\DLLS\OtherIconPacks\YellowLetters\IPIconsPack.dll"
echo .

Echo Signing with MCL Key....
"C:\Program Files (x86)\Microsoft Visual Studio .NET 2003\SDK\v1.1\Bin\sn.exe" -R "..\DLLS\OtherIconPacks\YellowLetters\IPIconsPack.dll" "..\..\CodeLibrary\SharewareProjs\IdeasPad\IdeasPad.snk"
echo .

echo Finished and Tidying up
Del "..\DLLS\OtherIconPacks\YellowLetters\Temp\IPIconsPack.dll" /Q
echo .
type ..\DLLS\OtherIconPacks\YellowLetters\Logs\IPIconsPack.txt
pause

