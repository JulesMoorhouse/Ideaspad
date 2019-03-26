<% @ LANGUAGE="VBSCRIPT" %>
<% 	Response.Buffer = True
%>
<%
lstrTitle = "Standard Vorlagen" %>
<!-- #include file="_header.htm" -->
<% ThisPage = lstrPGTemplatesProvided %>

Öffnen Sie Menü 'Vorlagen' und wählen Sie 'Vorlage auswählen'.
<BR><BR>
&nbsp;&nbsp;&nbsp;<img src="gfx/template_selection.png" border="0" height="308" width="400">
<BR><br>

Links finden Sie alle Standardvorlagen.<bR>
Selektieren Sie davon eine und setzen Sie einen Haken in das Auswahlfeld, wenn Sie möchten, dass
die Vorlage im Vorlagenmenü angezeigt werden soll.<BR>
Bestätigen Sie Ihre Auswahl mit der Schaltfläche 'Auswählen'.

<br><br>
<font color="#0000ff">
Wenn Sie eine Vorlage zum Vorlagenmenü hinzugefügt haben, ist diese Vorlage gleichzeitig auch im Contextmenü eines Knotens erreichbar.
</font>
<br><br>
<a name="Template_options_create">
Sie werden jetzt gefragt was Sie mit der Vorlage tun möchten. &nbsp; Dazu haben Sie verschiedene Möglichkeiten.

<BR><BR>
&nbsp;&nbsp;&nbsp;<img src="gfx/template_topic_create.png" border="0" height="334" width="352">
<BR><BR>

Die ersten vier Optionen sind allgemein verständlich und einfach.<br><br>
Nähere Informationen über die 4. Auswahlmöglichkeit erhalten Sie im Abschnitt <a href="<% = lstrPGRapidEntry %>">'Schnelleinträge'</a>.<br><br>
Die 5. Auswahlmöglichkeit 'Mit den Daten einer bereits bestehenden Vorlage verschmelzen',
erlaubt Ihnen das Auswechseln einer Vorlage.
Dabei ist es wichtig, dass die Feldnamen der beiden Vorlagen übereinstimmen, damit
die Daten auch in der neuen Vorlage angezeigt werden können.

<BR><BR>
<font color="#0000ff">
Informationen zum Erzeugen eigener Vorlagen finden Sie <a href="<% = lstrPGTempCreate %>">hier</a>.<BR>
</font>


<!-- #include file="_footer.htm" -->
