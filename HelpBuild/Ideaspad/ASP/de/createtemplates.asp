<% @ LANGUAGE="VBSCRIPT" %>
<% 	Response.Buffer = True
%>
<%
lstrTitle = "Erzeugen Sie Ihre eigenen Vorlagen" %>
<!-- #include file="_header.htm" -->
<% ThisPage = lstrPGTempCreate %>

<h1>Vorlagen / HTML Formulare</h1>
Alle Vorlagen für Ideaspad werden in HTML erstellt.
<BR><BR>

Wenn Sie bereits Erfahrung in der Erstellung von HTML Formularen besitzen, dann sollten Sie
keine Probleme haben Ihre eigenen Vorlagen zu erstellen.
<BR>
Wenn Sie sich nicht sicher sind, dann lesen Sie bitte weiter.

<BR><BR>
Wenn Sie noch kein eigenes Verzeichnis für Ihre Ideaspad Vorlagen besitzen,
dann erzeugen Sie sich bitte ein neues Verzeichnis "Layouts" im Ideapsad Programmverzeichnis.

<BR>
Sie können jetzt Ihre eigenen Vorlagen erzeugen und Sie in diesem Verzeichnis abspeichern.
<BR><BR>
<font color="#0000ff">Oder Sie laden bereits fertige Vorlagen von der Webseite <a href="<% = lstrPGtempShare %>">herunter</a> .</font><BR><BR>
Die Vorlagendatei muss die Endung .HTML besitzen. z.B. Rechnung.html
<BR><BR>

<h1>Einschränkungen</h1>

&nbsp;&nbsp;&nbsp;- Keine Submit oder Reset Schaltflächen<BR>
&nbsp;&nbsp;&nbsp;- Kein "Value Tag"<BR>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Beispiel<BR>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

<font face="Courier New" size="2pt" color="#0000ff">&lt;</font><font face="Courier New" size="2pt" color="#800000">input</font><font face="Courier New" size="2pt" color="#ff00ff">
</font><font face="Courier New" size="2pt" color="#ff0000">
type</font><font face="Courier New" size="2pt" color="#0000ff">=&quot;text&quot;</font><font face="Courier New" size="2pt" color="#ff00ff">
</font><font face="Courier New" size="2pt" color="#ff0000">
name</font><font face="Courier New" size="2pt" color="#0000ff">=&quot;KontaktGeburtsjahr&quot;</font><font face="Courier New" size="2pt" color="#ff00ff">
</font><font face="Courier New" size="2pt" color="#ff0000">
size</font><font face="Courier New" size="2pt" color="#0000ff">=&quot;5&quot;&gt;</font>

<BR><BR>

&nbsp;&nbsp;&nbsp;- Sie müssen ein unsichtbares Feld mit dem Namen 'TemplateID' anlegen<BR>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Beispiel<BR>
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
Standardvorlagen unterscheiden sich zu Ihren eigenen Vorlagen darin, dass Standardvorlagen keine 'TemplateId' benötigen.
</font>
<BR><BR>

<h1>Beispiel für eine Vorlage</h1>

Viele Funktionen in Ideaspad benötigen den Elementnamen z.B. Kontaktadresse1.<br>
Aus diesem Grund sollten Sie aussagekräftige Namen verwenden.
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
Name:</font><font face="Courier New" size="2pt" color="#0000ff">&lt;</font><font face="Courier New" size="2pt" color="#800000">BR</font><font face="Courier New" size="2pt" color="#0000ff">&gt;</font>
<br>
<font face="Courier New" size="2pt" color="#0000ff">&lt;</font><font face="Courier New" size="2pt" color="#800000">input</font><font face="Courier New" size="2pt" color="#ff00ff">
</font><font face="Courier New" size="2pt" color="#ff0000">type</font><font face="Courier New" size="2pt" color="#0000ff">=&quot;text&quot;</font><font face="Courier New" size="2pt" color="#ff00ff">
</font><font face="Courier New" size="2pt" color="#ff0000">
name</font><font face="Courier New" size="2pt" color="#0000ff">=&quot;KontaktName&quot;</font><font face="Courier New" size="2pt" color="#ff00ff">
</font><font face="Courier New" size="2pt" color="#ff0000">
size</font><font face="Courier New" size="2pt" color="#0000ff">=&quot;30&quot;&gt;</font>
<font face="Courier New" size="2pt" color="#0000ff">&lt;</font><font face="Courier New" size="2pt" color="#800000">BR</font><font face="Courier New" size="2pt" color="#0000ff">&gt;</font>
<BR><BR>
<font face="Courier New" size="2pt">
Adresse:</font><br>
<font face="Courier New" size="2pt" color="#0000ff">&lt;</font><font face="Courier New" size="2pt" color="#800000">input</font><font face="Courier New" size="2pt" color="#ff00ff">
</font><font face="Courier New" size="2pt" color="#ff0000">
type</font><font face="Courier New" size="2pt" color="#0000ff">=&quot;text&quot;</font><font face="Courier New" size="2pt" color="#ff00ff">
</font><font face="Courier New" size="2pt" color="#ff0000">
name</font><font face="Courier New" size="2pt" color="#0000ff">=&quot;KontaktAdresse1&quot;
</font><font face="Courier New" size="2pt" color="#ff0000">
size</font><font face="Courier New" size="2pt" color="#0000ff">=&quot;30&quot;&gt;</font>
<font face="Courier New" size="2pt" color="#0000ff">&lt;</font><font face="Courier New" size="2pt" color="#800000">BR</font><font face="Courier New" size="2pt" color="#0000ff">&gt;</font>
<br>
<font face="Courier New" size="2pt" color="#0000ff">&lt;</font><font face="Courier New" size="2pt" color="#800000">input</font><font face="Courier New" size="2pt" color="#ff00ff">
</font><font face="Courier New" size="2pt" color="#ff0000">
type</font><font face="Courier New" size="2pt" color="#0000ff">=&quot;text&quot;</font><font face="Courier New" size="2pt" color="#ff00ff">
</font><font face="Courier New" size="2pt" color="#ff0000">
name</font><font face="Courier New" size="2pt" color="#0000ff">=&quot;KontaktAdresse2&quot;
</font><font face="Courier New" size="2pt" color="#ff0000">
size</font><font face="Courier New" size="2pt" color="#0000ff">=&quot;30&quot;&gt;</font>
<font face="Courier New" size="2pt" color="#0000ff">&lt;</font><font face="Courier New" size="2pt" color="#800000">BR</font><font face="Courier New" size="2pt" color="#0000ff">&gt;</font>
<br>
<font face="Courier New" size="2pt" color="#0000ff">&lt;</font><font face="Courier New" size="2pt" color="#800000">input</font><font face="Courier New" size="2pt" color="#ff00ff">
</font><font face="Courier New" size="2pt" color="#ff0000">
type</font><font face="Courier New" size="2pt" color="#0000ff">=&quot;text&quot;</font><font face="Courier New" size="2pt" color="#ff00ff">
</font><font face="Courier New" size="2pt" color="#ff0000">
name</font><font face="Courier New" size="2pt" color="#0000ff">=&quot;KontaktAdresse3&quot;
</font><font face="Courier New" size="2pt" color="#ff0000">
size</font><font face="Courier New" size="2pt" color="#0000ff">=&quot;30&quot;&gt;</font>
<font face="Courier New" size="2pt" color="#0000ff">&lt;</font><font face="Courier New" size="2pt" color="#800000">BR</font><font face="Courier New" size="2pt" color="#0000ff">&gt;</font>
<br>
<font face="Courier New" size="2pt" color="#0000ff">&lt;</font><font face="Courier New" size="2pt" color="#800000">input</font><font face="Courier New" size="2pt" color="#ff00ff">
</font><font face="Courier New" size="2pt" color="#ff0000">
type</font><font face="Courier New" size="2pt" color="#0000ff">=&quot;text&quot;</font><font face="Courier New" size="2pt" color="#ff00ff">
</font><font face="Courier New" size="2pt" color="#ff0000">
name</font><font face="Courier New" size="2pt" color="#0000ff">=&quot;KontaktAdresse4&quot;
</font><font face="Courier New" size="2pt" color="#ff0000">
size</font><font face="Courier New" size="2pt" color="#0000ff">=&quot;30&quot;&gt;</font>
<font face="Courier New" size="2pt" color="#0000ff">&lt;</font><font face="Courier New" size="2pt" color="#800000">BR</font><font face="Courier New" size="2pt" color="#0000ff">&gt;</font>
<br>
<font face="Courier New" size="2pt" color="#0000ff">&lt;</font><font face="Courier New" size="2pt" color="#800000">input</font><font face="Courier New" size="2pt" color="#ff00ff">
</font><font face="Courier New" size="2pt" color="#ff0000">
type</font><font face="Courier New" size="2pt" color="#0000ff">=&quot;text&quot;</font><font face="Courier New" size="2pt" color="#ff00ff">
</font><font face="Courier New" size="2pt" color="#ff0000">
name</font><font face="Courier New" size="2pt" color="#0000ff">=&quot;KontaktAdresse5&quot;
</font><font face="Courier New" size="2pt" color="#ff0000">
size</font><font face="Courier New" size="2pt" color="#0000ff">=&quot;30&quot;&gt;</font>
<font face="Courier New" size="2pt" color="#0000ff">&lt;</font><font face="Courier New" size="2pt" color="#800000">BR</font><font face="Courier New" size="2pt" color="#0000ff">&gt;</font>
<BR><BR>
<font face="Courier New" size="2pt">
Postleitzahl:</font><font face="Courier New" size="2pt" color="#0000ff">&lt;</font><font face="Courier New" size="2pt" color="#800000">BR</font><font face="Courier New" size="2pt" color="#0000ff">&gt;</font>
<br>
<font face="Courier New" size="2pt" color="#0000ff">&lt;</font><font face="Courier New" size="2pt" color="#800000">input</font><font face="Courier New" size="2pt" color="#ff00ff">
</font><font face="Courier New" size="2pt" color="#ff0000">
type</font><font face="Courier New" size="2pt" color="#0000ff">=&quot;text&quot;</font><font face="Courier New" size="2pt" color="#ff00ff">
</font><font face="Courier New" size="2pt" color="#ff0000">
name</font><font face="Courier New" size="2pt" color="#0000ff">=&quot;KontaktPLZ&quot;&gt;</font>
<font face="Courier New" size="2pt" color="#0000ff">&lt;</font><font face="Courier New" size="2pt" color="#800000">BR</font><font face="Courier New" size="2pt" color="#0000ff">&gt;</font>
<BR><BR>
<font face="Courier New" size="2pt">
Telefonnummer geschäftlich:</font><font face="Courier New" size="2pt" color="#0000ff">&lt;</font><font face="Courier New" size="2pt" color="#800000">BR</font><font face="Courier New" size="2pt" color="#0000ff">&gt;</font>
<br>
<font face="Courier New" size="2pt" color="#0000ff">&lt;</font><font face="Courier New" size="2pt" color="#800000">input</font><font face="Courier New" size="2pt" color="#ff00ff">
</font><font face="Courier New" size="2pt" color="#ff0000">
type</font><font face="Courier New" size="2pt" color="#0000ff">=&quot;text&quot;</font><font face="Courier New" size="2pt" color="#ff00ff">
</font><font face="Courier New" size="2pt" color="#ff0000">
name</font><font face="Courier New" size="2pt" color="#0000ff">=&quot;KontaktTelefonTag&quot;</font><font face="Courier New" size="2pt" color="#ff00ff">
</font><font face="Courier New" size="2pt" color="#ff0000">
size</font><font face="Courier New" size="2pt" color="#0000ff">=&quot;20&quot;&gt;</font>
<font face="Courier New" size="2pt" color="#0000ff">&lt;</font><font face="Courier New" size="2pt" color="#800000">BR</font><font face="Courier New" size="2pt" color="#0000ff">&gt;</font>
<BR><BR>
<font face="Courier New" size="2pt">
Telefonnummer privat:</font><font face="Courier New" size="2pt" color="#0000ff">&lt;</font><font face="Courier New" size="2pt" color="#800000">BR</font><font face="Courier New" size="2pt" color="#0000ff">&gt;</font>
<br>
<font face="Courier New" size="2pt" color="#0000ff">&lt;</font><font face="Courier New" size="2pt" color="#800000">input</font><font face="Courier New" size="2pt" color="#ff00ff">
</font><font face="Courier New" size="2pt" color="#ff0000">
type</font><font face="Courier New" size="2pt" color="#0000ff">=&quot;text&quot;</font><font face="Courier New" size="2pt" color="#ff00ff">
</font><font face="Courier New" size="2pt" color="#ff0000">
name</font><font face="Courier New" size="2pt" color="#0000ff">=&quot;KontaktTelefonNacht&quot;</font><font face="Courier New" size="2pt" color="#ff00ff">
</font><font face="Courier New" size="2pt" color="#ff0000">
size</font><font face="Courier New" size="2pt" color="#0000ff">=&quot;20&quot;&gt;</font>
<font face="Courier New" size="2pt" color="#0000ff">&lt;</font><font face="Courier New" size="2pt" color="#800000">BR</font><font face="Courier New" size="2pt" color="#0000ff">&gt;</font>
<BR><BR>
<font face="Courier New" size="2pt">
Geburtstag:</font><font face="Courier New" size="2pt" color="#0000ff">&lt;</font><font face="Courier New" size="2pt" color="#800000">BR</font><font face="Courier New" size="2pt" color="#0000ff">&gt;</font>
<br>
<font face="Courier New" size="2pt">
Jahr:</font><font face="Courier New" size="2pt" color="#0000ff">&lt;</font><font face="Courier New" size="2pt" color="#800000">input</font><font face="Courier New" size="2pt" color="#ff00ff">
</font><font face="Courier New" size="2pt" color="#ff0000">
type</font><font face="Courier New" size="2pt" color="#0000ff">=&quot;text&quot;</font><font face="Courier New" size="2pt" color="#ff00ff">
</font><font face="Courier New" size="2pt" color="#ff0000">
name</font><font face="Courier New" size="2pt" color="#0000ff">=&quot;KontaktGeburtsJahr&quot;</font><font face="Courier New" size="2pt" color="#ff00ff">
</font><font face="Courier New" size="2pt" color="#ff0000">
size</font><font face="Courier New" size="2pt" color="#0000ff">=&quot;5&quot;&gt;&lt;</font><font face="Courier New" size="2pt" color="#800000">BR</font><font face="Courier New" size="2pt" color="#0000ff">&gt;</font>
<BR><BR>
<font face="Courier New" size="2pt">
Monat:</font><br>
<font face="Courier New" size="2pt" color="#0000ff">&lt;</font><font face="Courier New" size="2pt" color="#800000">select</font><font face="Courier New" size="2pt" color="#ff00ff">
</font><font face="Courier New" size="2pt" color="#ff0000">
size</font><font face="Courier New" size="2pt" color="#0000ff">=&quot;1&quot;</font><font face="Courier New" size="2pt" color="#ff00ff">
</font><font face="Courier New" size="2pt" color="#ff0000">
name</font><font face="Courier New" size="2pt" color="#0000ff">=&quot;KontaktGeburtsMonat&quot;&gt;</font>
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
Tag:</font><br>
<font face="Courier New" size="2pt" color="#0000ff">&lt;</font><font face="Courier New" size="2pt" color="#800000">select</font><font face="Courier New" size="2pt" color="#ff00ff">
</font><font face="Courier New" size="2pt" color="#ff0000">
size</font><font face="Courier New" size="2pt" color="#0000ff">=&quot;1&quot;</font><font face="Courier New" size="2pt" color="#ff00ff">
</font><font face="Courier New" size="2pt" color="#ff0000">
name</font><font face="Courier New" size="2pt" color="#0000ff">=&quot;KontaktGeburtsTag&quot;&gt;</font>
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
Notizen:</font><font face="Courier New" size="2pt" color="#0000ff">&lt;</font><font face="Courier New" size="2pt" color="#800000">BR</font><font face="Courier New" size="2pt" color="#0000ff">&gt;</font>
<br>
<font face="Courier New" size="2pt" color="#0000ff">&lt;</font><font face="Courier New" size="2pt" color="#800000">textarea</font><font face="Courier New" size="2pt" color="#ff00ff">
</font><font face="Courier New" size="2pt" color="#ff0000">
name</font><font face="Courier New" size="2pt" color="#0000ff">=&quot;Notizen&quot;</font><font face="Courier New" size="2pt" color="#ff00ff">
</font><font face="Courier New" size="2pt" color="#ff0000">
cols</font><font face="Courier New" size="2pt" color="#0000ff">=&quot;60&quot;</font><font face="Courier New" size="2pt" color="#ff00ff">
</font><font face="Courier New" size="2pt" color="#ff0000">
rows</font><font face="Courier New" size="2pt" color="#0000ff">=&quot;3&quot;&gt;&lt;/</font><font face="Courier New" size="2pt" color="#800000">textarea</font><font face="Courier New" size="2pt" color="#0000ff">&gt;</font>
<br>
<font face="Courier New" size="2pt" color="#0000ff">&lt;/</font><font face="Courier New" size="2pt" color="#800000">HTML</font><font face="Courier New" size="2pt" color="#0000ff">&gt;</font>

</td></tr></table></center>

<BR>
Um diese Beispielvorlage zu testen, kopieren Sie den HTML Quelltext in der weißen Box in einen beliebigen Texteditor (z.B. Notepad) und speichern die Datei unter dem Namen 'Kontakt.html' in Ihrem Ideaspad\Layouts Verzeichnis.<br><br>
<b>
Starten Sie jetzt Ideaspad, gehen Sie in den Dialog Vorlagenselektion. In der rechten Dialoghälfte wählen Sie jetzt 'Kontakt.html' aus.
</b>
<BR><BR><font color="#0000ff">Nähere Informationen über die Auswahl von Vorlagen erhalten Sie <a href="<% = lstrPGTemplatesProvided %>">hier</a>.</font>


<!-- #include file="_footer.htm" -->
