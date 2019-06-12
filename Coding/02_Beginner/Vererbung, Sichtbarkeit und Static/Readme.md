
# Vererbung, Sichtbarkeiten und Static

## Vererbung

Bei der Vererbung werden, wie der Name schon vermuten lässt, Funktionen, Variablen und Eigenschaften von der einen Klasse (Basisklasse) zu einer anderen Klasse (abgeleitete Klasse) vererbt. Die Basisklasse (auch Elternklasse oder vererbende Klasse genannt) stellt also Funktionen, Variablen und Eigenschaften zur Verfügung, welche in einer oder mehreren abgeleiteten Klasse(n) (auch Kindklasse(n) genannt) zur Verfügung stehen. Grundsätzlich kann jede Klasse als Basisklasse verwendet werden. Bei der abgeleiteten Klasse muss hinter dem Klassennamen ein Doppelpunkt und dahinter die Basisklasse notiert werden. Die abgeleitete Klasse kann auf alle Funktionen, Variablen und Eigenschaften der Basisklasse zugreifen, welche den Zugriffsmodifizierer protected oder public besitzen.

## Sichtbarkeiten

Die Sichtbarkeit einer Klasse, einer Methode, einer Variablen oder einer Eigenschaft sagt uns, wie auf dieses Element zugegriffen werden kann. Die häufigsten Arten der Sichtbarkeit sind privat und öffentlich, aber es gibt tatsächlich mehrere andere Arten von Sichtbarkeit in C#. Hier ist eine vollständige Liste, und obwohl Sie einige von ihnen nicht gerade relevant finden, können Sie immer auf diese Seite zurückkommen und sich darüber informieren:

```public``` (Öffentlich) - das Mitglied ist von überall erreichbar. Dies ist die am wenigsten einschränkende Sichtbarkeit. Enums und Schnittstellen sind standardmäßig öffentlich sichtbar.

```protected``` (geschützt) - Mitglieder können nur innerhalb derselben Klasse oder von einer Klasse erreicht werden, die von dieser Klasse erbt.

```internal``` (intern) - Mitglieder können nur innerhalb des gleichen Projekts erreicht werden.

```protected internal``` (intern geschützt) - das gleiche wie intern, außer dass auch Klassen, die von dieser Klasse erben, es selbst von einem anderen Projekt aus erreichen können.

```private``` (privat) - kann nur von Mitgliedern derselben Klasse erreicht werden. Dies ist die am meisten eingeschränkte Sichtbarkeit. Klassen und Strukturen sind standardmäßig auf private Sichtbarkeit eingestellt.

Wenn Sie beispielsweise zwei Klassen, Class1 und Class2, haben, können private Mitglieder von Class1 nur innerhalb von Class1 verwendet werden. Sie können keine neue Instanz von Class1 innerhalb von Class2 erstellen und dann erwarten, dass Sie ihr privates Mitglied verwenden können.

Wenn Class2 von Class1 erbt, können nur nicht private Mitglieder innerhalb von Class2 erreicht werden.

## Static ?

Die übliche Kommunikation vom Methoden mit einer Klasse besteht darin, eine neue Instanz der Klasse zu erstellen und dann am resultierenden Objekt zu arbeiten. In den meisten Fällen geht es dabei um Klassen - die Fähigkeit, mehrere Kopien derselben Klasse zu instanziieren und sie dann in irgendeiner Weise anders zu verwenden. In einigen Fällen möchten Sie jedoch möglicherweise eine Klasse verwenden, die Sie verwenden können, ohne sie zu instanziieren, oder zumindest eine Klasse, in der Sie Member verwenden können, ohne dafür ein Objekt zu erstellen. Zum Beispiel haben Sie vielleicht eine Klasse mit einer Variablen, die immer gleich bleibt, egal wo und wie sie verwendet wird. Dies wird als statisches Element bezeichnet, statisch, da es gleich bleibt.

Eine Klasse kann statisch sein und statische Elemente, Funktionen und Felder enthalten. Eine statische Klasse kann nicht instanziiert werden. Mit anderen Worten, sie funktioniert eher als eine Gruppierung verwandter Elemente als eine tatsächliche Klasse. Sie können stattdessen eine nicht statische Klasse erstellen, aber bestimmte statische Elemente haben. Eine nicht statische Klasse kann weiterhin instanziiert und wie eine reguläre Klasse verwendet werden, Sie können jedoch kein statisches Member für ein Objekt der Klasse verwenden. Eine statische Klasse darf nur statische Mitglieder enthalten.

Hier ist ein Beispiel für eine statische Klasse:

```csharp
public static class Rectangle
{
    public static int CalculateArea(int width, int height)
    {
        return width * height;
    }
}
```

Wie Sie sehen, verwenden wir das static-Schlüsselwort, um die Klasse als statisch zu markieren, und dann verwenden wir es erneut, um die Methode CalculateArea ebenfalls als statisch zu markieren. Wenn wir das nicht tun würden, würde sich der Compiler beschweren, da wir kein nicht-statisches Mitglied einer statischen Klasse haben können.

Um diese Methode zu verwenden, rufen wir sie direkt in der Klasse auf:

Console.WriteLine("The area is: " + Rectangle.CalculateArea(5, 4));

Wir könnten der "Rectangle-Klasse" weitere hilfreiche Methoden hinzufügen, aber vielleicht fragen Sie sich, warum wir Breite und Höhe an die tatsächliche Methode weitergeben, anstatt sie innerhalb der Klasse zu speichern und sie dann bei Bedarf von dort zu entfernen. Weil sie statisch ist! Wir könnten sie speichern, aber nur einen Set von Dimensionen, weil es nur eine Version einer statischen Klasse gibt. Dies ist sehr wichtig zu verstehen.

Stattdessen können wir die Klasse nicht statisch machen und dann die "CalculateArea" als Dienstprogrammfunktion für diese Klasse verwenden:
Download, Edit & Run this example!

```csharp
public class Rectangle
{
    private int width, height;

    public Rectangle(int width, int height)
    {
        this.width = width;
        this.height = height;
    }

    public void OutputArea()
    {
        Console.WriteLine("Area output: " + Rectangle.CalculateArea(this.width, this.height));
    }

    public static int CalculateArea(int width, int height)
    {
        return width * height;
    }
}
```

Wie Sie sehen können, haben wir die Klasse nicht statisch gemacht. Wir haben auch einen Konstruktor hinzugefügt, der eine Breite und eine Höhe annimmt und sie der Instanz zuweist. Dann haben wir eine "OutputArea-Methode" hinzugefügt, die die statische Methode zur Berechnung des Bereichs verwendet. Dies ist ein gutes Beispiel für das mischen statischer Member mit nicht statischen Membern in einer nicht statischen Klasse.
Eine übliche Verwendung von statischen Klassen, obwohl von einigen Leuten verpönt, sind Utility- / Hilfsklassen, in denen Sie eine Reihe nützlicher Methoden sammeln, die vielleicht nicht zusammengehören, aber auch nicht wirklich passen.