using System;

namespace Schleifen_und_Verzweigungen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zahlenraten (1 bis 100)");
            Console.WriteLine("Ich habe mir eine Zahl ausgedacht. Versuche sie zu erraten.");
            Zahlenraten();
        }

        public static void Zahlenraten()
        {
            int versuche = 0;
            int geheimzahl = new Random().Next(1, 101);

            while (true)
            {
                Console.Write("Dein Tipp: ");
                if (!int.TryParse(Console.ReadLine(), out int tipp))
                {
                    Console.WriteLine("Bitte gib eine gültige Zahl ein.");
                    continue;
                }

                versuche++;

                if (tipp > geheimzahl)
                {
                    Console.WriteLine("Zu groß.");
                    continue;
                }

                if (tipp < geheimzahl)
                {
                    Console.WriteLine("Zu klein.");
                    continue;
                }

                Console.WriteLine($"Treffer! Die Zahl war {geheimzahl}. Versuche: {versuche}");
                break;
            }
         }
    }
}
