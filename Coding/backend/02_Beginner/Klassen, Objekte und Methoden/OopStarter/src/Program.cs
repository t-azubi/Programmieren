namespace OopStarter;

internal static class Program
{
    private static void Main()
    {
        Konto konto = new("Dominik");

        konto.Einzahlen(100m);
        konto.Einzahlen(35.50m);

        bool erfolg = konto.Abheben(50m);

        Console.WriteLine(konto.KontostandText());
        Console.WriteLine(erfolg
            ? "Abhebung erfolgreich."
            : "Abhebung fehlgeschlagen.");
    }
}
