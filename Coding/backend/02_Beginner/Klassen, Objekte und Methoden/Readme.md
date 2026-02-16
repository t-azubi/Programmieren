# Klassen, Objekte und Methoden

Dieses Thema ist dein Einstieg in OOP mit C#.

## Kernideen

- Klasse = Bauplan
- Objekt = konkrete Instanz einer Klasse
- Methode = Verhalten einer Klasse

## Mini-Beispiel

```csharp
public class Konto
{
    public string Besitzer { get; }
    public decimal Guthaben { get; private set; }

    public Konto(string besitzer)
    {
        Besitzer = besitzer;
    }

    public void Einzahlen(decimal betrag)
    {
        Guthaben += betrag;
    }
}
```

## Wichtige Begriffe

- `public`, `private`, `protected`
- Konstruktoren
- Instanzmethoden vs. `static`

## Beispielprojekt

Im Projekt `OopStarter` findest du ein kleines Konto-Beispiel mit mehreren Methoden.

## Übungen

1. Erweitere das Konto um `Abheben()` mit Prüfung auf negatives Guthaben.
2. Füge eine Methode hinzu, die den Kontostand formatiert ausgibt.

### Objekteigenschaften

Objekteigenschaften (oder auch nur Eigenschaften) sind „bessere“ Variablen, hinter welchen ein Programmcode hinterlegt werden kann (also wie bei Funktionen). Eigenschaften sehen von der Deklaration ähnlich wie Variablen aus, bilden jedoch immer einen Block.

Bei einfachen Eigenschaften (ohne Werte-Prüfung oder anderen Programmcode) müssen innerhalb des Blocks die Schlüsselwörter get und set mit jeweils einem Semikolon am Ende notiert werden. Dadurch entspricht die Eigenschaft eigentlich einer Variablen. Trotzdem sollten Sie immer Eigenschaften anstatt Variablen verwenden, wenn der Wert von „außen“ (also von außerhalb der Klasse) zugänglich sein soll.

Die komplexeren Eigenschaften besitzen einen Programmcode, welche zur Überprüfung des Wertes genutzt werden kann. Natürlich könnten auch andere Aktionen ausgeführt werden, wie z. B. der Aufruf einer internen Funktion o. Ä.. Bei den komplexeren Eigenschaften bilden die get- und set-Schlüsselwörter eigene Blöcke. Innerhalb des get-Blocks muss ein Wert durch return zurückgegeben werden. Im set-Block dagegen kann der Wert z. B. in einer internen Variablen gespeichert werden. Um auf den „übergebenen“ oder zu setzenden Wert zuzugreifen, nutzen wir das Schlüsselwort value. Wie wir also sehen können, ist bei den komplexeren Eigenschaften immer eine interne Variable von Nöten, wenn der Wert intern gespeichert werden soll. Der Variablenname besteht dabei oft aus einem Unterstrich und dem Eigenschaftsnamen.

Stellen wir uns einmal vor, was wir mit solchen Eigenschaften alles machen können und wie wir diese adaptieren können. Es ist z. B. möglich, den set-Block wegzulassen: Dadurch können wir das Setzen eines Wertes unterbinden. Um das Setzen innerhalb der Klasse zuzulassen, jedoch von außen zu unterbinden.
