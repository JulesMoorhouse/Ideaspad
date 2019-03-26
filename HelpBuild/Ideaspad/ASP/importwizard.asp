<% @ LANGUAGE="VBSCRIPT" %>
<% 	Response.Buffer = True
%>
<%
lstrTitle = "Import Wizard " %>
<!-- #include file="_header.htm" -->
<% ThisPage = lstrPGImportWiz %>
<font color="#0000ff">
Before reading this section, please refer to the section on the <a href="<% = lstrPGExportWiz %>">Export Wizard</a>.
</font>

<BR><BR>

Now, on the first screen of the import wizard you are invited to choose an import file.

<br>

Once selected click next.

<BR><BR>

On the next screen you will see what items are available in the import file.

<BR><BR>
&nbsp;&nbsp;&nbsp;<img src="gfx/import_wizard.png" border="0" height="301" width="374">
<BR><BR>

As you would expect the import wizard is limited by the import file provided and its contents.<BR>
Therefore even if you (or the person who has created the export file) had chosen to export say a bookmark, if there were no bookmarks available to be exported theses will not be available for import.
<BR><BR>

Once you have selected which items you'd like to import click next.

<BR><BR>

If you selected to import some topics, the next screen enables you to select a branch where you would like to put those topics.<BR>
Again, click next after selection.

<BR><BR>

Then the final screen will import the file, by a click of the import button.


<!-- #include file="_footer.htm" -->
