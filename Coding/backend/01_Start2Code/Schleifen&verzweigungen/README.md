# Schleifen und Verzweigungen

Kontrollstrukturen entscheiden, wie oft Code läuft und welcher Pfad ausgeführt wird.

## Schleifen

### `for`

Ideal, wenn die Anzahl der Wiederholungen bekannt ist.

```csharp
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i);
}
```

### `while`

Läuft, solange eine Bedingung `true` ist.

```csharp
int counter = 0;
while (counter < 3)
{
    Console.WriteLine(counter);
    counter++;
}
```

### `foreach`

Läuft über alle Elemente einer Sammlung.

```csharp
string[] namen = ["Alex", "Kim", "Sam"];
foreach (string name in namen)
{
    Console.WriteLine(name);
}
```

## Verzweigungen

### `if / else`

```csharp
if (temperatur < 20)
{
    Console.WriteLine("Jacke anziehen");
}
else
{
    Console.WriteLine("T-Shirt reicht");
}
```

### `switch`

```csharp
switch (tag)
{
    case 6:
    case 7:
        Console.WriteLine("Wochenende");
        break;
    default:
        Console.WriteLine("Arbeitstag");
        break;
}
```

## Beispielprojekte

- `Schleifen und Verzweigungen` – klassisches Zahlenraten
- `Schleifen und Verzweigungen 2` – Zahlenraten mit Schwierigkeitsstufen