using System;

namespace Schleifen_und_Verzweigungen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey, hier möchte ich zeigen, wie man mit Schleifen und Verzweigungen umgehen kann");
            Console.WriteLine("Dafür lass uns doch ein Spielen. Wie wäre es mit Zahlenraten, ich denke mir eine Zahl von 1 bis 100 aus und du musst sie erraten :)");
            Console.Write("Ok dann dein erster versuch:");
            Zahlenraten();


        }

        public static void Zahlenraten()
        {
            int guesses = 0;
            int guess = 0;
            int mynumber = new Random().Next(1,101);
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
                    Console.WriteLine($"Coole Sache, du hast es geschafft meine Zahl {mynumber} in nur {guesses} Versuchen zu erraten");
                    right = true;
                }
            }
         }
    }
}
