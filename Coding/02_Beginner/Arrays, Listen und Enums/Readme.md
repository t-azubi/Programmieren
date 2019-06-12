# Arrays, Listen und Enums wasn der Unterschied?

So da du schon weißt was Variablen sind, ist es vielleicht ganz nützlich mal über Listen oder Arrays zu reden.
Enums sind zwar ähnlich, aber eigentlich was ganz anderes aber das wirst schon noch rausfinden.

## Arrays

Arrays

Arrays sind eine Ansammlung von Werten des gleichen Datentyps. Dabei werden die Werte innerhalb einer Variablen gespeichert. Man könnte sagen, dass ein Array eine Liste ist. Wir werden jedoch später ein Objekt namens List kennenlernen, mit welchem wir ein „besseres“ Array erzeugen können. Wichtig zu wissen ist, dass ein Array nicht vergrößert werden kann. Ein Array hat immer die Anzahl x an Werten, weshalb es auch als statisches Array bezeichnet wird.

Bei den zumeist eingesetzten Arrays handelt es sich um sogenannte eindimensionale Arrays, d. h. sie besitzen nur eine Dimension (eine Spalte mit mehreren Zeilen). Um ein Array zu deklarieren, müssen wir bei der Variablendeklaration hinter dem Datentyp die eckigen Klammern ([]) notieren. Bei der Variableninitialisierung benötigen wir nun das Schlüsselwort new, welches vor dem Datentyp notiert wird. Die genaue Bedeutung von new werden wir im Thema Objektorientierung genauer kennenlernen. In den Klammern notieren wir nun die Anzahl der Elemente. Um auf die einzelnen Elemente zugreifen zu können, benötigen wir die Indexierung. Hierbei wird der Variablenname mit den eckigen Klammern notiert, in welcher der Index angeben wird. Der Index ist also ein Zähler. Die Zählweise beginnt bei 0 und entspricht dem 1. Element. Über die Eigenschaft Length können wir die Anzahl der Elemente abrufen.

Um ein Array zu verändern oder darin etwas zu suchen, gibt es die Klasse Array. Mit der Funktion Sort() können wir ein Array sortieren. Dabei wird es mit Hilfe des sogenannten Standard-Vergleichs aufsteigend sortiert (numerisch bei Zahlen, alphabetisch bei Zeichenketten). Die Funktion Reverse() kehrt die Reihenfolge aller Array-Elemente um. Mit der Funktion IndexOf() und LastIndexOf() können wir das erste bzw. letzte Vorkommen einer Zahl, eines Zeichens oder einer Zeichenkette im Array suchen. Die Funktionen geben den Index zurück und sind somit ebenfalls null-basierend.

Ein zweidimensionales Array hat x Spalten und y Zeilen. Diese Angabe wird bei der Variableninitialisierung in den eckigen Klammern angegeben. Dabei werden die Werte durch ein Komma getrennt. Bei Variablendeklaration muss innerhalb der eckigen Klammern ebenfalls das Komma notiert werden. Die Anzahl darf jedoch, wie beim eindimensionalen Array auch, nicht angegeben werden. Bei der Indexierung muss nun ebenfalls die Spalte und Zeile angegeben werden (durch Komma getrennt). Das zweidimensionale Array erinnert also an eine Tabelle. Über die Funktion GetLength() können wir die Anzahl der Elemente der gewünschten Ebene abrufen. Dazu müssen wir als Parameter den Index der Ebene übergeben: 0 = 1. Ebene = Spalte, 1 = 2. Ebene = Zeile.

Natürlich ist es auch möglich, Arrays mit mehr als 2 Dimensionen zu erstellen. Grundsätzlich spricht man von mehrdimensionalen Arrays. Es müssen dementsprechend weitere Kommas und Zahlen bei der Deklaration, Initialisierung und Indexierung angegeben werden. Meistens werden Arrays mit mehr als 3 Dimensionen nicht eingesetzt, da diese sehr unübersichtlich sind.

In C# gibt es noch einen weiteren Array-Typ: verzweigte Arrays. Ein verzweigtes Array ähnelt einem zweidimensionalen Array. Jedoch gibt es einen entscheidenden Unterschied: Die Anzahl der Elemente der 2. Ebene müssen nicht gleich groß sein. Dies kommt daher, dass ein verzweigtes Array nicht mehrere Dimensionen hat, sondern verschaltet ist, d. h. das Array besteht z. B. aus 10 untergeordneten Arrays. Die Anzahl der Elemente dieser 10 ungeordneten Arrays interessiert das ursprüngliche Array daher nicht. Bei der Deklaration werden 2 eckige Klammern-Paare nacheinander notiert. Bei der Initialisierung wird in den eckigen Klammern der 2. Ebene keine Anzahl festgelegt. Dies ist notwendig, da wir bei der Wertezuweisung (im Beispiel durch die Schleifen) den Arrays der 2. Ebene unterschiedliche Größen zuweisen. Bei der Indexierung müssen wir ebenfalls die 2 Klammern-Paare nacheinander notieren.

## List die besseren Arrays ?

Listen sind eine bessere Form von Arrays. Der Vorteil von Listen besteht hauptsächlich darin, dass diese nach Belieben vergrößert werden und einzelne Elemente auch wieder gelöscht werden können, ohne das Array komplett neu zu erstellen. In C# gibt es die ArrayList und die List. ArrayList ist an keinen bestimmten Typ gebunden, d. h. hier können sowohl int-Werte als auch string-Werte im selben Array gespeichert werden. Neben einigen Problemen bei der Verarbeitung dieser Werte ist die ArrayList des Weiteren ein schlechter Programmierstil, weshalb wir uns nur mit der List genauer auseinandersetzen werden.

Die List ist an einen generischen Typ gebunden, d. h. hier können nur Werte desselben Datentyps gespeichert werden. Der Datentyp der hier verwendet wird, ist jedoch unabhängig und muss lediglich bei der Deklaration angegeben werden, d. h. wir können eine solche Liste auch mit selbst deklarierten Objekten erstellen. Der Programmcode der sich hinter der List-Klasse befindet, existiert deshalb nur einmal, wodurch man von generischen Typen spricht. Wie Ihnen vielleicht schon aufgefallen ist, kann mit der Funktion Sort() der Klasse Array ebenfalls ein statisches Array jedes Datentyps sortiert werden. Dies liegt daran, dass die Sort()-Funktion als Parameter ein Array eines generischen Typs (und somit unabhängig vom Datentyp) erwartet.

```csharp
List<string> stringList = new List<string>(); 
```

Eine Liste ist ein Klasse, weshalb wir das Schlüsselwort new benötigen, um ein Objekt davon zu erstellen. Der generische Typ wird in spitzen Klammern direkt hinter dem Klassennamen notiert. Mit der Funktion Add() können wir der Liste ein neues Element hinzufügen. Das Element wird dabei am Ende der Liste angehängt. Mit Insert() können wir ein Element am gewünschten Index einfügen. Die dahinter folgenden Elemente werden dabei um einen Index weiter verschoben. Die Funktion Remove() entfernt das gewünschte Element. Falls das Element mehrmals in der Liste vorhanden ist, wird lediglich das erste gefundene Element entfernt. Die Funktionen IndexOf() und LastIndexOf() dienen zur Suche nach einem Element, bei dem der dazugehörige Index zurückgegeben wird. Bleibt die Suche erfolglos, wird -1 zurückgegeben. Auch für die Sortierung gibt es eine Funktion: Mit Sort() erfolgt eine Sortierung an Hand des Standardvergleichs, d. h. bei einzelnen Zeichen bzw. Zeichenketten alphabetisch und bei Zahlen numerisch.

## Enumeratioen

Enumerationen (auch Enumerationstypen) sind ein spezieller Datentyp, mit welchem es möglich ist, einem konstanten Text einen numerischen Wert zuzuweisen. Dies soll vor allem dem Programmierer eine Hilfestellung sein. Des Weiteren macht es einen Programmcode übersichtlicher.

Ein Beispiel dazu: Wir benötigen in unserem Programm die Wochentage. Diesen Wochentagen liegen intern die Werte 0 für Sonntag, 1 für Montag, … und 6 für Samstag zu Grunde. Wenn wir nun intern z. B. den Wert 4 haben, müssen wir als Programmierer erst überlegen, um welchen Tag es sich handelt. Wollen wir eine Abfrage machen, ob der Wert dem Freitag entspricht, müssten wir also if (iTag == 5) notieren. Dies ist weder übersichtlich noch guter Programmierstil. In einem solchen Fall könnten wir eine Enumeration erstellen.

Um eine eigene Enumeration zu verwenden, müssen wir diese erst definieren. Dazu benötigen wir das Schlüsselwort enum gefolgt von dem Namen, welchen wir der Enumeration geben wollen. Vor dem Schlüsselwort kann des Weiteren ein Zugriffsmodifzierer angegeben werden. Wird dieser nicht angegeben, wird private als Sicherheitsstufe verwendet. Die Definition einer Enumeration bildet immer einen Block. Innerhalb des Blocks werden die einzelnen Werte (konstante Texte) angegeben und durch Komma getrennt. Den numerischen Wert müssen wir nicht zwangsläufig angeben. Werden keine Werte angegeben, entspricht der erste Wert der Zahl 0. Die weiteren Elemente werden durchgezählt. Über das Gleichheitszeichen lassen sich die Werte ändern. Wird ein Wert nicht angegeben, setzt die normale Zählung (vorheriger Wert + 1) wieder in Kraft.
Sobald eine Enumeration definiert wurde, können wir diese als Datentyp einer Variablen verwenden. Die Zuweisung einer Enumerations-Variable erfolgt durch den Namen der Enumeration und den konstanten Text eines einzelnen Elements (getrennt durch einen Punkt). Eine Enumeration besitzt standardmäßig einen Wertebereich des Datentyps int. Dieser kann über den Doppelpunkt gefolgt vom Datentyp hinter dem Namen der Enumerations-Definition geändert werden. Der gewählte Datentyp muss jedoch immer ein numerischer Wert sein.

Die statische "Klasse" Enum besitzt einige Hilfsfunktionen, um Konvertierungen durchzuführen. Wollen wir z. B. den Namen (konstanten Text) des dazugehörigen numerischen Wertes ermitteln, kann uns die Funktion GetName() behilflich sein. Als erster Parameter wird der Typ der Enumeration benötigt. Hierfür benötigen wir das Schlüsselwort typeof gefolgt von runden Klammern, in welcher der Datentyp der Ziel-Enumeration angegeben wird. Der zweite Parameter entspricht dem numerischen Wert. Über die Funktion IsDefined() können wir ermitteln, ob der angegebene Name (konstante Text) in der Enumeration vorhanden ist. Die Rückgabe der Funktion ist ein Wert des Datentyps bool. Über die Funktion Parse() können wir den Text in den dazugehörigen numerischen Wert umwandeln. Um ein Enumerations-Element in den zu Grund liegenden, numerischen Wert umzuwandeln, reicht es aus, eine explizite Typumwandlung (cast) durchzuführen.

```csharp
    private enum Wochentage : byte  
// mit ": byte", weisen wir der Enumeration einen Wertebereich von 0 - 255 zu
        {
            Sonntag,        // Sonntag ist automatisch 0
            Montag,
            Dienstag,
            Mittwoch,
            Donnerstag,
            Freitag,
            Samstag
        }
```
