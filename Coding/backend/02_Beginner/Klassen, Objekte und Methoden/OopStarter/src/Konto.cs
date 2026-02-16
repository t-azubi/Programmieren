namespace OopStarter;

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
        if (betrag <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(betrag), "Betrag muss größer als 0 sein.");
        }

        Guthaben += betrag;
    }

    public bool Abheben(decimal betrag)
    {
        if (betrag <= 0 || betrag > Guthaben)
        {
            return false;
        }

        Guthaben -= betrag;
        return true;
    }

    public string KontostandText() => $"{Besitzer}: {Guthaben:C}";
}
