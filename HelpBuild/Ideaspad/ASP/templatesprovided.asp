<% @ LANGUAGE="VBSCRIPT" %>
<% 	Response.Buffer = True
%>
<%
lstrTitle = "Standard templates" %>
<!-- #include file="_header.htm" -->
<% ThisPage = lstrPGTemplatesProvided %>

Go to the tools menu and choose 'Select Template'.
<BR><BR>
&nbsp;&nbsp;&nbsp;<img src="gfx/template_selection.png" border="0" height="306" width="368">
<BR><br>

On the left hand side are all the standard templates.<BR>
Select one, then choose whether you want it to appear on the templates menu (using the checkbox).<BR>
Then click 'Select'.

<br><br>
<font color="#0000ff">
Once you have added a template to the menu, it is also available on the right click popup menu, when selecting a topic / branch.
</font>
<br><br>
<a name="Template_options_create">
You will now be asked what you want to do with the template. &nbsp;You have several options.

<BR><BR>
&nbsp;&nbsp;&nbsp;<img src="gfx/template_topic_create.png" border="0" height="322" width="352">
<BR><BR>

As you can see, the first three options are quite simple.<BR><BR>
For information about the fourth option, 'Rapid Entry' <a href="<% = lstrPGRapidEntry %>">click here</a>.<BR><BR>
The fifth option 'Merge with selected template data (where possible)' allows you to use another template with the same data.  If the fields match then the data will be available to the new template.

<BR><BR>
<font color="#0000ff">
For information about creating your own templates <a href="<% = lstrPGTempCreate %>">click here</a>.<BR>
</font>


<!-- #include file="_footer.htm" -->
