# Klassen und weiter

In diesem Kapitel geht es um moderne C#-Features, die Klassenmodellierung vereinfachen.

## Themen

- Records
- `init`-Properties
- Pattern Matching
- `required`-Member

## Mini-Beispiel

```csharp
public record Person(string Name, int Age);

Person p = new("Alex", 30);
Console.WriteLine(p with { Age = 31 });
```

## Übung

Baue ein kleines Modell für ein Ticketsystem (`Ticket`, `BugTicket`, `FeatureTicket`) und nutze Pattern Matching für die Ausgabe.
