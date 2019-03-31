@Echo off

Echo Clearing Build directory....
Del "..\DLLS\IPTemplates.dll" /Q
Del "..\DLLS\Temp\IPTemplates.dll" /Q
Del "..\DLLS\Logs\IPTemplates.txt" /Q
Del "..\IPTemplates\*.dll" /Q

echo .
Echo Generating Files...

copy D:\MclDocsLocal\IdeasPadTemplates\smallyellowball.bmp ..\IPTemplates\smallyellowball.bmp

rem you can complicate things later on with ASP
copy "D:\MclDocsLocal\IdeasPadTemplates\de" "..\IPTemplates\de\"

echo .
Echo Compile and copy ....
"C:\Program Files (x86)\Microsoft Visual Studio .NET 2003\Common7\IDE\devenv.exe" "..\..\CodeLibrary\SharewareProjs\IPTemplates\IPTemplates.sln" /rebuild release /out ..\DLLS\Logs\IPTemplates.txt

echo -------- Results --------
type ..\DLLS\Logs\IPTemplates.txt
echo -------- Results --------

copy "..\..\CodeLibrary\SharewareProjs\IPTemplates\bin\IPTemplates.dll" "..\DLLS\Temp\IPTemplates.dll"
echo .

echo turn off validation with public keys..
"C:\Program Files (x86)\Microsoft Visual Studio .NET 2003\SDK\v1.1\Bin\sn.exe" -Vr "..\DLLS\Temp\IPTemplates.dll"

Echo Obfuscate ....
"..\BuildTools\ObfuscatorBook\Executables\QNDObfuscate.exe" "..\DLLS\Temp\IPTemplates.dll" "..\DLLS\IPTemplates.dll"
copy "..\DLLS\Temp\IPTemplates.resources.dll" "..\DLLS\de\IPTemplates.resources.dll"
echo .

Echo Signing with MCL Key....
"C:\Program Files (x86)\Microsoft Visual Studio .NET 2003\SDK\v1.1\Bin\sn.exe" -R "..\DLLS\IPTemplates.dll" "..\..\CodeLibrary\SharewareProjs\IdeasPad\IdeasPad.snk"
echo .

echo Finished and Tidying up
Del "..\DLLS\Temp\IPTemplates.dll" /Q
echo .
type ..\DLLS\Logs\IPTemplates.txt
pause

