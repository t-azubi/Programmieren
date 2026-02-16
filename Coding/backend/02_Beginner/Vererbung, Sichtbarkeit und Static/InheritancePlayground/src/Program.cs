namespace InheritancePlayground;

internal static class Program
{
    private static void Main()
    {
        List<Tier> tiere =
        [
            new Hund("Bello"),
            new Katze("Minka")
        ];

        foreach (Tier tier in tiere)
        {
            Console.WriteLine(TierTextFormatter.Beschreibe(tier));
            tier.MacheLaut();
            Console.WriteLine();
        }
    }
}

public class Tier
{
    protected string Name { get; }

    public Tier(string name)
    {
        Name = name;
    }

    public virtual void MacheLaut()
    {
        Console.WriteLine("...");
    }

    public string Info() => $"Tier: {Name}";
}

public class Hund : Tier
{
    public Hund(string name) : base(name)
    {
    }

    public override void MacheLaut()
    {
        Console.WriteLine("Wuff!");
    }
}

public class Katze : Tier
{
    public Katze(string name) : base(name)
    {
    }

    public override void MacheLaut()
    {
        Console.WriteLine("Miau!");
    }
}

public static class TierTextFormatter
{
    public static string Beschreibe(Tier tier)
    {
        return $"[Info] {tier.Info()}";
    }
}
