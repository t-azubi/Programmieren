# Arrays, Listen und Enums

Diese drei Konzepte brauchst du ständig in realen Anwendungen.

## Arrays

Feste Größe, schneller Zugriff per Index.

```csharp
int[] zahlen = [4, 8, 15, 16, 23, 42];
Console.WriteLine(zahlen[0]);
```

## Listen

Flexible Größe und viele Hilfsmethoden.

```csharp
List<string> namen = ["Ada", "Linus"];
namen.Add("Grace");
```

## Enums

Sinnvolle, benannte Zustände statt „magischer Zahlen“.

```csharp
enum Schwierigkeit
{
    Easy,
    Medium,
    Hard
}
```

## Beispielprojekt

`CollectionsDemo` zeigt Array, List und Enum in einem kleinen CLI-Beispiel.

## Übungen

1. Speichere 5 Zahlen in einem Array und berechne die Summe.
2. Baue eine Einkaufsliste mit `List<string>`.
3. Nutze ein Enum für einen Status (`Open`, `InProgress`, `Done`).
