# Schleifen und Verzweigungen

## Schleifen

Eine Schleife verwenden wir, um Wiederholungen im Programm zu realisieren – also um Dinge mehrmals zu machen. Jede Schleife hat eine Durchlauf-Bedingung, damit sie nicht endlos läuft. D.h. vor einem  Durchlauf wird eine Bedingung geprüft. Ist die Bedingung erfüllt, werden die Befehle innerhalb der Schleife ausgeführt. Ist die Bedingung nicht (mehr) erfüllt, wird die Schleife verlassen.

 <details>
    <summary>Schleifen</summary><p>

## Kopfgesteuerte Schleifen

Bei einer kopfgesteuerten Schleife erfolgt die Abfrage der Bedingung, bevor der Schleifenrumpf ausgeführt wird, also am Kopf des Konstruktes. Eine logische Operation kann beispielsweise sein: (x > 4) Solange diese Bedingung wahr ist, werden die Anweisungen innerhalb der Schleife ausgeführt. Wird der Inhalt der logischen Operation nicht im Schleifenrumpf verändert, ist diese Kontrollstruktur meist nicht die richtige, weil diese Schleife sonst kein einziges Mal durchlaufen wird oder unendlich lang läuft. 
### Whileschleife

Eine Schleife dient dazu, ein Programm­stück mehrfach zu wiederholen. Das Programm­stück, der Schleifen­körper, wird solange wiederholt, wie eine bestimmte Bedingung, die Schleifen­bedingung, erfüllt ist.

Die While-Schleife hat die allgemeine Form
```
while (bedingung)
{
      anweisung1;
             drei Punkte übereinander 
      anweisungn;
}
```

Hier ist bedingung die Schleifen­bedingung. Es muss sich um einen Ausdruck handeln, der einen Wert vom Typ boolean, also true oder false ergibt. Die Schleifen­bedingung steht in runden Klammern hinter dem Wort while (engl.: while – solange).

Danach folgt in geschweiften Klammern der Schleifen­körper, also das Programm­stück, das wiederholt werden soll, hier dargestellt durch die Anweisungen anweisung1, ..., anweisungn. Jede Anweisung wird mit einem Semikolon abge­schlossen.

Bei Ausführung der While-Schleife wird zunächst geprüft, ob die Schleifen­bedingung erfüllt ist, d.h. ob sie den Wert true ergibt. Ist dies der Fall, so werden die Anweisungen des Schleifen­körpers ausgeführt. Wenn der Schleifen­körper fertig ausgeführt ist, springt das Programm wieder an den Anfang der While-Schleife und prüft erneut die Schleifen­bedingung. Ist diese immer noch erfüllt, wird der Schleifen­körper erneut ausgeführt usw. – solange, bis die Schleifen­bedingung irgendwann einmal nicht mehr erfüllt ist. Dann wird der Schleifen­körper nicht mehr ausgeführt, sondern es wird mit den hinter dem Schleifen­körper folgenden Anweisungen fortgefahren.

```
int a = 10;
int b = 1;
while (a > b)
{
Console.Writeline(b);
b++;
}
```

Diese While Schleife läuft laut der Bedingung solange wie a größe als b ist. Solange das der Fall ist, wird b in der Console ausgegeben und danach um 1 erhöht.

### Die for-schleife

Die for-schleife unterscheidet sich ein bisschen. Sie wird bevorzugt, wenn man weiß wieviele Iterationen man will, oder wenn man die genaue Menge der Iterationen weiß, oder wenn man eine Variable hat, die die Menge enthält. Hier ist ein Beispiel für diese Schleife.

```
        int number = 5;

        for(int i = 0; i < number; i++)
        {
        Console.WriteLine(i);
        }
```
  
Sie erzeugt exakt das selbe Ergebnis, nur das diese Schleife kompakter ist. Sie besteht aus 3 Teilen - wir initialisieren eine Zählervariable,setzten eine Bedingung die überprüft werden soll und inkrementieren den Zähler.

Der Teil an dem wir die Variable mit 0 definieren wird nur einmal beim starten der Schleife ausgeführt. die anderen 2 Teile werden bei jeder Iteration der Schleife ausgeführt. Jeden Schleifendurchlauf wird "i" mit unserer Variablen verglichen - wenn "i" kleiner als die Zahl ist, wiederholt sich die Schleife ein weiteres mal. Nach dem durchlauf wurde "i" um eins inkrementiert.

Führ dieses Programm aus, lass es anschließend nocheinmal laufen aber veränder dabei die Variable "number" größer oder kleiner als 5. Die Schleife wird auf den Wechsel reagieren.

## Mengenschleifen

Eine Mengenschleife führt den Schleifenrumpf für jedes Element einer Menge (z. B. Array oder Liste) aus.

Sie kann ersetzt werden durch eine Zählschleife mit dem Schleifenkörper.
Da die Reihenfolge der Abarbeitung bei der Mengenschleife beliebig ist,bleibt dem Compiler überlassen, wie er vorgeht. Aufgrund des sicher gegebenen Umstands, dass eine Iteration nicht von der „vorhergehenden“ abhängig sein kann, kann ein Compiler Mengenschleifen am einfachsten automatisch parallelisieren. 

### Die foreach-Schleife

Die letzte Schleife die wir uns ansehen ist die "foreach-schleife". Sie arbeitet mit Auflistungen von Elementen, zum Beispiel mit Arrays oder anderen Listentypen. In diesem Beispiel verwenden wir eine einfache Arrayliste. Sie arbeitet gleich wie ein Array, aber keine Sorge, wir werden uns das in einem späteren Kapitel genauer anschauen.

```
{        
        ArrayList list = new ArrayList();
        list.Add("John Doe");
        list.Add("Jane Doe");
        list.Add("Someone Else");
        
        foreach(string name in list)
        {
        Console.WriteLine(name);
        }
}        
```

Okay, hier haben wir eine Instanz einer Arrayliste erstellt und ein paar "string" Elemente hinzugefügt. Wir benötigen die foreach-schleife um jedes einzelne Element zu durchlaufen, dabei setzten wir die Variable des Namens in das Element das gerade erreicht wurde. Wie Sie sehen können deklarieren wir die Variable als String-Typ - Sie müssen der foreach-schleife immer mitteilen, welchen Datentyp Sie aus der Sammlung entnehmen möchten. Falls Sie eine Liste verschiedener Typen haben, können Sie die Objektklasse anstelle einer bestimmten Klasse verwenden, um jedes Element als Objekt herauszuziehen.
Bei der Arbeit mit Sammlungen, werden die foreach-schleifen gegenüber den anderen normalerweise bevorzugt, weil sie einfacher sind für diese Arbeitsabläufe als die anderen Schleifen.

## Fußgesteuerte Schleifen

Bei einer fußgesteuerten Schleife erfolgt die Abfrage der Bedingung, nachdem der Schleifenrumpf ausgeführt wurde, also am Fuß des Konstruktes. Wie für die kopfgesteuerte Schleife gilt: Wird der Inhalt der logischen Operation nicht im Schleifenrumpf verändert, ist diese Kontrollstruktur meist nicht die richtige, weil diese Schleife sonst genau einmal durchlaufen wird oder unendlich lang läuft.

### Die Do-While Schleife

While und for sind sogenannte kopfgesteuerte Schleifen. D.h., dass der Kontrollpunkt als erstes vor jedem Durchlauf ausgeführt wird. Soll zuerst der Schleifen-Block ausgeführt und dann die Bedingung für einen erneuten Durchlauf geprüft werden, verwenden wir die do while Schleife. Diese ist also eine fußgesteuerte Schleife.

In den vergangenen Beispielen haben wir gesehen, dass es immer sinnvoll ist, einen Durchlauf-Zähler zu verwenden, um das Ende der Schleife festzulegen. Die Durchlauf-Bedingung kann man aber auch von anderen Dingen abhängig machen, z.B. von Tastatureingaben. Erwarten wir vom Benutzer eine bestimmte Eingabe, eignet sich dafür die do while Schleife. Hierbei lesen wir im Schleifen-Block zuerst die Eingabe ein und werten diese dann beim Kontrollpunkt aus. Liegt die Eingabe nicht in dem von uns gewünschten Format vor, wird vom Benutzer erneut eine Eingabe gefordert.

Nehmen wir an, wir benötigen vom Benutzer die Eingabe seines Alters. In diesem Beispiel wird der Benutzer solange aufgefordert eine Zahl einzugeben, bis diese einem glaubhaften Alter entspricht. Ist die Eingabe kleiner 5 oder größer 100, wird der Schleifen-Block wiederholt.

```
do
{
Console.WriteLine(timer.elapsed + "Seconds elapsed.");
}
while(timer.completed)
```
  </p></details>

## Verzweigungen

Eine Bedingte Anweisung oder Verzwigung ist in der Programmierung ein Programmabschnitt, der nur unter einer bestimmten Bedingung ausgeführt wird. Eine Verzweigung legt fest, welcher von zwei (oder mehr) Programmabschnitten, abhängig von einer (oder mehreren) Bedingungen, ausgeführt wird.

Bedingte Anweisungen und Verzweigungen bilden, zusammen mit den Schleifen, die Kontrollstrukturen der Programmiersprachen. Sie gehören zu den wichtigsten Bestandteilen der Programmierung, da durch sie ein Programm auf unterschiedliche Zustände und Eingaben reagieren kann.

<details>
<summary>Verzweigungen</summary><p>

### Einfache Verzweigung / Bedingte Anweisung

Eine bedingte Anweisung besteht aus einer Bedingung und einem Codeabschnitt, der wiederum aus einer oder mehreren Anweisungen besteht. Wird bei der Programmausführung die bedingte Anweisung erreicht, dann wird erst die Bedingung ausgewertet, und falls diese zutrifft (und nur dann) wird anschließend der Codeabschnitt ausgeführt. Danach wird in jedem Fall die Programmausführung mit den auf die bedingte Anweisung folgenden Anweisungen fortgesetzt. In Pseudocode geschrieben:

```
falls Bedingung dann
  Anweisung(en)
ende
```

Die Bedingung ist kausaler Natur und nicht zu verwechseln mit einer temporalen (zeitlichen) Bedingung, d. h., es kommt darauf an, ob die Bedingung zu dem Zeitpunkt, da die bedingte Anweisung beim Programmablauf erreicht wird, zutrifft oder nicht.

Beispiele: in vielen Programmiersprachen mit C-ähnlicher Syntax (z. B. Java), werden bedingte Anweisungen folgendermaßen realisiert:

```
if (Temperatur < 20) 
{
  HeizungEinschalten();
}
```

Ist der hier abgefragte Wert Temperatur kleiner als 20, wird die Funktion HeizungEinschalten() ausgeführt. Ist die Bedingung nicht erfüllt, also Temperatur nicht kleiner als 20, wird die Anweisung übersprungen.  

![alt](https://upload.wikimedia.org/wikipedia/commons/thumb/5/5f/Einseitige_Auswahl_svg.svg/220px-Einseitige_Auswahl_svg.svg.png "Strucktogramm einer einfachen Verzweigung")

## Einfache If-Else Anweisung

Die einfache If- Else Anweisung ist eine einfache Abfrage, ob eine Bedingung zu trifft. Wenn ja, führt das Programm den einen Codeblock aus, wenn nicht den anderen.

```
falls Bedingung dann
    Anweisung Ja
Andernfalls
    Anweisung Nein
Ende
```

Wie bei der Bedingten Anweisung, ist die Bedingung nur kausal, das heißt, zum Zeitpunkt der Abfrage, ist der Zustand wichtig.

```
if(Temparatur > 20)
{
    HeizungEinschalten()M
}else
{
    HeizungAusschalften();
}
```

Oder in vereinfachter Form :

```
Temparatur > 20 ? HeizungEinschalten() : HeizungAusschalten();
```
![alt](https://upload.wikimedia.org/wikipedia/commons/thumb/4/41/Zweiseitige_Auswahl.png/220px-Zweiseitige_Auswahl.png "If-else Anweisung")

### Mehrfach verzweigung

In vielen Programmiersprachen gibt es auch mehrfache Verzweigungen, auch Fallunterscheidungen genannt. Dabei sind zwei Formen zu unterscheiden: Entweder bestimmt das Ergebnis eines Ausdrucks, welcher von mehreren Codeabschnitten ausgeführt wird (und ob überhaupt einer davon ausgeführt wird), oder es gibt mehrere Bedingungen, denen jeweils ein Codeabschnitt zugeordnet ist. In beiden Formen kann ein else-Teil vorhanden sein (ein weiterer Codeabschnitt).

![alt](https://upload.wikimedia.org/wikipedia/commons/5/59/Mehrseitige_Auswahl.png "Mehrfach Verzweigung")

#### Verzweigung von meheren If-Else Statements

Die Bedingungen werden der Reihe nach ausgewertet, solange bis eine davon zutrifft. Dann wird der zu dieser Bedingung gehörende Codeabschnitt ausgeführt und die Behandlung der mehrfachen Verzweigung ist damit beendet. Wenn keine der Bedingungen zutrifft, wird der else-Teil ausgeführt, falls er vorhanden ist:

```
falls Bedingung dann
  Anweisung(en)
sonst falls Bedingung2 dann
  Anweisung(en)
sonst falls Bedingung3 dann
  Anweisung(en)
sonst falls Bedingung4 dann
  Anweisung(en)
sonst
  Anweisung(en)
ende
```

#### Switch Case Verzweigung

Der Ausdruck wird ausgewertet und mit den Wertangaben (hier Wert1 bis Wert3) verglichen. Bei Übereinstimmung werden die Anweisungen nach der Wertangabe ausgeführt. Wenn kein Wert übereinstimmt, werden die Anweisungen nach sonst ausgeführt, falls der sonst-Teil vorhanden ist:

```
falls Ausdruck gleich
   Wert1: Anweisung(en)
   Wert2: Anweisung(en)
   Wert3: Anweisung(en)
   sonst: Anweisung(en)
ende
```

Beispiel in C# :

```
switch (zahl) {
   case 0: v = 1; break; // 'break' ist hier nötig, damit nicht auch die..
   case 1: v = 2; break; // ..folgenden Anweisungen ausgeführt werden 
   case 2: v = 5; break;
   default: v = 10;      // der sonst-Teil
}
```

Die genaue Semantik eines solchen Konstrukts hängt stark von der jeweiligen Programmiersprache ab. So ist z. B. der sonst-Teil nicht immer erlaubt, manchmal muss er aber vorhanden sein. Manchmal schreibt die Sprachdefinition auch vor, dass es zu einem Laufzeitfehler kommt, falls der sonst-Teil fehlt und der Ausdruck keinen der angegebenen Werte annimmt.


</p></details>