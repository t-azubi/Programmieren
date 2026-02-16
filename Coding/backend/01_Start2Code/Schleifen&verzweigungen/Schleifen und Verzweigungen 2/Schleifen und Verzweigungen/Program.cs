using System;

namespace Schleifen_und_Verzweigungen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zahlenraten mit Schwierigkeit");
            Console.WriteLine("1 = 1..100 | 2 = 1..1000 | 3 = 1..5000 | 4 = 1..10000");
            int maxWert = GetDifficulty();
            Zahlenraten(maxWert);
        }

        public static int GetDifficulty()
        {
            while (true)
            {
                Console.Write("Schwierigkeit wählen (1-4): ");
                if (!int.TryParse(Console.ReadLine(), out int schwierigkeit))
                {
                    Console.WriteLine("Bitte eine Zahl eingeben.");
                    continue;
                }

                return schwierigkeit switch
                {
                    1 => 100,
                    2 => 1000,
                    3 => 5000,
                    4 => 10000,
                    _ => 100
                };
            }
        }

        public static void Zahlenraten(int Dif)
        {
            Console.WriteLine($"Ich denke mir eine Zahl zwischen 1 und {Dif}.");
            int geheimzahl = new Random().Next(1, Dif + 1);
            int versuche = 0;

            while (true)
            {
                Console.Write("Dein Tipp: ");
                if (!int.TryParse(Console.ReadLine(), out int tipp))
                {
                    Console.WriteLine("Bitte eine gültige Zahl eingeben.");
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

                Console.WriteLine($"Treffer nach {versuche} Versuchen.");
                Console.WriteLine(SetWinningMessage(Dif, versuche));
                break;
            }
         }

        public static string SetWinningMessage(int dif, int guesses)
        {
            double score = guesses / Math.Sqrt(dif);

            if (score < 0.9)
            {
                return "Sehr stark gespielt!";
            }

            if (score < 1.5)
            {
                return "Gute Runde!";
            }

            return "Da geht noch was – probier es nochmal.";
        }
    }
}
