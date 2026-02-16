using System;
using System.Collections.Generic;

namespace CollectionsDemo;

internal static class Program
{
    private enum Status
    {
        Open,
        InProgress,
        Done
    }

    private static void Main()
    {
        int[] zahlen = [4, 8, 15, 16, 23, 42];
        int summe = 0;

        foreach (int zahl in zahlen)
        {
            summe += zahl;
        }

        List<string> einkauf = ["Milch", "Brot"];
        einkauf.Add("Äpfel");

        Status aufgabeStatus = Status.InProgress;

        Console.WriteLine($"Array-Summe: {summe}");
        Console.WriteLine("Einkaufsliste:");

        foreach (string eintrag in einkauf)
        {
            Console.WriteLine($"- {eintrag}");
        }

        Console.WriteLine($"Status: {aufgabeStatus}");
    }
}
