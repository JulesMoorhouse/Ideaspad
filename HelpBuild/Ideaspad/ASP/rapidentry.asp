<% @ LANGUAGE="VBSCRIPT" %>
<% 	Response.Buffer = True
%>
<%
lstrTitle = "Rapid Entry" %>
<!-- #include file="_header.htm" -->
<% ThisPage = lstrPGRapidEntry %>


Rapid Entry is a feature which allows you to quickly enter information using a template.<BR>
Once selected it uses a template to create lots of topics with the same template.<BR>
This could be used say to enter lots of addresses for example.
<BR><BR>
<img src="gfx\rapidentry.png" width="504" height="432">
<BR><BR>
<h1>Where you can use it?</h1>

<b>Templates menu (after selecting a template)</b><BR>
Once you have some templates on the templates menu (see help on <a href="<% = lstrPGTemplatesProvided %>">selecting templates</a>) you can select a template, then on the next screen select 'Rapid Entry'.

<BR><BR>

<b>Toolbar button or the 'Rapid Entry' option on the Templates menu</b><BR>
You may have a system where you're always going to use a specific template, an order template is a good example.<BR><BR>
First, you would set the default topic (see the section on <a href="<% = lstrPGToolsOpts %>">Options</a>).<BR><BR>
Then use the either the 'Rapid Entry' toolbar button
<BR>This will allow you to quickly select the default template and start entering lots of topics.

<h1>How to use it</h1>
Once you have the 'Rapid Entry' screen(s) displayed, you must specify which field (or item) will be used to hold the topic (or branch) name.<BR>
<BR>
Use the 'Branch / Topic name field' drop down  to select, which field will be used.<BR><BR>
You can also specify default values for fields, for instance you may want to specify a default date.<BR>
To do this select the field using the 'Items / Fields' drop down and select the appropriate field for month.<BR>
Then in the 'Values' text box enter the month name.<BR>


<!-- #include file="_footer.htm" -->
