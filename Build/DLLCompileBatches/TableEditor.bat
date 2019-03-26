@Echo off

Echo 1. Clearing Build directory....
Del "..\DLLS\TableEditor.dll" /Q
Del "..\DLLS\Temp\TableEditor.dll" /Q
Del "..\DLLS\Logs\TableEditor.txt" /Q

copy "..\DLLs\AppBasic.dll" "..\DLLS\Temp\AppBasic.dll" > nul

echo .
Echo 2. Compile and copy ....
"C:\Program Files (x86)\Microsoft Visual Studio .NET 2003\Common7\IDE\devenv.exe" "..\..\CodeLibrary\SharedLibraries\TableEditor\TableEditor\TableEditorDLL.sln" /rebuild release /out ..\DLLS\Logs\TableEditor.txt
copy "..\..\CodeLibrary\SharedLibraries\TableEditor\TableEditor\bin\TableEditor.dll" "..\DLLS\Temp\TableEditor.dll"
echo .

echo 3. Turn off validation with public keys..
"C:\Program Files (x86)\Microsoft Visual Studio .NET 2003\SDK\v1.1\Bin\sn.exe" -Vr "..\DLLS\Temp\TableEditor.dll"

Echo 4. Obfuscate ....
"..\BuildTools\ObfuscatorBook\Executables\QNDObfuscate.exe" "..\DLLS\Temp\TableEditor.dll" "..\DLLS\TableEditor.dll"
echo .

Echo 5. Signing with MCL Key....
"C:\Program Files (x86)\Microsoft Visual Studio .NET 2003\SDK\v1.1\Bin\sn.exe" -R "..\DLLS\TableEditor.dll" "..\..\CodeLibrary\SharewareProjs\IdeasPad\IdeasPad.snk"
echo .

echo 6. Finished and Tidying up
Del "..\DLLS\Temp\TableEditor.dll" /Q
echo .

echo -------- Results --------
type ..\DLLS\Logs\TableEditor.txt
echo -------- Results --------

pause