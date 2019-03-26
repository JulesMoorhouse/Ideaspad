<% @ LANGUAGE="VBSCRIPT" %>
<% 	Response.Buffer = True
%>
<%
lstrTitle = "Schnelleinträge" %>
<!-- #include file="_header.htm" -->
<% ThisPage = lstrPGRapidEntry %>
Die Funktion Schnelleintrag erlaubt es Ihnen schnell und effizient Daten unter
Einbeziehung einer Vorlage einzutragen.<BR>
Haben Sie einmal einen Schnelleintrag ausgewählt, dann können Sie viele
Einträge im Baum von Ideaspad mit der gleichen Vorlage anlegen.
<BR>
Diese Funktion kann zum Beispiel dazu benutzt werden, um mehrere Adressen auf
einmal anzulegen.
<BR>
<BR>
<img src="gfx\rapidentry.png" width="504" height="433">
<BR>
<BR>
<h1>Wo können Sie Schnelleinträge nutzen?</h1>
<b>Menü 'Vorlagen', Menüeintrag 'Vorlage auswählen'</b><BR>
Lesen Sie dazu den auch den Abschnitt <a href="<% = lstrPGTemplatesProvided %>">Vorlagen
	Unterstützung</a>. Wählen Sie nach der Selektion im nächsten Dialog 'Einen
Schnelleintrag erstellen' aus.
<BR>
<BR>
<b>In der Werkzeugleiste das entsprechende Symbol, oder den Menüeintrag
	'Schnelleintrag' aus dem Menü 'Vorlagen' auswählen</b><BR>
Vielleicht haben Sie ein System indem Sie immer eine spezielle Vorlage nutzen,
eine Vorlage für eine Bestellung ist ein gutes Beispiel.<BR>
<BR>
Zuerst müssen Sie einen Knoten auswählen (Lesen Sie dazu den Abschnitt <a href="<% = lstrPGToolsOpts %>">
	Optionen</a>).<BR>
<BR>
Dann benutzen Sie entweder die Schaltfläche 'Schnelleintrag' aus der
Werkzeugleiste, oder den Menüeintrag 'Schnelleintrag' aus dem Menü 'Vorlagen'.<BR>
Diese Funktion erlaubt es Ihnen schnell die gewählte Standardvorlage zu öffnen
und Daten in das Formular einzutragen.
<h1>Wie Sie Schnelleinträge nutzen können</h1>
Nachdem der Dialog 'Schnelleintrag' angezeigt wird, müssen Sie ein Feld
definieren, das den aktuellen Namen des Knotens beinhaltet.<BR>
Benutzen Sie das Auswahlfeld 'Knotenname' um festzulegen, welches Feld den
Namen des zu erzeugenden Knotens spezifiziert.<BR>
<BR>
Natürlich können Sie auch Vorgabewerte für Felder definieren, zum Beispiel um
ein bestimmtes Datumsfeld vorzubelegen.<BR>
Um dies zu tun, selektieren Sie bitte das gewünschte Feld über die Auswahlbox
'Notiz / Feld'.
<BR>
Danach können Sie den Vorgabewert im Feld 'Wert' eintragen.<BR>
<br>
&nbsp;
<!-- #include file="_footer.htm" -->
