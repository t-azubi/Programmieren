# CSS

## Was ist CSS?

CSS steht für Cascading-Style-Sheets und ist eine Möglichkeit für HTML-Dokumente, den Inhalt einer Seite von den Designanweisungen der einzelnen Elemente, wie zum Beispiel Überschriften, Zitaten etc, zu entkoppeln.

Mann kann eine CSS-Datei für eine Domain erstellen und diese auf allen Unterseiten als externe Ressource einbinden. Dies kann viel Zeit sparen, wenn feste Vorgaben für meine Designelemente vorhanden sind, die sich zwischen Dokumenten nicht ändern.

Der kaskadierende Teil wird dann klar, wenn man sich mit verschiedenen Klassen beschäftigt. So kann man in der CSS-Datei zB festlegen, dass alle H2-Überschriften (Eltern-Element) in Schriftgröße 46 ausgespielt werden und dann eine Unterklasse der H2-Überschriften einfügen (Kind-Element) die den Text fett druckt, wenn eine bestimmte Klasse (zB. „fett“) definiert wird.

Im Dokument muss ich bei der Unterklasse nicht noch einmal die Anweisung zur Schriftgröße wiederholen, da diese von der übergeordneten Anweisung vererbt wird (überschwappt).

Mit dieser Anweisung bekommt jedes `<h2>`-Element die Schriftgröße 42 und nur Überschriften mit `<h2 class="fett">` werden auch Fett gedruckt.

## Warum gibt es Cascading-Style-Sheets?

Die Möglichkeit, das Design von dem Inhalt eines Dokuments zu entkoppeln bringt merkbare Geschwindigkeitsvorteile. Die einzelnen HTML-Dokumente werden kürzer, da die Design-Anweisungen ausgelagert sind.

Außerdem muss der Webseitenbetreiber nicht bei jedem Dokument darauf achten, dass alle notwendigen Design-Anweisungen vorhanden sind. Dies kann den Verwaltungsaufwand, besonders bei sehr vielen Dokumenten, immens verringern.

Zudem kann ich Browsern mitteilen, wie lange die CSS-Datei nutzbar ist (und sie gecached werden kann). Damit muss der Browser die Datei nicht jedes mal neu herunterladen, was der Ladezeit zugute kommt.

 Mehr über die Coolen sachen die man mit CSS machen kann findest du [hier](https://www.w3schools.com/css/css_intro.asp)