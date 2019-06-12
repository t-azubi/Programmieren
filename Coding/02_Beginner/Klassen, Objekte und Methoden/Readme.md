# Namespace, Klassen, Objekte und Mehoden

Heyho,

hier möchte ich dir etwas über Namespaces Klassen, Objekte und die Methoden einer Klasse erzählen.

## Namespace, damit der Compiler weiß wer gemeint ist

Dir ist bestimmt schon in den vorangegangen Programmen aufgefallen das es immer einen Namespace gibt.
Dieser ist essenziell und darf unter keinen Umständen fehlen.

<details close>
 
<summary>Namespace? ist das Programm so dick</summary>
 
Namespaces werden verwendet, um einen " benannten Raum " bereitzustellen, in dem sich Ihre Anwendung befindet. Sie werden insbesondere verwendet, um dem C#-Compiler einen Kontext für alle benannten Informationen in Ihrem Programm bereitzustellen, wie z.B. Variablennamen. Ohne Namensräume wäre es beispielsweise nicht möglich, eine Klasse namens Console zu erstellen, da .NET bereits einen in seinem Systemnamensraum verwendet. Der Zweck von Namensräumen ist es, dieses Problem zu lösen und Tausende von im .NET- Framework definierten Namen für Ihre Anwendungen freizugeben, zusammen mit der Tatsache, dass Ihre Anwendung keine Namen für andere Anwendungen belegt, wenn Ihre Anwendung in Verbindung mit einer anderen verwendet werden soll. Es existieren also Namensräume, um Mehrdeutigkeiten aufzulösen, die ein Compiler sonst nicht bewältigen könnte.

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

Durch die Verwendung des Schlüsselwortes using teilen Sie dem Compiler explizit mit, dass Sie einen bestimmten Namensraum in Ihrem Programm verwenden werden. Da der Compiler das dann wissen würde, ist es nicht mehr erforderlich, dass Sie den/die Namensraumnamen für solche deklarierten Namensräume eingeben, da Sie ihm gesagt haben, in welchen Namensräumen er suchen soll, wenn er die Daten in Ihrer Anwendung nicht finden konnte.

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

<details close>
 
<summary>Klassen? wasn das</summary>

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
