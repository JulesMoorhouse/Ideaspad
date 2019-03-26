echo off
c:
cd "c:\Program Files\Common Files\System\ado"

"C:\Program Files\Microsoft Visual Studio .NET\FrameworkSDK\Bin\tlbimp" /keyfile:"D:\CodeLibrary\SharewareProjs\IdeasPad\ideaspad.snk" msadox.dll
"C:\Program Files\Microsoft Visual Studio .NET\FrameworkSDK\Bin\tlbimp" /keyfile:"D:\CodeLibrary\SharewareProjs\IdeasPad\ideaspad.snk" msjro.dll

"C:\Program Files\Microsoft Visual Studio .NET\FrameworkSDK\Bin\gacutil" /i adox.dll
"C:\Program Files\Microsoft Visual Studio .NET\FrameworkSDK\Bin\gacutil" /i jro.dll

echo 
pause