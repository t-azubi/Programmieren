# C# Grundlagen
Das Repo ist da um mein Wissen in der Programmiersprache C# zu präsentiern. <br>
Ich entschuldige mich für die unordnung.

## Variablen
Variablen sind Speicher für Datentypen. [Doc](https://docs.microsoft.com/de-de/dotnet/visual-basic/programming-guide/language-features/variables/)
In ihnen kann man Zeichenketten (string), einzelne Zeichen (char), Zahlen (Integer), Wahr oder Falsch (Boolean) und vieles mehr Deklarieren. ([Werttypen](https://docs.microsoft.com/de-de/dotnet/csharp/language-reference/keywords/value-types)) 

## If Schleifen
If Schleifen sind mit "Wenn (x) dann Anweisung" zu vergleichen. Neben dieser "Wenn - Dann" Bedingung kann man auch noch ein "Andernfals" bzw. else, was einen anderen fall angibt. Man kann es sich wie folgt vorstellen "Wenn (x) dann Anweisung Andernfals Anweisung2".
Die else Anweisung kann man nun noch durch weitere If Anweisungen erweitern. [if - else](https://docs.microsoft.com/de-de/dotnet/csharp/language-reference/keywords/if-else)

## Switch Case
Die Switch Case of Auswahlanweisung ist für größere If else Anweisung eine praktische Verkürzung. <br>
Man schaut welcher Fall eintritt und führt dan die jeweilige Anweisung aus. Desweiteren kann man bei einer Switch Anweisung einen Default Case festlegen, der ausgeführt wird, wenn
kein Fall (Case) zu trifft. <br>
Um die Switch Case Anwendung zu beenden, schreibt man nach der Anweisung des Falls ein break um aus der Auswahlanweisung zu kommen. [Doc](https://docs.microsoft.com/de-de/dotnet/csharp/language-reference/keywords/switch)

## Schleifen 
Schleifen sind eine einfache Möglichkeit die selbe Anweisung n-Fach anzuwenden. [Doc](https://docs.microsoft.com/de-de/dotnet/visual-basic/programming-guide/language-features/control-flow/loop-structures) [Doc](https://docs.microsoft.com/de-de/dotnet/csharp/language-reference/keywords/iteration-statements) <br>
Man unterscheidet 3 verschiedene Arten von Schleifen : 
* Kopfgesteuerte Schleifen (Bedingun für Schleife steht im Schleifenkopf -> ```while(a = b){...}```)
* Fußgesteuerte Schleifen (Bedingung für Schleife steht im Schleifenfuß -> ```do {...} while(a != b)```)
* Zählschleifen (Schleife läuft solange bis a => | > | = | <= | < b -> ```for (int i = 0; i < 5; i++)```)
