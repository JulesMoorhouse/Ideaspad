@Echo off

Echo 1. Clearing Build directory....
Del "IPStandard\*.*" /Q
Del "IPStandard\Temp\*.*" /Q
Del "IPStandard\Logs\*.*" /Q
echo .

Echo 2. Copy Dlls....
copy "DLLs\beside01.exe" "IPStandard\Beside01.exe" > nul
copy "DLLs\beside02.exe" "IPStandard\Beside02.exe" > nul    
copy "DLLs\beside03.exe" "IPStandard\Beside03.exe" > nul    
copy "DLLs\AppBasic.dll" "IPStandard\AppBasic.dll" > nul
copy "DLLs\RTFStand.dll" "IPStandard\RTFStand.dll" > nul
copy "DLLs\WinOnly.dll" "IPStandard\WinOnly.dll" > nul
copy "DLLs\TableEditor.dll" "IPStandard\TableEditor.dll" > nul
copy "DLLs\MCLCore.dll" "IPStandard\MCLCore.dll" > nul
copy "DLLs\IPTemplates.dll" "IPStandard\IPTemplates.dll" > nul
copy "DLLs\IPIconsPack.dll" "IPStandard\IPIconsPack.dll" > nul
copy "DLLs\ProbHand.dll" "IPStandard\ProbHand.dll" > nul
copy "DLLs\UIStyle.dll" "IPStandard\UIStyle.dll" > nul
copy "..\CodeLibrary\Components\AxInterop.SHDocVw.dll" "IPStandard\AxInterop.SHDocVw.dll" > nul
copy "..\CodeLibrary\Components\SHDocVw.dll" "IPStandard\SHDocVw.dll" > nul
copy "DLLs\AppBasic.dll" "IPStandard\Temp\AppBasic.dll" > nul
copy "DLLs\RTFStand.dll" "IPStandard\Temp\RTFStand.dll" > nul
copy "DLLs\WinOnly.dll" "IPStandard\Temp\WinOnly.dll" > nul
copy "DLLs\TableEditor.dll" "IPStandard\Temp\TableEditor.dll" > nul
copy "DLLs\MCLCore.dll" "IPStandard\Temp\MCLCore.dll" > nul
copy "DLLs\IPTemplates.dll" "IPStandard\Temp\IPTemplates.dll" > nul
copy "DLLs\IPIconsPack.dll" "IPStandard\Temp\IPIconsPack.dll" > nul
copy "DLLs\ProbHand.dll" "IPStandard\Temp\ProbHand.dll" > nul
copy "DLLs\UIStyle.dll" "IPStandard\Temp\UIStyle.dll" > nul
copy "..\CodeLibrary\Components\SharpZipLib.dll" "IPStandard\SharpZipLib.dll" > nul
copy "..\CodeLibrary\Components\AxInterop.SHDocVw.dll" "IPStandard\Temp\AxInterop.SHDocVw.dll" > nul
copy "..\CodeLibrary\Components\Interop.SHDocVw.dll" "IPStandard\Temp\Interop.SHDocVw.dll" > nul
copy "..\CodeLibrary\SharewareProjs\IdeasPad\bin\ADODB.dll" "IPStandard\Temp\ADODB.dll" > nul

rem copy "..\CodeLibrary\Components\*.*" "IPStandard\Temp\." /Y
rem copy "..\CodeLibrary\Components\*.*" "IPStandard\." /Y

echo .

Echo 3. Compile and copy ideasPad.exe....
"C:\Program Files (x86)\Microsoft Visual Studio .NET 2003\Common7\IDE\devenv.exe" "..\CodeLibrary\SharewareProjs\IdeasPad\IdeasPad.sln" /rebuild release /out Build\IPStandard\Logs\IPStandard.txt


echo -------- Results --------
type Build\IPStandard\Logs\IPStandard.txt
echo -------- Results --------


copy "..\CodeLibrary\SharewareProjs\IdeasPad\bin\IdeasPad.exe" "IPStandard\Temp\IdeasPad.exe"
echo .

echo 4. Turn off validation with public keys..
"C:\Program Files (x86)\Microsoft Visual Studio .NET 2003\SDK\v1.1\Bin\sn.exe" -Vr "IPStandard\Temp\IdeasPad.exe"
echo .

Echo 5. Obfuscate IdeasPad....
"BuildTools\ObfuscatorBook\Executables\QNDObfuscate.exe" "IPStandard\Temp\IdeasPad.exe" "IPStandard\IdeasPad.exe"
echo .

Del "IPStandard\Temp\*.*" /Q

Echo 6. Signing IdeasPad with MCL Key....
"C:\Program Files (x86)\Microsoft Visual Studio .NET 2003\SDK\v1.1\Bin\sn.exe" -R "IPStandard\IdeasPad.exe" "..\CodeLibrary\SharewareProjs\IdeasPad\IdeasPad.snk"
echo .

Echo 7. Adding CRC Footer IdeasPad....
"..\CodeLibrary\SharewareProjs\CRCStamp\bin\CRCStamp.exe" "IPStandard\IdeasPad.exe"

Echo 8. Check your EXE at this point see if CRC has worked OK!!
echo.

echo.
echo 9. REMEMBER TO CHANGE THE VERSION NUMBER IN LOCALIZED DLLS TOO IF NECESSARY!!!

Echo Compile and copy Setup prog, which will now point at new builds....
echo REMEMBER This may take a few minutes due to MSHTML
"C:\Program Files (x86)\Microsoft Visual Studio .NET 2003\Common7\IDE\devenv.exe" "..\CodeLibrary\SharewareProjs\IPStdSetup\IPStdSetup.sln" /rebuild release /out Build\IPStandard\Logs\IPDSetupDBuild.txt
copy "..\CodeLibrary\SharewareProjs\IPStdSetup\Release\Ideaspad.msi" "IPStandard\Ideaspad.msi"
echo .

Echo 11. Finished MSI....
echo .

rem Echo 12. Generating backup site(s) update...
rem del Build\BakUpdSites\temp\*.* /Q
rem echo .

copy "DLLs\mclkeys.dll" "IPStandard\mclkeys.dll"

rem Echo Zipping and creating MCLS updates files....
rem md Build\MCLSoftWeb\temp
rem del Build\MCLSoftWeb\temp\*.* /Q

rem copy "IPStandard\*.dll" "MCLSoftWeb\Temp\*.dll"
rem copy "IPStandard\*.exe" "MCLSoftWeb\Temp\*.exe"
rem copy "..\CodeLibrary\SharewareProjs\IdeasPad\tipofday.txt" "MCLSoftWeb\Temp\tipofday.txt"

rem echo .

rem Build\BuildTools\ZipUpdCreate.exe Build\MCLSoftWeb\ ipd.dat ideaspad.exe ipdemo.xml http://www.example.com updates/neptune/ updates/neptune/

rem del Build\MCLSoftWeb\temp\*.* /Q
rem rd Build\MCLSoftWeb\temp
rem echo .

rem Echo Copying files....

rem copy "IPStandard\*.dll" "BakUpdSites\Temp\*.dll"
rem copy "IPStandard\*.exe" "BakUpdSites\Temp\*.exe"
rem copy "..\CodeLibrary\SharewareProjs\IdeasPad\tipofday.txt" "BakUpdSites\Temp\tipofday.txt"


rem Echo Zipping and creating updates files....
rem ZipUpdCreate ZipFile-BaseDir DestZipFile ProdVerFile XMLFile FromVersnums "1.0.3.0#1.0.4.0#"

rem Build\BuildTools\ZipUpdCreate.exe Build\BakUpdSites\ ipd.dat ideaspad.exe ipdemo.xml http://www.example.co.uk updates/neptune/ WDDS/neptune/ 

rem echo .
rem echo Finished generating backup site(s) update....
rem echo .

Echo Generating Distribution update...
rem echo .
rem copy "..\CodeLibrary\SharewareProjs\ZipToSelfEx\bin\ZipToSelfEx.exe" "BuildTools\ZipToSelfEx.exe"
copy "IPStandard\Ideaspad.msi" "IPStandard\DistBuild\Ideaspad.msi"
echo .
rem "BuildTools\ZipToSelfEx.exe" Build\IPStandard\IdeasPad.exe IdPad Build\IPStandard\DistBuild\ Build\MCLSoftWeb\distribution\ideaspad\
rem echo.
rem echo Copy Distrib to backup dir
rem copy "MCLSoftWeb\distribution\ideaspad\*.exe" "BakUpdSites\distribution\ideaspad\*.exe"
rem echo .

rem echo Finished IPStandard Build, Update and Distrib update
rem echo .

pause