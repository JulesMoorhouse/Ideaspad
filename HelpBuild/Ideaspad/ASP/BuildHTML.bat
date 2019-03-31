@Echo off

Echo Clearing Build directory....
Del "D:\HelpBuild\Ideaspad\*.html" /Q

echo .
Echo Generating Files...
"..\..\..\Build\BuildTools\htmlsqueeze.exe" http://localhost/helpip/spelling.asp "..\spelling.html" NONE
"..\..\..\Build\BuildTools\htmlsqueeze.exe" http://localhost/helpip/support.asp "..\support.html" NONE
"..\..\..\Build\BuildTools\htmlsqueeze.exe" http://localhost/helpip/templatemenu.asp "..\templatemenu.html" NONE
"..\..\..\Build\BuildTools\htmlsqueeze.exe" http://localhost/helpip/templatesearch.asp "..\templatesearch.html" NONE
"..\..\..\Build\BuildTools\htmlsqueeze.exe" http://localhost/helpip/toolsoptions.asp "..\toolsoptions.html" NONE
"..\..\..\Build\BuildTools\htmlsqueeze.exe" http://localhost/helpip/welcome.asp "..\welcome.html" NONE
"..\..\..\Build\BuildTools\htmlsqueeze.exe" http://localhost/helpip/whatsatemplate.asp "..\whatsatemplate.html" NONE
"..\..\..\Build\BuildTools\htmlsqueeze.exe" http://localhost/helpip/buy.asp "..\buy.html" NONE
"..\..\..\Build\BuildTools\htmlsqueeze.exe" http://localhost/helpip/importrichtext.asp "..\importrichtext.html" NONE
"..\..\..\Build\BuildTools\htmlsqueeze.exe" http://localhost/helpip/sharingtemplates.asp "..\sharingtemplates.html" NONE
"..\..\..\Build\BuildTools\htmlsqueeze.exe" http://localhost/helpip/templatesprovided.asp "..\templatesprovided.html" NONE
"..\..\..\Build\BuildTools\htmlsqueeze.exe" http://localhost/helpip/bookmarks.asp "..\bookmarks.html" NONE
"..\..\..\Build\BuildTools\htmlsqueeze.exe" http://localhost/helpip/branchprops.asp "..\branchprops.html" NONE
"..\..\..\Build\BuildTools\htmlsqueeze.exe" http://localhost/helpip/createtemplates.asp "..\createtemplates.html" NONE
"..\..\..\Build\BuildTools\htmlsqueeze.exe" http://localhost/helpip/exporttempldata.asp "..\exporttempldata.html" NONE
"..\..\..\Build\BuildTools\htmlsqueeze.exe" http://localhost/helpip/exportwizard.asp "..\exportwizard.html" NONE
"..\..\..\Build\BuildTools\htmlsqueeze.exe" http://localhost/helpip/importwizard.asp "..\importwizard.html" NONE
"..\..\..\Build\BuildTools\htmlsqueeze.exe" http://localhost/helpip/maintenance.asp "..\maintenance.html" NONE
"..\..\..\Build\BuildTools\htmlsqueeze.exe" http://localhost/helpip/quickstart.asp "..\quickstart.html" NONE
"..\..\..\Build\BuildTools\htmlsqueeze.exe" http://localhost/helpip/rapidentry.asp "..\rapidentry.html" NONE


Echo Finished Generating....
echo .
pause