using System;

namespace Variablen_Ver._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Willkommen zum Variablen- und Datentypen-Beispiel.");

            string name = "Dominik";
            int alter = 21;
            double lieblingszahl = 7.5;
            bool istNeugierig = true;

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Alter: {alter}");
            Console.WriteLine($"Lieblingszahl: {lieblingszahl}");
            Console.WriteLine($"Neugierig: {istNeugierig}");

            Console.Write("Bitte gib eine ganze Zahl ein: ");
            if (int.TryParse(Console.ReadLine(), out int eingabe))
            {
                double ergebnis = lieblingszahl + eingabe;
                Console.WriteLine($"{lieblingszahl} + {eingabe} = {ergebnis}");
            }
            else
            {
                Console.WriteLine("Das war keine gültige ganze Zahl.");
            }
        }
    }
}
