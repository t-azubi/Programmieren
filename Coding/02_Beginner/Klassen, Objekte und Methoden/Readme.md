# Namespace, Klassen, Objekte und Mehoden

Heyho,

hier möchte ich dir etwas über Namespaces Klassen, Objekte und die Methoden einer Klasse erzählen.

## Namespace, damit der Compiler weiß wer gemeint ist

Dir ist bestimmt schon in den vorangegangen Programmen aufgefallen das es immer einen Namespace gibt.

Namespaces werden benutzt, um Klassen zu gruppieren. Namespaceskennzeichnen sich durch das Schlüsselwort namespace und den Namen des Namensraums und bilden dabei immer einen Block.
Normalerweise haben Programme immer nur einen Namensraum. Bei sehr großen Projekten, bei denen es viele Klassen gibt, macht es jedoch schon Sinn, mehrere Namespaceszu erstellen. Bei sehr großen Projekten ist es des Weiteren u. U. notwendig, Namespaceszu verschachteln. Eine solche Verschachtelung kann auf 2 Arten erzeugt werden: Die 1. Möglichkeit wäre die hierarchische Verschachtelung von namespace-Blöcken. Bei der 2. Möglichkeit werden die einzelnen Namen in einem namespace-Block durch einen Punkt getrennt. Im Beispiel haben wir die 2. Möglichkeit verwendet.
Nachdem wir nun Namespaces erstellen können, müssen wir noch wissen, wie wir von einem anderen Namensraum darauf zugreifen können. Hierfür benötigen wir das Schlüsselwort using. Mit using können wir einen Namensraum einbinden. Bei dieser Einbindung müssen wir den Namen notieren, welcher in der Deklaration des Namespaces angegeben wurde.

<details close>

<summary>Namespaces im Detail </summary>

Namespaces werden verwendet, um einen " benannten Raum " bereitzustellen, in dem sich Ihre Anwendung befindet. Sie werden insbesondere verwendet, um dem C#-Compiler einen Kontext für alle benannten Informationen in Ihrem Programm bereitzustellen, wie z.B. Variablennamen. Ohne Namespaceswäre es beispielsweise nicht möglich, eine Klasse namens Console zu erstellen, da .NET bereits einen in seinem Systemnamensraum verwendet. Der Zweck von Namespaces ist es, dieses Problem zu lösen und Tausende von im .NET- Framework definierten Namen für Ihre Anwendungen freizugeben, zusammen mit der Tatsache, dass Ihre Anwendung keine Namen für andere Anwendungen belegt, wenn Ihre Anwendung in Verbindung mit einer anderen verwendet werden soll. Es existieren also Namespaces, um Mehrdeutigkeiten aufzulösen, die ein Compiler sonst nicht bewältigen könnte.

Auf diese Weise lassen sich Namespaces leicht definieren:

```csharp
 namespace Meine Anwendung
 {
     // Der Inhalt, der sich im Namensraum MyApplication befinden soll, wird hier platziert.
 }
```

Es gibt eine ganze Hierarchie von Namespaces, die Ihnen vom .NET Framework zur Verfügung gestellt werden, wobei der System-Namespace normalerweise der bei weitem am häufigsten gesehene ist. Auf Daten in einem Namespace wird mit dem Operator . verwiesen, wie z.B.:

```csharp
 System.Console.WriteLine("Hallo, Welt!");
```

Dadurch wird die Methode WriteLine aufgerufen, die ein Mitglied der Klasse Console innerhalb des System-Namespace ist.

Durch die Verwendung des Schlüsselwortes using teilen Sie dem Compiler explizit mit, dass Sie einen bestimmten Namensraum in Ihrem Programm verwenden werden. Da der Compiler das dann wissen würde, ist es nicht mehr erforderlich, dass Sie den/die Namensraumnamen für solche deklarierten Namespaceseingeben, da Sie ihm gesagt haben, in welchen Namespacesn er suchen soll, wenn er die Daten in Ihrer Anwendung nicht finden konnte.

Das sieht dann so aus:

```csharp
using System;
 
 namespace Meine Anwendung
 {
   class MyClass
   {
     void ShowGruß()
     {
         Console.WriteLine("Hello, World!"); // Beachten Sie, dass das System nun nicht mehr benötigt wird.
     }
   }
 }
```

Namespaces sind global, so dass ein Namespace in einer C#-Quelldatei und ein weiterer mit dem gleichen Namen in einer anderen Quelldatei dazu führt, dass der Compiler die verschiedenen benannten Informationen in diesen beiden Quelldateien so behandelt, als befänden sie sich im gleichen Namespace.

</details>

## Was ist eine Klasse?

Eine Klasse stellt einen Bauplan dar, welche Variablen, Eigenschaften (dazu später mehr) und Funktionen enthalten. Eine Klasse kann also als Ansammlung von Variablen, Eigenschaften und Funktionen bezeichnet werden. Klassen werden dazu eingesetzt, einen zusammenhängenden Programm-Teil zu kapseln. Die Klasse befindet sich innerhalb des namespace-Blocks. Auch die Klasse selbst bildet einen Block, welche sich durch das Schlüsselwort class kennzeichnet.

In der „objektorientierten Programmierung“ (kurz OOP) gibt es einige stilistische Regeln. Hierzu zählt z. B. dass globale Variablen nicht von außen zugänglich gemacht werden sollten. Um Werte einer internen Variable auszulesen oder zu setzen, wird daher entweder eine Funktion geschrieben oder Eigenschaften verwendet. Der Vorteil von Funktionen und Eigenschaften ist, dass hier ein Programmcode hinterlegt werden kann, mit dem z. B. der Wertebereich (bei Zahlen) überprüft werden kann.
Hierzu ein Beispiel: Wir haben einen Bauplan (Klasse) für ein Auto. Von diesem Auto können wir jetzt eine unbegrenzte Anzahl bauen, die jederzeit erweitert werden kann. Die einzelnen Autos stellen also die Objekte dar.

<details close>

<summary>Klassen im Detail </summary>

Wie in anderen objektorientierten Programmiersprachen ist die Funktionalität eines C#-Programms in einer oder mehreren Klassen implementiert. Die Methoden und Eigenschaften einer Klasse enthalten den Code, der das Verhalten der Klasse definiert.

C#-Klassen unterstützen das Verstecken von Informationen, indem sie Funktionalität in Eigenschaften und Methoden kapseln und verschiedene Arten von Polymorphismus aktivieren, einschließlich der Subtypisierung von Polymorphismus durch Vererbung und parametrischem Polymorphismus durch Generika.

Es können mehrere Arten von C#-Klassen definiert werden, darunter Instanzklassen (instanziierbare Standardklassen), statische Klassen und Strukturen.

### Aufbau einer Klasse

Klassen werden über das Schlüsselwort

```csharp
class
```

definiert, gefolgt von einem Bezeichner, der die Klasse benennt. Instanzen der Klasse können dann mit dem Schlüsselwort

```csharp
new
```

und dem Namen der Klasse angelegt werden.

Der folgende Code definiert eine Klasse namens employee mit den Eigenschaften Name und Alter und mit den leeren Methoden GetPayCheck() und Work(). Es definiert auch eine Sample-Klasse, die die employee-Klasse instanziiert und verwendet:

```csharp
public class Employee
{
    private int _Age;
    private string _Name;

    public int Age
    {
        get { return _Age; }
        set { _Age = value; }
    }

    public string Name
    {
        get { return _Name; }
        set { _Name = value; }
    }

    public void GetPayCheck()
    {
    }

    public void Work()
    {
    }
}

public class Sample
{
    public static void Main()
    {
        Employee marissa = new Employee();

        marissa.Work();
        marissa.GetPayCheck();
    }
}
```

### Methoden

C#-Methoden sind Klassenmitglieder, die Code enthalten. Sie können einen Rückgabewert und eine Liste von Parametern sowie eine generische Typdeklaration enthalten. Methoden können wie Felder statisch (zugeordnet und über die Klasse angesprochen) oder instanziiert (zugeordnet und angesprochen durch eine Objektinstanz der Klassenmethoden sowie eine generische Typdeklaration) sein.

Ab C# 4.0 ist es möglich, dass eine Methode optionale Parameter mit Standardwerten hat, wie Benutzer von C++ bereits wissen. Zum Beispiel die Methode

```csharp
void Inkrement(ref int x, int dx = 1)
```

kann nur mit einem Parameter aufgerufen werden, da der zweite Parameter dx auf einen Standardwert initialisiert wird.

### Konstrukteure von Klassen

Die Konstruktoren einer Klasse steuern ihre Initialisierung. Der Code eines Konstruktors wird ausgeführt, um eine Instanz der Klasse zu initialisieren, wenn ein Programm ein neues Objekt vom Typ der Klasse anfordert. Konstruktoren setzen oft Eigenschaften ihrer Klassen, aber sie sind nicht darauf beschränkt.

Wie andere Methoden auch, kann ein Konstruktor Parameter haben. Um ein Objekt mit ein Constructor mit Parametern zu erstellen, akzeptiert der neue Befehl Parameter. Der folgende Code definiert und instanziiert mehrere Objekte der Klasse employee, einmal mit dem Konstruktor ohne Parameter und einmal mit der Version mit einem Parameter:

```csharp
public class Employee
{
    public Employee()
    {
        System.Console.WriteLine("Constructed without parameters");
    }

    public Employee(string strText)
    {
        System.Console.WriteLine(strText);
    }
}

public class Sample
{
    public static void Main()
    {
        System.Console.WriteLine("Start");
        Employee Alfred = new Employee();
        Employee Billy  = new Employee("Parameter for construction");
        System.Console.WriteLine("End");
    }
```

Constructors können sich gegenseitig anrufen:

```csharp
public class Employee
{
    public Employee(string strText, int iNumber)
    {
        ...
    }
    
    public Employee(string strText)
        : this(strText, 1234) // calls the above constructor with user-specified text and the default number
    { }
    
    public Employee()
        : this("default text") // calls the above constructor with the default text
    { }
}
```

</details>

## Objekte

Von Objekten spricht man, wenn eine Variable einer Klasse initialisiert wird. Um eine Variable einer Klasse zu initialisieren, benötigen wir das Schlüsselwort new, den Klassennamen und runde Klammern (direkt hinter dem Klassennamen, also wie bei einer Funktion). Die Anzahl der Objektinitialisierungen unserer Klasse ist unbegrenzt, somit können wir mehrere Objekt erzeugen, benötigen jedoch immer nur eine Klasse.

### Objekteigenschaften

Objekteigenschaften (oder auch nur Eigenschaften) sind „bessere“ Variablen, hinter welchen ein Programmcode hinterlegt werden kann (also wie bei Funktionen). Eigenschaften sehen von der Deklaration ähnlich wie Variablen aus, bilden jedoch immer einen Block.

Bei einfachen Eigenschaften (ohne Werte-Prüfung oder anderen Programmcode) müssen innerhalb des Blocks die Schlüsselwörter get und set mit jeweils einem Semikolon am Ende notiert werden. Dadurch entspricht die Eigenschaft eigentlich einer Variablen. Trotzdem sollten Sie immer Eigenschaften anstatt Variablen verwenden, wenn der Wert von „außen“ (also von außerhalb der Klasse) zugänglich sein soll.

Die komplexeren Eigenschaften besitzen einen Programmcode, welche zur Überprüfung des Wertes genutzt werden kann. Natürlich könnten auch andere Aktionen ausgeführt werden, wie z. B. der Aufruf einer internen Funktion o. Ä.. Bei den komplexeren Eigenschaften bilden die get- und set-Schlüsselwörter eigene Blöcke. Innerhalb des get-Blocks muss ein Wert durch return zurückgegeben werden. Im set-Block dagegen kann der Wert z. B. in einer internen Variablen gespeichert werden. Um auf den „übergebenen“ oder zu setzenden Wert zuzugreifen, nutzen wir das Schlüsselwort value. Wie wir also sehen können, ist bei den komplexeren Eigenschaften immer eine interne Variable von Nöten, wenn der Wert intern gespeichert werden soll. Der Variablenname besteht dabei oft aus einem Unterstrich und dem Eigenschaftsnamen.

Stellen wir uns einmal vor, was wir mit solchen Eigenschaften alles machen können und wie wir diese adaptieren können. Es ist z. B. möglich, den set-Block wegzulassen: Dadurch können wir das Setzen eines Wertes unterbinden. Um das Setzen innerhalb der Klasse zuzulassen, jedoch von außen zu unterbinden.
