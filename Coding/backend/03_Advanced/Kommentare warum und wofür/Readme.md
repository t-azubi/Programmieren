# Kommentieren was bringt das ?

Wenn du so denkst, hast du wahrscheinlich noch nie an einem großen Projekt gearbeitet.
Stell dir vor du gehörst zu einem Team und hast max. 25 % des Codes des Programms geschrieben, möchtest aber verstehen was die anderen 75 % machen, da du Codedopplungen vermeiden willst.

Dir bleibt also ohne Kommentierten Code nur die Option dich durch alles durch zu arbeiten und rauszufinden wer was wo wie und warum macht. Diese Arbeit könnten dir Kommentare abnehemn.

## Kommentieren aber wie ? 

Beim Schreiben von Code wirst du dich schnell an die Tatsache gewöhnen, dass so ziemlich jedes Zeichen oder Wort, das du eingibst, eine besondere Bedeutung haben wird. Beispielsweise wirst du in C# viele Schlüsselwörter sehen, wie z.B. class, namespace, public und viele mehr. Du wirst auch sehen, dass der Compiler sicherstellt, dass du diese Schlüsselwörter sowie deine eigenen Variablen und Methoden auf die richtige Art und Weise verwenden. C# ist eine ziemlich strenge Sprache und der Compiler wird dir helfen, sicher zu stellen, dass alles so eingegeben wird, wie es sein sollte. UD hast jedoch dank des Konzepts der Code-Kommentare genau eine Möglichkeit, zu schreiben, was immer Sie wollen.

Dzu hast vielleicht schon einmal Kommentare in einigen der Codes gesehen, sei es in C# oder in einer anderen Programmiersprache - das Konzept der Kommentare im Quellcode ist ziemlich universell. Die Art und Weise, wie sie geschrieben werden, variiert jedoch sehr stark, also schauen wir uns die Art von Kommentaren an, die du in deinem C#-Code verwenden können.

### Einzeilige Kommentare

Die grundlegendste Art von Kommentaren in C# ist der einzeilige Kommentar. Wie der Name schon andeutet, wird eine einzelne Zeile in einen Kommentar verwandelt - schauen wir mal, wie das aussehen könnte:

```csharp
// My comments about the class name could go here...
class Program
{
    ......
```

So sieht's aus: Stelle deinen Zeilen zwei Schrägstriche voran (//) und dein Text geht von etwas, das der Compiler überprüfen und bemängeln wird, zu etwas, das der Compiler völlig ignoriert. Und während dies nur für die vorangestellte Zeile gilt, steht es dir frei, das Gleiche auf der nächsten Zeile zu tun, wobei im Prinzip einzeilige Kommentare verwendet werden, um mehrere Kommentarzeilen zu erzeugen:

```csharp
// My comments about the class name could go here...
// Add as many lines as you would like
// ...Seriously!
class Program
{
    ......
```

### Mehrzeilige Kommentare

Für den Fall, dass du mehrere Zeilen mit Kommentaren verfassen möchten, könnte es sinnvoller sein, die mehrzeilige Kommentervariante von C# zu verwenden. Anstatt jeder Zeile ein Präfix voranstellen zu müssen, gibst du einfach eine Start- und Stopp-Zeichenfolge ein - alles dazwischen wird als Kommentar behandelt:

```csharp
/*  
My comments about the class name could go here...  
Add as many lines of comments as you want  
    ...and use indentation, if you want to!  
*/  
class Program  
{
    ......
```

Benutze die Startsequenz Vorwärtsstrich-Sternchen (/*), schreibe, was immer du willst, über mehrere Zeilen oder nicht, und beende dann alles mit der Endsequenz Sternchen-Vorwärtsstrich (*/). Zwischen diesen Markierungen kannst du alles schreiben, was du möchtest.

Wie bei so ziemlich jedem anderen programmbezogenen Thema wird oft darüber debattiert, ob mehrere einzeilige Kommentare oder ein mehrzeiliger Kommentar verwendet werden sollen. Ich persönlich benutze beides, für verschiedene Situationen - am Ende liegt es an dir!

### Kommentare zur Dokumentation 

Dokumentationskommentare (manchmal auch als XML-Dokumentationskommentare bezeichnet) sehen aus wie reguläre Kommentare, aber mit eingebettetem XML. Wie bei regelmäßigen Kommentaren gibt es auch hier zwei Arten von Kommentaren: Einzeilige und mehrzeilige. Du schreibst sie auch auf die gleiche Art und Weise, aber mit einem zusätzlichen Charakter. So verwendet einzeilige XML-Dokumentationskommentare drei Vorwärtsschrägstriche (///) anstelle von zwei, und die mehrzeilige Variante erhält ein zusätzliches Sternchen im Startbegrenzer. Schauen wir mal, wie es aussieht:

```csharp
class User
{
    /// <summary>
    /// The Name of the User.
    /// </summary>
    public string Name { get; set; }

    /**
    * <summary>The Age of the User.</summary>
    */
    public string Age { get; set; }
}
```

Hier siehst du beide Varianten - ein- und mehrzeilige. Das Ergebnis ist das Gleiche, aber die erste Variante ist tendenziell die am häufigsten verwendete für Dokumentationskommentare.

Das Dokumentieren von Typen und deren Mitgliedern mit Dokumentationskommentaren ist ein ziemlich großes Thema, und deshalb wird es in einem späteren Artikel ausführlicher behandelt, aber jetzt weißt du, wie sie aussehen!
Code-Kommentare & die Aufgabenliste

Wenn Sie Visual Studio verwenden, können Sie tatsächlich Hilfe beim Verfolgen Ihrer Code-Kommentare erhalten. Im Fenster Aufgabenliste (aufzurufen über das Menü Ansicht > Aufgabenliste) erscheinen Ihre Kommentare, wenn sie die spezielle, aber sehr einfache Kommentarsyntax der Aufgabenliste verwenden:

```csharp
//TODO: Change "world" to "universe"
Console.WriteLine("Hello, world!");
//HACK: Don't try this at home....
int answerToLife = 42;
```

Wenn also der einzeilige Kommentar unmittelbar von TODO oder HACK gefolgt wird, erscheint er in der Aufgabenliste von Visual Studio, so wie hier gezeigt:

![VS Task List](https://csharp.net-tutorials.com/Images/ArticleImages/2/the-basics/code_comments_task_list.png)

Es gibt noch mehr Typen - je nach verwendeter Version von Visual Studio reagiert sie auf einige oder alle der folgenden Kommentartokens:

```csharp
    TODO
    HACK
    NOTE
    UNDONE
```

Du kannst sogar deine eigenen Token hinzufügen, wenn du möchtest - befolge einfach die in [diesem Artikel](https://docs.microsoft.com/en-us/visualstudio/ide/using-the-task-list?view=vs-2019) beschriebenen Arbeitsschritte.

## Zusammenfassung

Code-Kommentare sind äußerst nützlich, um deinen Code zu dokumentieren oder um sich selbst oder den potenziellen Kollegen Anhaltspunkte darüber zu geben, wie die Dinge funktionieren. Als zusätzlichen Vorteil sind sie großartig, wenn du etwas schnell testen musst - kopiere einfach eine Zeile und kommentarlos die ursprüngliche Zeile aus und du kannst sehen, wie es jetzt funktioniert. Wenn du mit dem Ergebnis nicht zufrieden bist, kannst du einfach die neue Zeile löschen und die ursprüngliche Zeile entkommentarisieren und schon bist du wieder dort, wo du angefangen hast.

Und mach dir keine Sorgen, dass der Endbenutzer durch deine Kommentare schnüffelt - sie werden, wie bereits erwähnt, vom Compiler völlig ignoriert und sind daher in deiner endgültigen DLL- oder EXE-Datei überhaupt nicht enthalten. Code-Kommentare sind dein persönlicher Freiraum beim Programmieren, also benutze sie so, wie du es möchtest.