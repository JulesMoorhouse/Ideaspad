rem "C:\Program Files\Microsoft Visual Studio .NET\FrameworkSDK\Bin\Aximp" "C:\Program Files\Microsoft SQL Server\80\Tools\Binn\SQLDMO.dll" /Out:D:\CodeLibrary\Components\AxInterop.SQLDMO.dll /keyfile:D:\CodeLibrary\SharewareProjs\IdeasPad\IdeasPad.snk


tlbimp.exe "C:\Program Files\Microsoft SQL Server\80\Tools\Binn\SQLDMO.dll" /keyfile:D:\CodeLibrary\SharewareProjs\IdeasPad\IdeasPad.snk /out:"D:\CodeLibrary\Components\Interop.SQLDMO.dll"

pause

"C:\Program Files (x86)\Microsoft Visual Studio .NET 2003\SDK\v1.1\Bin\sn.exe" -R "D:\CodeLibrary\Components\Interop.SQLDMO.dll" "D:\CodeLibrary\SharewareProjs\IdeasPad\IdeasPad.snk"

pause