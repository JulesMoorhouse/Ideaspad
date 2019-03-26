@Echo off

Echo Clearing Build directory....
Del "D:\HelpBuild\Ideaspad\de\*.html" /Q

echo .
Echo Generating Files...
D:\Build\BuildTools\htmlsqueeze.exe http://localhost/helpip/de/spelling.asp D:\HelpBuild\Ideaspad\de\spelling.html NONE
D:\Build\BuildTools\htmlsqueeze.exe http://localhost/helpip/de/support.asp D:\HelpBuild\Ideaspad\de\support.html NONE
D:\Build\BuildTools\htmlsqueeze.exe http://localhost/helpip/de/templatemenu.asp D:\HelpBuild\Ideaspad\de\templatemenu.html NONE
D:\Build\BuildTools\htmlsqueeze.exe http://localhost/helpip/de/templatesearch.asp D:\HelpBuild\Ideaspad\de\templatesearch.html NONE
D:\Build\BuildTools\htmlsqueeze.exe http://localhost/helpip/de/toolsoptions.asp D:\HelpBuild\Ideaspad\de\toolsoptions.html NONE
D:\Build\BuildTools\htmlsqueeze.exe http://localhost/helpip/de/welcome.asp D:\HelpBuild\Ideaspad\de\welcome.html NONE
D:\Build\BuildTools\htmlsqueeze.exe http://localhost/helpip/de/whatsatemplate.asp D:\HelpBuild\Ideaspad\de\whatsatemplate.html NONE
D:\Build\BuildTools\htmlsqueeze.exe http://localhost/helpip/de/buy.asp D:\HelpBuild\Ideaspad\de\buy.html NONE
D:\Build\BuildTools\htmlsqueeze.exe http://localhost/helpip/de/importrichtext.asp D:\HelpBuild\Ideaspad\de\importrichtext.html NONE
D:\Build\BuildTools\htmlsqueeze.exe http://localhost/helpip/de/sharingtemplates.asp D:\HelpBuild\Ideaspad\de\sharingtemplates.html NONE
D:\Build\BuildTools\htmlsqueeze.exe http://localhost/helpip/de/templatesprovided.asp D:\HelpBuild\Ideaspad\de\templatesprovided.html NONE
D:\Build\BuildTools\htmlsqueeze.exe http://localhost/helpip/de/bookmarks.asp D:\HelpBuild\Ideaspad\de\bookmarks.html NONE
D:\Build\BuildTools\htmlsqueeze.exe http://localhost/helpip/de/branchprops.asp D:\HelpBuild\Ideaspad\de\branchprops.html NONE
D:\Build\BuildTools\htmlsqueeze.exe http://localhost/helpip/de/createtemplates.asp D:\HelpBuild\Ideaspad\de\createtemplates.html NONE
D:\Build\BuildTools\htmlsqueeze.exe http://localhost/helpip/de/exporttempldata.asp D:\HelpBuild\Ideaspad\de\exporttempldata.html NONE
D:\Build\BuildTools\htmlsqueeze.exe http://localhost/helpip/de/exportwizard.asp D:\HelpBuild\Ideaspad\de\exportwizard.html NONE
D:\Build\BuildTools\htmlsqueeze.exe http://localhost/helpip/de/importwizard.asp D:\HelpBuild\Ideaspad\de\importwizard.html NONE
D:\Build\BuildTools\htmlsqueeze.exe http://localhost/helpip/de/maintenance.asp D:\HelpBuild\Ideaspad\de\maintenance.html NONE
D:\Build\BuildTools\htmlsqueeze.exe http://localhost/helpip/de/quickstart.asp D:\HelpBuild\Ideaspad\de\quickstart.html NONE
D:\Build\BuildTools\htmlsqueeze.exe http://localhost/helpip/de/rapidentry.asp D:\HelpBuild\Ideaspad\de\rapidentry.html NONE


Echo Finished Generating....
echo .
pause