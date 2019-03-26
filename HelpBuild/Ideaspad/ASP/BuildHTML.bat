@Echo off

Echo Clearing Build directory....
Del "D:\HelpBuild\Ideaspad\*.html" /Q

echo .
Echo Generating Files...
D:\Build\BuildTools\htmlsqueeze.exe http://localhost/helpip/spelling.asp D:\HelpBuild\Ideaspad\spelling.html NONE
D:\Build\BuildTools\htmlsqueeze.exe http://localhost/helpip/support.asp D:\HelpBuild\Ideaspad\support.html NONE
D:\Build\BuildTools\htmlsqueeze.exe http://localhost/helpip/templatemenu.asp D:\HelpBuild\Ideaspad\templatemenu.html NONE
D:\Build\BuildTools\htmlsqueeze.exe http://localhost/helpip/templatesearch.asp D:\HelpBuild\Ideaspad\templatesearch.html NONE
D:\Build\BuildTools\htmlsqueeze.exe http://localhost/helpip/toolsoptions.asp D:\HelpBuild\Ideaspad\toolsoptions.html NONE
D:\Build\BuildTools\htmlsqueeze.exe http://localhost/helpip/welcome.asp D:\HelpBuild\Ideaspad\welcome.html NONE
D:\Build\BuildTools\htmlsqueeze.exe http://localhost/helpip/whatsatemplate.asp D:\HelpBuild\Ideaspad\whatsatemplate.html NONE
D:\Build\BuildTools\htmlsqueeze.exe http://localhost/helpip/buy.asp D:\HelpBuild\Ideaspad\buy.html NONE
D:\Build\BuildTools\htmlsqueeze.exe http://localhost/helpip/importrichtext.asp D:\HelpBuild\Ideaspad\importrichtext.html NONE
D:\Build\BuildTools\htmlsqueeze.exe http://localhost/helpip/sharingtemplates.asp D:\HelpBuild\Ideaspad\sharingtemplates.html NONE
D:\Build\BuildTools\htmlsqueeze.exe http://localhost/helpip/templatesprovided.asp D:\HelpBuild\Ideaspad\templatesprovided.html NONE
D:\Build\BuildTools\htmlsqueeze.exe http://localhost/helpip/bookmarks.asp D:\HelpBuild\Ideaspad\bookmarks.html NONE
D:\Build\BuildTools\htmlsqueeze.exe http://localhost/helpip/branchprops.asp D:\HelpBuild\Ideaspad\branchprops.html NONE
D:\Build\BuildTools\htmlsqueeze.exe http://localhost/helpip/createtemplates.asp D:\HelpBuild\Ideaspad\createtemplates.html NONE
D:\Build\BuildTools\htmlsqueeze.exe http://localhost/helpip/exporttempldata.asp D:\HelpBuild\Ideaspad\exporttempldata.html NONE
D:\Build\BuildTools\htmlsqueeze.exe http://localhost/helpip/exportwizard.asp D:\HelpBuild\Ideaspad\exportwizard.html NONE
D:\Build\BuildTools\htmlsqueeze.exe http://localhost/helpip/importwizard.asp D:\HelpBuild\Ideaspad\importwizard.html NONE
D:\Build\BuildTools\htmlsqueeze.exe http://localhost/helpip/maintenance.asp D:\HelpBuild\Ideaspad\maintenance.html NONE
D:\Build\BuildTools\htmlsqueeze.exe http://localhost/helpip/quickstart.asp D:\HelpBuild\Ideaspad\quickstart.html NONE
D:\Build\BuildTools\htmlsqueeze.exe http://localhost/helpip/rapidentry.asp D:\HelpBuild\Ideaspad\rapidentry.html NONE


Echo Finished Generating....
echo .
pause