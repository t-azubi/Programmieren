# Vererbung, Sichtbarkeit und static

## Vererbung

Mit Vererbung kannst du gemeinsames Verhalten in einer Basisklasse bündeln.

```csharp
public class Tier
{
    public string Name { get; set; } = string.Empty;
    public virtual void Laut() => Console.WriteLine("...");
}

public class Hund : Tier
{
    public override void Laut() => Console.WriteLine("Wuff");
}
```

## Sichtbarkeiten

- `public`: überall sichtbar
- `private`: nur in der eigenen Klasse
- `protected`: in Klasse + abgeleiteten Klassen
- `internal`: im selben Projekt

## `static`

`static` nutzt du für Funktionen ohne Objektzustand (z. B. Hilfsfunktionen).

```csharp
public static class MatheHelper
{
    public static int Quadrat(int x) => x * x;
}
```

Tipp: Nutze `static`, wenn keine Instanzdaten gebraucht werden.
