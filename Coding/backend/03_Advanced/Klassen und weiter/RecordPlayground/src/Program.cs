namespace RecordPlayground;

internal static class Program
{
    private static void Main()
    {
        Ticket bug = new BugTicket
        {
            Id = 101,
            Titel = "Login schlägt fehl",
            Prioritaet = Prioritaet.Hoch,
            Reproduzierbar = true
        };

        Ticket feature = new FeatureTicket
        {
            Id = 202,
            Titel = "Dark Mode",
            Prioritaet = Prioritaet.Mittel,
            StoryPoints = 5
        };

        Ticket bugKopie = bug with { Prioritaet = Prioritaet.Kritisch };

        Console.WriteLine(Beschreibe(bug));
        Console.WriteLine(Beschreibe(feature));
        Console.WriteLine(Beschreibe(bugKopie));
    }

    private static string Beschreibe(Ticket ticket) =>
        ticket switch
        {
            BugTicket { Reproduzierbar: true } bug => $"BUG #{bug.Id} [{bug.Prioritaet}] {bug.Titel} (reproduzierbar)",
            BugTicket bug => $"BUG #{bug.Id} [{bug.Prioritaet}] {bug.Titel}",
            FeatureTicket feature => $"FEATURE #{feature.Id} [{feature.Prioritaet}] {feature.Titel} ({feature.StoryPoints} SP)",
            _ => $"TICKET #{ticket.Id} [{ticket.Prioritaet}] {ticket.Titel}"
        };
}

public enum Prioritaet
{
    Niedrig,
    Mittel,
    Hoch,
    Kritisch
}

public abstract record Ticket
{
    public required int Id { get; init; }
    public required string Titel { get; init; }
    public required Prioritaet Prioritaet { get; init; }
}

public sealed record BugTicket : Ticket
{
    public required bool Reproduzierbar { get; init; }
}

public sealed record FeatureTicket : Ticket
{
    public required int StoryPoints { get; init; }
}
