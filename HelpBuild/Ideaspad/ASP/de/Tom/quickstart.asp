<% @ LANGUAGE="VBSCRIPT" %>
<% 	Response.Buffer = True
%>
<%ThisPage = lstrPGQuickStart
lstrTitle = "Schnellstart" %>
<!-- #include file="_header.htm" -->
<h1>1. Neuen Top-Level Eintrag erzeugen</h1>
Um einen neuen Top-Level Eintrag zu erzeugen, fahren Sie mit Ihrem Mauszeiger 
auf das Menü Datei und klicken Sie die linke Maustaste.
<br>
Dann wählen Sie den Menüeintrag "Erzeuge neuen Top-Level Eintrag' aus.
<br>
Sie werden nun aufgefordert einen Namen für den Eintrag einzugeben.
<h1>2. Neuen Knoten erzeugen</h1>
Um einen neuen Knoten zu erzeugen, fahren Sie mit Ihrem Mauszeiger auf einen 
bereits bestehenden Knoten (z.B. den Top-Level Eintrag aus Schritt 1).
<br>
Drücken Sie jetzt die rechte Maustaste und selektieren Sie den Menüeintrag 
'Neuen Knoten hinzufügen'.
<br>
Sie werden nun aufgefordert einen Namen für den Knoten einzugeben.
<h1>3. Umbenennen eines Knotens</h1>
Um einen Knoten umzubenennen, fahren Sie mit Ihrem Mauszeiger auf einen bereits 
bestehenden Knoten.
<br>
Drücken Sie jetzt die rechte Maustaste und selektieren Sie den Menüeintrag 
'Knoten umbenennen'.
<h1>4. Knoten löschen</h1>
Um einen Knoten zu löschen, fahren Sie mit Ihrem Mauszeiger auf einen bereits 
bestehenden Knoten.
<br>
Drücken Sie jetzt die rechte Maustaste und selektieren Sie den Menüeintrag 
'Knoten löschen'.
<h1>5. Verknüpfung zu einem Knoten erzeugen</h1>
Um doppelte Einträge zu vermeiden ist es manchmal nützlich einen Eintrag in 
mehreren Knoten anzeigen zu lassen - also zu verknüpfen.<BR>
Um einen Knoten zu verknüpfen, ziehen Sie den Knoten mit gedrückter Maustaste 
auf die gewünschte Zielposition im Baum. Lassen Sie dann die Maustaste wieder 
los.
<BR>
Es öffnet sich ein Kontextmenü in welchem Sie 'Erzeuge eine Verknüpfung zum 
Knoten' auswählen müssen.<br>
<br>
<h1>6. Ändern des Symbols eines Eintrags</h1>
Um das Symbol eines Knotens/Eintrags zu ändern, fahren Sie mit Ihrem Mauszeiger 
auf den Eintrag, bei welchem Sie das Anzeigesymbol ändern möchten.
<br>
Drücken Sie jetzt die rechte Maustaste und selektieren Sie den Menüeintrag 
'Eigenschaften'. Es öffnet sich ein Dialog, in welchem Sie die Registerkarte 
'Icons' auswählen müssen.
<br>
Sie können jetzt das gewünschte Symbol aus der Liste der angezeigten Symbole 
auswählen. Um das Symbol zu übernehmen, müssen Sie Ihre Wahl durch einen Klick 
auf die Schaltfläche "OK" bestätigen.
<BR>
<BR>
<font color="#0000ff">Nähere Informationen zu diesem Thema finden Sie <a href="<% = lstrPGBranchprops %>#Branch_icons">
		hier</a>. </font>
<br>
<h1>7. Ändern der Sortierreihenfolge</h1>
Als Vorgabewert werden die Knoten und Einträge immer alphabetisch im Baum 
sortiert. Sie können jedoch auch eine eigene Sortierreihenfolge für die 
Einträge definieren.
<br>
Selektieren Sie dazu den Menüeintrag 'Optionen' im Menü 'Werkzeuge'. Wählen Sie 
dann das Register 'Sortierreihenfolge' aus und selektieren Sie den Eintrag 
'Sortierung nach den Sequenznummern der Knoten'.
<br>
Die Sequenznummer eines Knotens können Sie selbst definieren, in dem Sie einen 
Knoten selektieren und mit der rechten Maustaste den Menüeintrag 
'Eigenschaften' wählen.
<br>
Eine höhere Sequenznummer verschiebt den Knoten weiter nach unten in der 
Anzeige.
<br>
Anmerkung: Es sind keine negativen Zahlen erlaubt.
<BR>
<BR>
<font color="#0000ff">Nähere Informationen zu diesem Thema finden Sie <a href="<% = lstrPGBranchprops %>">
		hier</a>. </font>
<h1>8. Drucken / Speichern im RTF Format</h1>
<P>
	Sie können den aktuellen Eintrag drucken, in dem Sie das Druckersymbol in der 
	Werkzeugleiste selektieren.
	<br>
	oder
	<br>
	Wählen Sie den Menüeintrag 'Selektives Drucken' im Dateimenü aus.
	<BR>
	oder<BR>
	Benutzen Sie die Möglichkeit Ihre Datem im RTF Format zu speichern, siehe 
	Menüeintrag 'Exportieren' im Dateimenü.&nbsp;
	<br>
	<font color="#0000ff">Selektives Drucken bedeutet die Auswahl verschiedener 
		Knoten mit anschliessendem Druck oder einem Export ins RTF Format. </font>
</P>
<h1>9. Vorlagen benutzen</h1>
Selektieren Sie im Menü 'Vorlagen' den Menüeintrag 'Vorlage auswählen'.<br>
Es wird ein Dialog zum Auswählen einer Vorlage angezeigt.
<br>
Links befinden sich die Standard Vorlagen.<br>
Selektieren Sie jetzt z.B. 'Adresseintrag' und bestätigen Sie dies durch einen 
Klick auf die Schaltfläche 'OK'.<br>
Im nächsten Dialog wählen Sie jetzt 'Einen neuen Top-Level Eintrag erstellen'. 
Bestätigen Sie auch diesen Dialog durch die Schaltfläche 'OK'.<br>
Sie werden jetzt aufgefordert einen Namen für den neuen Eintrag einzugeben.<br>
<br>
<font color="#0000ff">Nähere Informationen zu diesem Thema finden Sie <a href="<% = lstrPGTemplatesProvided %>">
		hier</a>. </font>
<!-- #include file="_footer.htm" -->
