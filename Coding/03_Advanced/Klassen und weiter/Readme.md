# Klassen sind ja echt Cool und was gibts noch?

## Finalisierer (Zerstörer)

Im Gegensatz zu Konstruktoren definieren Finalizer das endgültige Verhalten eines Objekts und führen es aus, wenn das Objekt nicht mehr verwendet wird. Obwohl sie in C++ häufig verwendet werden, um Ressourcen freizugeben, die von einem Objekt reserviert sind, werden sie in C# aufgrund des .NET Framework Garbage Collectors seltener verwendet. Der Finalizer eines Objekts, der keine Parameter benötigt, wird irgendwann aufgerufen, nachdem ein Objekt nicht mehr referenziert wurde, aber die Komplexität der Garbage Collection macht das spezifische Timing der Finalizer unsicher.

```csharp
public class Employee
{
    public Employee(string strText)
    {
        System.Console.WriteLine(strText);
    }

    ~Employee()
    {
        System.Console.WriteLine("Finalized!");
    }

    public static void Main()
    {
        Employee marissa = new Employee("Constructed!");

        marissa = null;
    }
}
```

## Eigenschaften

C#-Eigenschaften sind Klassenmitglieder, die die Funktionalität von Methoden unter Verwendung der Syntax von Feldern darstellen. Sie vereinfachen die Syntax des Aufrufs traditioneller get und set Methoden (alias accessor methods). Wie Methoden können sie statisch oder instanzartig sein.

Die Eigenschaften werden wie folgt definiert:

```csharp
public class MyClass
{
    private int m_iField = 3; // Sets integerField with a default value of 3

    public int IntegerField
    {
        get
        {
            return m_iField;  // get returns the field you specify when this property is assigned
        }
        set
        {
            m_iField = value; // set assigns the value assigned to the property of the field you specify
        }
    }
}
```

Ein noch kürzerer Weg für Getter/Setter-Methoden sind Accessoren, die beides in einer Zeile tun:

```csharp
class Culture
{
    public int TalkedCountries { get; set; }
    public string Language { get; set; }
}

class InterculturalDialogue
{
    Culture culture;

    culture.Language = "Italian";  // ==> culture.SetLanguage("Italian");

    string strThisLanguage = culture.Language; // ==> ... = culture.GetLanguage();
}
```

Der Code entspricht einer GetLanguage- und SetLanguage-Methodendefinition, ohne dass diese Methoden definiert werden müssen. Der Benutzer kann direkt auf das Mitglied zugreifen, wenn es nicht privat ist, natürlich.

Das C#-Schlüsselwort

```csharp
value
```

enthält den Wert, der der Eigenschaft zugewiesen wurde. Nachdem eine Eigenschaft definiert wurde, kann sie wie eine Variable verwendet werden. Wenn Sie einen zusätzlichen Code in die get und set Teile der Eigenschaft schreiben würden, würde es wie eine Methode funktionieren und Ihnen erlauben, die Daten zu manipulieren, bevor sie gelesen oder in die Variable geschrieben werden.

```csharp
public class MyProgram
{
    MyClass myClass = new MyClass;

    Console.WriteLine(myClass.IntegerField); // Writes 3 to the command line.
    myClass.IntegerField = 7; // Indirectly assigns 7 to the field myClass.m_iField
}
```

Die Verwendung von Eigenschaften auf diese Weise bietet einen sauberen, einfach zu bedienenden Mechanismus zum Schutz von Daten.

## Indexer

C#-Indexer sind Klassenmitglieder, die das Verhalten der Array-Zugriffsoperation definieren (z.B. list[0], um auf das erste Element der Liste zuzugreifen, auch wenn list kein Array ist).

Um einen Indexer anzulegen, verwenden Sie das Schlüsselwort

 ```csharp
this
```

wie im folgenden Beispiel:

```csharp
public string this[string strKey]
{
    get { return coll[strKey]; }
    set { coll[strKey] = value; }
}
```

Dieser Code erstellt einen Zeichenkettenindexer, der einen Zeichenkettenwert zurückgibt. Wenn die Klasse beispielsweise EmployeeCollection war, können Sie Code ähnlich wie folgt schreiben:

```csharp
EmployeeCollection e = new EmployeeCollection();
.
.
.
string s = e["Jones"];
e["Smith"] = "xxx";
```

## Events

C#-Events sind Klassenmitglieder, die Benachrichtigungen für Clients der Klasse bereitstellen. Events werden nur "abgefeuert" und nie zugeordnet.

Eine Event ist eine spezielle Art von Delegierten, die eine ereignisgesteuerte Programmierung ermöglicht. Events sind Klassenmitglieder, die außerhalb der Klasse nicht aufgerufen werden können, unabhängig von ihrer Zugriffsspezifikation. So würde beispielsweise ein als öffentlich deklariertes Event anderen Klassen die Verwendung von += und -= auf das Event erlauben, aber das Auslösen des Events (d.h. das Aufrufen des Delegierten) ist nur in der Klasse erlaubt, die das Event enthält. 

Ein Beispiel:

```csharp
using System;

// Note: You need to know some about delegate, properties and methods to understand this sample
namespace EventSample
{
    /// <summary>
    /// This delegate defines the signature of the appropriate method
    /// </summary>
    public delegate void ContractHandler(Employee sender);

    /// <summary>
    ///     Employee class
    /// </summary>
    public class Employee
    {
        /// <summary>
        ///     Field for the info whether or not the Employee is engaged
        /// </summary>
        private bool bIsEngaged = false;
        /// <summary>
        ///     Age of the employee
        /// </summary>
        private int iAge = -1;
        /// <summary>
        ///     Name of the employee
        /// </summary>
        private String strName = null;

        /// <summary>
        /// *** The our event *** 
        /// Is a collection of methods that will be called when it fires
        /// </summary>
        public event ContractHandler Engaged;

        /// <summary>
        ///     Standard constructor
        /// </summary>
        public Employee()
        {
            // Here, we are adding a new method with appropriate signature (defined by delegate)
            // note: when a event not have any method and it was fired, it causes a exception!
            //       for all effects when programming with events, assign one private method to event
            //       or simply do a verification before fire it! --> if (event != null)
            this.Engaged += new ContractHandler(this.OnEngaged);
        }

        /// <summary>
        ///     Event handler for the "engaged" event
        /// </summary>
        /// <param name="sender">
        ///     Sender object
        /// </param>
        private void OnEngaged(Employee sender)
        {
            Console.WriteLine("private void OnEngaged was called! this employee is engaged now!");
        }

        /// <summary>
        ///     Accessor for the employee name
        /// </summary>
        public string Name
        {
            get
            {
                return strName;
            }

            set
            {
                strName = value;
            }
        }

        /// <summary>
        ///     Accessor for the employee age
        /// </summary>
        public int Age
        {
            get
            {
                return m_iAge;
            }

            set
            {
                m_iAge = value;
            }
        }

        /// <summary>
        ///     Accessor for the information about Employee engagement
        /// </summary>
        public bool IsEngaged
        {
            get
            {
                return bIsEngaged;
            }

            set
            {
                if (bIsEngaged == false && value == true)
                {
                    // here we fires event (call all the methods that it have)
                    // all times when IsEngaged is false and set to true;
                    Engaged(this);
                }

                bIsEngaged = value;
            }
        }
    }

    /// <summary>
    ///     Class for the entry point
    /// </summary>
    public class EntryPointClass
    {
        static void Main(string[] a_strArgs)
        {
            Employee simpleEmployee = new Employee();

            simpleEmployee.Age = 18;
            simpleEmployee.Name = "Samanta Rock";
            
            // Here...
            // This is saying when the event fire, the method added to event are called too.
            // note that we cannot use =
            // is only += to add methods to event or -= do retire a event
            simpleEmployee.Engaged += new ContractHandler(SimpleEmployee_Engaged);
        
            // make attention here...
            // when I assign true to this property, 
            // the event Engaged will be called
            // when event is called, all method that it have, are called!
            simpleEmployee.IsEngaged = true;

            Console.ReadLine();

            return;
        }

        /// <summary>
        ///     Event handler for the registered "engaged" event
        /// </summary>
        /// <param name="sender">
        ///     Event sender
        /// </param>
        static void SimpleEmployee_Engaged(Employee sender)
        {
            Console.WriteLine("The employee {0} is happy!", sender.Name);
        }
    }
}
```

## Operator Overloading

C#-Operatordefinitionen sind Klassenmitglieder, die das Verhalten von grundlegenden C#-Operatoren (implizit oder explizit aufgerufen) in Instanzen der Klasse definieren oder neu definieren:

```csharp
public class Complex
{
    private double m_dReal, m_dImaginary;
    
    public double Real
    {
        get { return m_dReal; }
        set { m_dReal = value; }
    }
    
    public double Imaginary
    {
        get { return m_dImaginary; }
        set { m_dImaginary = value; }
    }
    
    // binary operator overloading
    public static Complex operator +(Complex c1, Complex c2)
    {
        return new Complex() { Real = c1.Real + c2.Real, Imaginary = c1.Imaginary + c2.Imaginary };
    }
    
    // unary operator overloading
    public static Complex operator -(Complex c)
    {
        return new Complex() { Real = -c.Real, Imaginary = -c.Imaginary };
    }
    
    // cast operator overloading (both implicit and explicit)
    public static implicit operator double(Complex c)
    {
        // return the modulus - sqrt(x^2 + y^2)
        return Math.Sqrt(Math.Pow(c.Real, 2) + Math.Pow(c.Imaginary, 2));
    }
    
    public static explicit operator string(Complex c)
    {
        // we should be overloading the ToString() method, but this is just a demonstration
        return c.Real.ToString() + " + " + c.Imaginary.ToString() + "i";
    }
}

public class StaticDemo
{
    public static void Main()
    {
        Complex number1 = new Complex() { Real = 1, Imaginary = 2 };
        Complex number2 = new Complex() { Real = 4, Imaginary = 10 };
        Complex number3 = number1 + number2; // number3 now has Real = 5, Imaginary = 12
        
        number3 = -number3; // number3 now has Real = -5, Imaginary = -12
        double testNumber = number3; // testNumber will be set to the absolute value of number3
        Console.WriteLine((string)number3); // This will print "-5 + -12i".
        // The cast to string was needed because that was an explicit cast operator.
    }
}
```

## Strukturen

Strukturen werden mit dem Schlüsselwort

 ```csharp
struct
```

definiert, gefolgt von einem Bezeichner, um die Struktur zu benennen. Sie sind ähnlich wie Klassen, haben aber feine Unterschiede. Strukturen werden als leichte Versionen von Klassen verwendet, die helfen können, den Aufwand für die Speicherverwaltung bei der Arbeit mit kleinen Datenstrukturen zu reduzieren. In den meisten Situationen ist die Verwendung einer Standardklasse jedoch die bessere Wahl.

Der wesentliche Unterschied zwischen structs und Klassen besteht darin, dass Instanzen von structs Werte sind, während Instanzen von Klassen Referenzen sind. Wenn Sie also eine Struktur an eine Funktion nach Wert übergeben, erhalten Sie eine Kopie des Objekts, so dass Änderungen daran nicht im Original reflektiert werden, da es jetzt zwei verschiedene Objekte gibt, aber wenn Sie eine Instanz einer Klasse nach Referenz übergeben, dann gibt es nur eine Instanz.

Die folgende Mitarbeiterstruktur deklariert ein öffentliches und ein privates Feld. Der Zugriff auf das private Feld wird über das öffentliche Property Name gewährt:

```csharp
struct Employee
{
    public int m_iAge;
    private string m_strName;

    public string Name
    {
        get { return m_strName; }
        set { m_strName = value; }
    }
}
```

## Strukturkonstrukteure

Strukturen brauchen Konstruktoren - oder besser gesagt Initialisatoren, da sie nicht konstruieren, sondern nur den Speicher initialisieren - damit ihr Inhalt nicht uninitialisiert bleibt. Daher sind Konstrukteure ohne Parameter nicht erlaubt.

Strukturvariablen können einander zugeordnet werden, wenn und nur wenn die Strukturvariable auf der rechten Seite der Zuordnung alle initialisiert sind.

```csharp
struct Timestamp
{
    private ushort m_usYear;
    private ushort m_usMonth;
    private ushort m_usDayOfMonth;
    private ushort m_usHour;
    private ushort m_usMinute;
    private ushort m_usSecond;

    public Timestamp(ushort usYear,
        ushort usMonth,
        ushort usDay,
        ushort usHour,
        ushort usMinute,
        ushort usSecond)
    {
        m_usYear = usYear - 1900;
        m_usMonth = usMonth;
        m_usDay = usDay;
        m_usHour = usHour;
        m_usMinute = usMinute;
        m_usSecond = usSecond;
    }
}
```

## Statische Klassen

Statische Klassen werden häufig verwendet, um ein Singleton-Muster zu implementieren. Alle Methoden, Eigenschaften und Felder einer statischen Klasse sind ebenfalls statisch (wie die Methode WriteLine() der Klasse System.Console) und können somit ohne Instanziierung der statischen Klasse verwendet werden:

```csharp
public static class Writer
{
    public static void Write()
    {
        System.Console.WriteLine("Text");
    }
}

public class Sample
{
    public static void Main()
    {
        Writer.Write();
    }
}
```

Eine Methode einer anderen Klasse kann dann das Ereignis abonnieren, indem sie dem Ereignisdelegierten eine ihrer Methoden hinzufügt:

```csharp
Button b = new Button();
b.ButtonClicked += ButtonClickHandler();
```

Obwohl das Ereignis öffentlich deklariert ist, kann es nirgendwo direkt ausgelöst werden, außer in der Klasse, die es enthält.
