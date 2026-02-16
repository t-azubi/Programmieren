using System;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hallo Welt!");
            Console.Write("Wie heißt du? ");
            string name = Console.ReadLine() ?? "Unbekannt";
            Console.WriteLine($"Willkommen, {name}!");
        }
    }
}
