using System;

namespace Schleifen_und_Verzweigungen
{
    class Program
    {
        private static object math;

        static void Main(string[] args)
        {
            Console.WriteLine("So nun da wir ein Grundgerüst haben, lass uns doch versuchen unser Zahlenraten auszubauen.");
            Console.Write("Bitte Wähle eine Schwierigkeitsstufe aus. 1(einfach Zahlen von 1 bis 100) | 2 (medium Zahlen von 1 bis 1000) | 3(hard Zahlen von 1 bis 5000 | 4(godlike Zahlen von 1 bis 10000))");
            
            Zahlenraten(GetDifficulty());


        }
        public static int GetDifficulty()
        {
            bool input = int.TryParse(Console.ReadLine(), out int dif);
            while (!input)
            {
                Console.Write("Bitte gebe eine Gültige Schwierigkeitsstufe ein:");
                    input = int.TryParse(Console.ReadLine(), out dif);
            }
            switch (dif)
            {
                case 1:
                    return 100;
                case 2:
                    return 1000;
                case 3:
                    return 5000;
                case 4:
                    return 10000;
                default:
                    return 12;
            }
            
        }
        public static void Zahlenraten(int Dif)
        {

            Console.Write("Ok dann dein erster versuch:");
            int guesses = 0;
            int guess = 0;
            int mynumber = new Random().Next(1,Dif);
            bool checkinput = false;

            bool right = false;
            while (!right)
            {
                checkinput = int.TryParse(Console.ReadLine(), out guess);
                if (!checkinput)
                {
                    Console.WriteLine("Gib doch bitte eine Zahl ein :)");
                    continue;
                }
                guesses++;
                if (guess > mynumber)
                {
                    Console.WriteLine("Deine Zahl ist zu groß");
                    continue;
                }
                if (guess < mynumber)
                {
                    Console.WriteLine("Deine Zahl ist zu klein");
                    continue;
                }
                if (guess == mynumber)
                {
                    Console.WriteLine(SetWinningMessage(Dif,guesses));
                      right = true;
                }
            }
         }
        public static string SetWinningMessage(int dif, int guesses)
        {
            string message = string.Empty;
            var Playerstat = (guesses * guesses) / (dif / Math.Pow(guesses, 0.6));
            if (Playerstat < 0.5)
            {
                message = "Du bist richtig gut :)";
            }
            if (Playerstat < 1 && Playerstat > 0.5)
            {
                message = "Das wird doch :)";
            }
            if (Playerstat > 1)
            {
                message = "Das war aber jetzt nicht so gut";
            }

            return message;
        }
    }
}
