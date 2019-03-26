<% @ LANGUAGE="VBSCRIPT" %>
<% 	Response.Buffer = True
%>
<%
lstrTitle = "Create your own templates" %>
<!-- #include file="_header.htm" -->
<% ThisPage = lstrPGTempCreate %>
<h1>Template / HTML Forms</h1>
Templates are written in HTML, using FORMS to provide input boxes etc.
<BR><BR>

If you're familiar with writing HTML Forms, you should have no problem creating a template.
<BR>
If you're not, please gain some knowledge first!

<BR><BR>
If you haven't already got one, create a Directory / Folder in your Ideaspad program directory called "Layouts".
<BR>
You can now create your template files, and place them into this directory.<BR><BR>
<font color="#0000ff">Or download them from our web site, please <a href="<% = lstrPGtempShare %>">click here</a> for more information.</font><BR><BR>
The template file must have a .HTML file extension, e.g. Invoice.html.
<BR><BR>

<h1>Template file requirements</h1>

&nbsp;&nbsp;&nbsp;- No Submit or Reset button<BR>
&nbsp;&nbsp;&nbsp;- No value tag<BR>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;e.g.<BR>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

<font face="Courier New" size="2pt" color="#0000ff">&lt;</font><font face="Courier New" size="2pt" color="#800000">input</font><font face="Courier New" size="2pt" color="#ff00ff">
</font><font face="Courier New" size="2pt" color="#ff0000">
type</font><font face="Courier New" size="2pt" color="#0000ff">=&quot;text&quot;</font><font face="Courier New" size="2pt" color="#ff00ff">
</font><font face="Courier New" size="2pt" color="#ff0000">
name</font><font face="Courier New" size="2pt" color="#0000ff">=&quot;ContactBirthdayYear&quot;</font><font face="Courier New" size="2pt" color="#ff00ff">
</font><font face="Courier New" size="2pt" color="#ff0000">
size</font><font face="Courier New" size="2pt" color="#0000ff">=&quot;5&quot;&gt;</font>

<BR><BR>

&nbsp;&nbsp;&nbsp;- You must have hidden tag called TemplateID<BR>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;e.g.<BR>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

<font face="Courier New" size="2pt" color="#0000ff">&lt;</font><font face="Courier New" size="2pt" color="#800000">input</font><font face="Courier New" size="2pt" color="#ff00ff">
</font><font face="Courier New" size="2pt" color="#ff0000">
type</font><font face="Courier New" size="2pt" color="#0000ff">=&quot;hidden&quot;</font><font face="Courier New" size="2pt" color="#ff00ff">
</font><font face="Courier New" size="2pt" color="#ff0000">
name</font><font face="Courier New" size="2pt" color="#0000ff">=&quot;TemplateID&quot;</font><font face="Courier New" size="2pt" color="#ff00ff">
</font><font face="Courier New" size="2pt" color="#ff0000">
value</font><font face="Courier New" size="2pt" color="#0000ff">=&quot;MyTemplate&quot;&gt;</font>



<br><br>

<font color="#0000ff">
Standard templates are different to the templates you create yourself, as they do not require a TemplateID, however feel free to use the 'View Source' feature on the Templates menu.
</font>
<BR><BR>

<h1>Example of a template</h1>



Other features in the program rely on the Name you give each form element e.g. ContactAddress1.<BR>
Therefore please be descriptive.
<BR><BR>
<Center>
<Table border="0" bgcolor="White"><tr><td>

<font face="Courier New" size="2pt" color="#0000ff">&lt;</font><font face="Courier New" size="2pt" color="#800000">HTML</font><font face="Courier New" size="2pt" color="#0000ff">&gt;</font>
<br>
<font face="Courier New" size="2pt" color="#0000ff">&lt;</font><font face="Courier New" size="2pt" color="#800000">form</font><font face="Courier New" size="2pt" color="#ff00ff"></font>
<font face="Courier New" size="2pt" color="#ff0000">name</font><font face="Courier New" size="2pt" color="#0000ff">=&quot;&quot;</font><font face="Courier New" size="2pt" color="#ff00ff"></font><font face="Courier New" size="2pt" color="#0000ff">&gt;</font>

<br>

<font face="Courier New" size="2pt" color="#0000ff">&lt;</font><font face="Courier New" size="2pt" color="#800000">input</font><font face="Courier New" size="2pt" color="#ff00ff">
</font><font face="Courier New" size="2pt" color="#ff0000">
type</font><font face="Courier New" size="2pt" color="#0000ff">=&quot;hidden&quot;</font><font face="Courier New" size="2pt" color="#ff00ff">
</font><font face="Courier New" size="2pt" color="#ff0000">
name</font><font face="Courier New" size="2pt" color="#0000ff">=&quot;TemplateID&quot;</font><font face="Courier New" size="2pt" color="#ff00ff">
</font><font face="Courier New" size="2pt" color="#ff0000">
value</font><font face="Courier New" size="2pt" color="#0000ff">=&quot;MyTemplate&quot;&gt;</font>
<br><br>
<font face="Courier New" size="2pt">
Contact name:</font><font face="Courier New" size="2pt" color="#0000ff">&lt;</font><font face="Courier New" size="2pt" color="#800000">BR</font><font face="Courier New" size="2pt" color="#0000ff">&gt;</font>
<br>
<font face="Courier New" size="2pt" color="#0000ff">&lt;</font><font face="Courier New" size="2pt" color="#800000">input</font><font face="Courier New" size="2pt" color="#ff00ff">
</font><font face="Courier New" size="2pt" color="#ff0000">type</font><font face="Courier New" size="2pt" color="#0000ff">=&quot;text&quot;</font><font face="Courier New" size="2pt" color="#ff00ff">
</font><font face="Courier New" size="2pt" color="#ff0000">
name</font><font face="Courier New" size="2pt" color="#0000ff">=&quot;ContactName&quot;</font><font face="Courier New" size="2pt" color="#ff00ff">
</font><font face="Courier New" size="2pt" color="#ff0000">
size</font><font face="Courier New" size="2pt" color="#0000ff">=&quot;30&quot;&gt;</font>
<font face="Courier New" size="2pt" color="#0000ff">&lt;</font><font face="Courier New" size="2pt" color="#800000">BR</font><font face="Courier New" size="2pt" color="#0000ff">&gt;</font>
<BR><BR>
<font face="Courier New" size="2pt">
Address:</font><br>
<font face="Courier New" size="2pt" color="#0000ff">&lt;</font><font face="Courier New" size="2pt" color="#800000">input</font><font face="Courier New" size="2pt" color="#ff00ff">
</font><font face="Courier New" size="2pt" color="#ff0000">
type</font><font face="Courier New" size="2pt" color="#0000ff">=&quot;text&quot;</font><font face="Courier New" size="2pt" color="#ff00ff">
</font><font face="Courier New" size="2pt" color="#ff0000">
name</font><font face="Courier New" size="2pt" color="#0000ff">=&quot;ContactAddress1&quot;
</font><font face="Courier New" size="2pt" color="#ff0000">
size</font><font face="Courier New" size="2pt" color="#0000ff">=&quot;30&quot;&gt;</font>
<font face="Courier New" size="2pt" color="#0000ff">&lt;</font><font face="Courier New" size="2pt" color="#800000">BR</font><font face="Courier New" size="2pt" color="#0000ff">&gt;</font>
<br>
<font face="Courier New" size="2pt" color="#0000ff">&lt;</font><font face="Courier New" size="2pt" color="#800000">input</font><font face="Courier New" size="2pt" color="#ff00ff">
</font><font face="Courier New" size="2pt" color="#ff0000">
type</font><font face="Courier New" size="2pt" color="#0000ff">=&quot;text&quot;</font><font face="Courier New" size="2pt" color="#ff00ff">
</font><font face="Courier New" size="2pt" color="#ff0000">
name</font><font face="Courier New" size="2pt" color="#0000ff">=&quot;ContactAddress2&quot;
</font><font face="Courier New" size="2pt" color="#ff0000">
size</font><font face="Courier New" size="2pt" color="#0000ff">=&quot;30&quot;&gt;</font>
<font face="Courier New" size="2pt" color="#0000ff">&lt;</font><font face="Courier New" size="2pt" color="#800000">BR</font><font face="Courier New" size="2pt" color="#0000ff">&gt;</font>
<br>
<font face="Courier New" size="2pt" color="#0000ff">&lt;</font><font face="Courier New" size="2pt" color="#800000">input</font><font face="Courier New" size="2pt" color="#ff00ff">
</font><font face="Courier New" size="2pt" color="#ff0000">
type</font><font face="Courier New" size="2pt" color="#0000ff">=&quot;text&quot;</font><font face="Courier New" size="2pt" color="#ff00ff">
</font><font face="Courier New" size="2pt" color="#ff0000">
name</font><font face="Courier New" size="2pt" color="#0000ff">=&quot;ContactAddress3&quot;
</font><font face="Courier New" size="2pt" color="#ff0000">
size</font><font face="Courier New" size="2pt" color="#0000ff">=&quot;30&quot;&gt;</font>
<font face="Courier New" size="2pt" color="#0000ff">&lt;</font><font face="Courier New" size="2pt" color="#800000">BR</font><font face="Courier New" size="2pt" color="#0000ff">&gt;</font>
<br>
<font face="Courier New" size="2pt" color="#0000ff">&lt;</font><font face="Courier New" size="2pt" color="#800000">input</font><font face="Courier New" size="2pt" color="#ff00ff">
</font><font face="Courier New" size="2pt" color="#ff0000">
type</font><font face="Courier New" size="2pt" color="#0000ff">=&quot;text&quot;</font><font face="Courier New" size="2pt" color="#ff00ff">
</font><font face="Courier New" size="2pt" color="#ff0000">
name</font><font face="Courier New" size="2pt" color="#0000ff">=&quot;ContactAddress4&quot;
</font><font face="Courier New" size="2pt" color="#ff0000">
size</font><font face="Courier New" size="2pt" color="#0000ff">=&quot;30&quot;&gt;</font>
<font face="Courier New" size="2pt" color="#0000ff">&lt;</font><font face="Courier New" size="2pt" color="#800000">BR</font><font face="Courier New" size="2pt" color="#0000ff">&gt;</font>
<br>
<font face="Courier New" size="2pt" color="#0000ff">&lt;</font><font face="Courier New" size="2pt" color="#800000">input</font><font face="Courier New" size="2pt" color="#ff00ff">
</font><font face="Courier New" size="2pt" color="#ff0000">
type</font><font face="Courier New" size="2pt" color="#0000ff">=&quot;text&quot;</font><font face="Courier New" size="2pt" color="#ff00ff">
</font><font face="Courier New" size="2pt" color="#ff0000">
name</font><font face="Courier New" size="2pt" color="#0000ff">=&quot;ContactAddress5&quot;
</font><font face="Courier New" size="2pt" color="#ff0000">
size</font><font face="Courier New" size="2pt" color="#0000ff">=&quot;30&quot;&gt;</font>
<font face="Courier New" size="2pt" color="#0000ff">&lt;</font><font face="Courier New" size="2pt" color="#800000">BR</font><font face="Courier New" size="2pt" color="#0000ff">&gt;</font>
<BR><BR>
<font face="Courier New" size="2pt">
Postcode / Zipcode:</font><font face="Courier New" size="2pt" color="#0000ff">&lt;</font><font face="Courier New" size="2pt" color="#800000">BR</font><font face="Courier New" size="2pt" color="#0000ff">&gt;</font>
<br>
<font face="Courier New" size="2pt" color="#0000ff">&lt;</font><font face="Courier New" size="2pt" color="#800000">input</font><font face="Courier New" size="2pt" color="#ff00ff">
</font><font face="Courier New" size="2pt" color="#ff0000">
type</font><font face="Courier New" size="2pt" color="#0000ff">=&quot;text&quot;</font><font face="Courier New" size="2pt" color="#ff00ff">
</font><font face="Courier New" size="2pt" color="#ff0000">
name</font><font face="Courier New" size="2pt" color="#0000ff">=&quot;ContactPostCode&quot;&gt;</font>
<font face="Courier New" size="2pt" color="#0000ff">&lt;</font><font face="Courier New" size="2pt" color="#800000">BR</font><font face="Courier New" size="2pt" color="#0000ff">&gt;</font>
<BR><BR>
<font face="Courier New" size="2pt">
Daytime phone number:</font><font face="Courier New" size="2pt" color="#0000ff">&lt;</font><font face="Courier New" size="2pt" color="#800000">BR</font><font face="Courier New" size="2pt" color="#0000ff">&gt;</font>
<br>
<font face="Courier New" size="2pt" color="#0000ff">&lt;</font><font face="Courier New" size="2pt" color="#800000">input</font><font face="Courier New" size="2pt" color="#ff00ff">
</font><font face="Courier New" size="2pt" color="#ff0000">
type</font><font face="Courier New" size="2pt" color="#0000ff">=&quot;text&quot;</font><font face="Courier New" size="2pt" color="#ff00ff">
</font><font face="Courier New" size="2pt" color="#ff0000">
name</font><font face="Courier New" size="2pt" color="#0000ff">=&quot;ContactDayTelephone&quot;</font><font face="Courier New" size="2pt" color="#ff00ff">
</font><font face="Courier New" size="2pt" color="#ff0000">
size</font><font face="Courier New" size="2pt" color="#0000ff">=&quot;20&quot;&gt;</font>
<font face="Courier New" size="2pt" color="#0000ff">&lt;</font><font face="Courier New" size="2pt" color="#800000">BR</font><font face="Courier New" size="2pt" color="#0000ff">&gt;</font>
<BR><BR>
<font face="Courier New" size="2pt">
Evening phone number:</font><font face="Courier New" size="2pt" color="#0000ff">&lt;</font><font face="Courier New" size="2pt" color="#800000">BR</font><font face="Courier New" size="2pt" color="#0000ff">&gt;</font>
<br>
<font face="Courier New" size="2pt" color="#0000ff">&lt;</font><font face="Courier New" size="2pt" color="#800000">input</font><font face="Courier New" size="2pt" color="#ff00ff">
</font><font face="Courier New" size="2pt" color="#ff0000">
type</font><font face="Courier New" size="2pt" color="#0000ff">=&quot;text&quot;</font><font face="Courier New" size="2pt" color="#ff00ff">
</font><font face="Courier New" size="2pt" color="#ff0000">
name</font><font face="Courier New" size="2pt" color="#0000ff">=&quot;ContactEveTelephone&quot;</font><font face="Courier New" size="2pt" color="#ff00ff">
</font><font face="Courier New" size="2pt" color="#ff0000">
size</font><font face="Courier New" size="2pt" color="#0000ff">=&quot;20&quot;&gt;</font>
<font face="Courier New" size="2pt" color="#0000ff">&lt;</font><font face="Courier New" size="2pt" color="#800000">BR</font><font face="Courier New" size="2pt" color="#0000ff">&gt;</font>
<BR><BR>
<font face="Courier New" size="2pt">
Birthday:</font><font face="Courier New" size="2pt" color="#0000ff">&lt;</font><font face="Courier New" size="2pt" color="#800000">BR</font><font face="Courier New" size="2pt" color="#0000ff">&gt;</font>
<br>
<font face="Courier New" size="2pt">
Year:</font><font face="Courier New" size="2pt" color="#0000ff">&lt;</font><font face="Courier New" size="2pt" color="#800000">input</font><font face="Courier New" size="2pt" color="#ff00ff">
</font><font face="Courier New" size="2pt" color="#ff0000">
type</font><font face="Courier New" size="2pt" color="#0000ff">=&quot;text&quot;</font><font face="Courier New" size="2pt" color="#ff00ff">
</font><font face="Courier New" size="2pt" color="#ff0000">
name</font><font face="Courier New" size="2pt" color="#0000ff">=&quot;ContactBirthdayYear&quot;</font><font face="Courier New" size="2pt" color="#ff00ff">
</font><font face="Courier New" size="2pt" color="#ff0000">
size</font><font face="Courier New" size="2pt" color="#0000ff">=&quot;5&quot;&gt;&lt;</font><font face="Courier New" size="2pt" color="#800000">BR</font><font face="Courier New" size="2pt" color="#0000ff">&gt;</font>
<BR><BR>
<font face="Courier New" size="2pt">
Month:</font><br>
<font face="Courier New" size="2pt" color="#0000ff">&lt;</font><font face="Courier New" size="2pt" color="#800000">select</font><font face="Courier New" size="2pt" color="#ff00ff">
</font><font face="Courier New" size="2pt" color="#ff0000">
size</font><font face="Courier New" size="2pt" color="#0000ff">=&quot;1&quot;</font><font face="Courier New" size="2pt" color="#ff00ff">
</font><font face="Courier New" size="2pt" color="#ff0000">
name</font><font face="Courier New" size="2pt" color="#0000ff">=&quot;ContactBirthdayMonth&quot;&gt;</font>
<br>
<font face="Courier New" size="2pt" color="#0000ff">&lt;</font><font face="Courier New" size="2pt" color="#800000">option</font><font face="Courier New" size="2pt" color="#0000ff">&gt;</font>
<font face="Courier New" size="2pt">
January</font><font face="Courier New" size="2pt" color="#0000ff">&lt;/</font><font face="Courier New" size="2pt" color="#800000">option</font><font face="Courier New" size="2pt" color="#0000ff">&gt;&lt;</font><font face="Courier New" size="2pt" color="#800000">option</font><font face="Courier New" size="2pt" color="#0000ff">&gt;</font>
<font face="Courier New" size="2pt">
February</font><font face="Courier New" size="2pt" color="#0000ff">&lt;/</font><font face="Courier New" size="2pt" color="#800000">option</font><font face="Courier New" size="2pt" color="#0000ff">&gt;
<BR>

&lt;</font><font face="Courier New" size="2pt" color="#800000">option</font><font face="Courier New" size="2pt" color="#0000ff">&gt;</font>
<font face="Courier New" size="2pt">
March</font><font face="Courier New" size="2pt" color="#0000ff">&lt;/</font><font face="Courier New" size="2pt" color="#800000">option</font><font face="Courier New" size="2pt" color="#0000ff">&gt;</font>
<br>
<font face="Courier New" size="2pt" color="#0000ff">&lt;/</font><font face="Courier New" size="2pt" color="#800000">select</font><font face="Courier New" size="2pt" color="#0000ff">&gt;&lt;</font><font face="Courier New" size="2pt" color="#800000">BR</font><font face="Courier New" size="2pt" color="#0000ff">&gt;</font>
<BR><BR>
<font face="Courier New" size="2pt">
Day:</font><br>
<font face="Courier New" size="2pt" color="#0000ff">&lt;</font><font face="Courier New" size="2pt" color="#800000">select</font><font face="Courier New" size="2pt" color="#ff00ff">
</font><font face="Courier New" size="2pt" color="#ff0000">
size</font><font face="Courier New" size="2pt" color="#0000ff">=&quot;1&quot;</font><font face="Courier New" size="2pt" color="#ff00ff">
</font><font face="Courier New" size="2pt" color="#ff0000">
name</font><font face="Courier New" size="2pt" color="#0000ff">=&quot;ContactBirthdayDay&quot;&gt;</font>
<br>
<font face="Courier New" size="2pt" color="#0000ff">&lt;</font><font face="Courier New" size="2pt" color="#800000">option</font><font face="Courier New" size="2pt" color="#0000ff">&gt;</font>
<font face="Courier New" size="2pt">01</font><font face="Courier New" size="2pt" color="#0000ff">&lt;/</font><font face="Courier New" size="2pt" color="#800000">option</font><font face="Courier New" size="2pt" color="#0000ff">&gt;&lt;</font><font face="Courier New" size="2pt" color="#800000">option</font><font face="Courier New" size="2pt" color="#0000ff">&gt;</font>
<font face="Courier New" size="2pt">
02</font><font face="Courier New" size="2pt" color="#0000ff">&lt;/</font><font face="Courier New" size="2pt" color="#800000">option</font><font face="Courier New" size="2pt" color="#0000ff">&gt;
<BR>

&lt;</font><font face="Courier New" size="2pt" color="#800000">option</font><font face="Courier New" size="2pt" color="#0000ff">&gt;</font>
<font face="Courier New" size="2pt">
03</font><font face="Courier New" size="2pt" color="#0000ff">&lt;/</font><font face="Courier New" size="2pt" color="#800000">option</font><font face="Courier New" size="2pt" color="#0000ff">&gt;&lt;</font><font face="Courier New" size="2pt" color="#800000">option</font><font face="Courier New" size="2pt" color="#0000ff">&gt;</font>
<font face="Courier New" size="2pt">
04</font><font face="Courier New" size="2pt" color="#0000ff">&lt;/</font><font face="Courier New" size="2pt" color="#800000">option</font><font face="Courier New" size="2pt" color="#0000ff">&gt;</font>
<font face="Courier New" size="2pt" color="#0000ff">&lt;</font><font face="Courier New" size="2pt" color="#800000">BR</font><font face="Courier New" size="2pt" color="#0000ff">&gt;</font>
<br>
<font face="Courier New" size="2pt" color="#0000ff">&lt;/</font><font face="Courier New" size="2pt" color="#800000">select</font><font face="Courier New" size="2pt" color="#0000ff">&gt;</font>
<BR><BR>
<font face="Courier New" size="2pt">
Notes:</font><font face="Courier New" size="2pt" color="#0000ff">&lt;</font><font face="Courier New" size="2pt" color="#800000">BR</font><font face="Courier New" size="2pt" color="#0000ff">&gt;</font>
<br>
<font face="Courier New" size="2pt" color="#0000ff">&lt;</font><font face="Courier New" size="2pt" color="#800000">textarea</font><font face="Courier New" size="2pt" color="#ff00ff">
</font><font face="Courier New" size="2pt" color="#ff0000">
name</font><font face="Courier New" size="2pt" color="#0000ff">=&quot;ContactNotes&quot;</font><font face="Courier New" size="2pt" color="#ff00ff">
</font><font face="Courier New" size="2pt" color="#ff0000">
cols</font><font face="Courier New" size="2pt" color="#0000ff">=&quot;60&quot;</font><font face="Courier New" size="2pt" color="#ff00ff">
</font><font face="Courier New" size="2pt" color="#ff0000">
rows</font><font face="Courier New" size="2pt" color="#0000ff">=&quot;3&quot;&gt;&lt;/</font><font face="Courier New" size="2pt" color="#800000">textarea</font><font face="Courier New" size="2pt" color="#0000ff">&gt;</font>
<br>
<font face="Courier New" size="2pt" color="#0000ff">&lt;/</font><font face="Courier New" size="2pt" color="#800000">HTML</font><font face="Courier New" size="2pt" color="#0000ff">&gt;</font>

</td></tr></table></center>

<BR>
To try this example, copy the HTML code from the white box above into your text editor (e.g. Notepad) then save the file into your Ideaspad\Layouts Directory (see above for more information) and give the file the name of Contact.html<BR><BR>
<B>
Then in the Ideaspad program, go to the Template menu and choose 'Select Template' and within that screen choose your Contact.html file from the right hand side.</B>

<BR><BR><font color="#0000ff">For more information about selecting templates <a href="<% = lstrPGTemplatesProvided %>">click here</a>.</font>


<!-- #include file="_footer.htm" -->
