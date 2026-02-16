# Variablen und Datentypen

Hier lernst du, wie Werte in C# gespeichert und verarbeitet werden.

## Variablen

Eine Variable ist ein benannter Speicherplatz.

```csharp
string name = "Dominik";
int alter = 20;
bool istAktiv = true;
```

## Wichtige Datentypen

- `int` für ganze Zahlen
- `double` für Kommazahlen
- `bool` für `true`/`false`
- `char` für ein Zeichen
- `string` für Text

## Typumwandlung

Eingaben aus der Konsole kommen als `string` und müssen oft umgewandelt werden:

```csharp
if (int.TryParse(Console.ReadLine(), out int zahl))
{
    Console.WriteLine($"Du hast {zahl} eingegeben.");
}
```

## Beispielprojekt

Im Projekt `Variablen Ver.1/src` findest du ein ausführbares Beispiel mit Eingabe, Berechnung und Ausgabe.

## Übungen

1. Lies zwei Zahlen ein und gib Summe + Durchschnitt aus.
2. Lies einen Namen ein und gib eine personalisierte Begrüßung aus.
3. Prüfe, ob eine Zahl gerade oder ungerade ist.
