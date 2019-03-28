using System;
using System.Collections.Generic;
using System.Threading;

namespace Variablen_Ver._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string Zeichenkette;
            int Ganzzahl = 0;
            bool Wahrheitswert = false;
            double GebrocheneZahl= 0;
            char Zeichen = 'a';

            Console.WriteLine("Hallo ich sehen du möchtest etwas über Variablen und Datentypen lernen.");
            Console.Write("Stimmt das ? Y/N:");
            Zeichenkette = Console.ReadLine();
            if (Zeichenkette == "Y" || Zeichenkette == "y")
            {
                Wahrheitswert = true;
                Console.WriteLine("Coole Sache :)");
                Console.WriteLine("Schau mal die ersten beiden Variablen und Datentypen haben wir verwendet.");
                Console.WriteLine("Mit dem String welcher eine Zeichenkette darstellt, haben wir deine Eingabe uns angeschaut und da du Y/y eingegeben hast, ist der bool oder Wahrheitswert true/ wahr geworden.");
                Thread.Sleep(1000);
                Console.Write("So lass uns doch mal was ausrechnen 7,5 + welche Ganzzahl? :");
                Ganzzahl = Convert.ToInt16(Console.ReadLine());
                GebrocheneZahl = 7.5 + Ganzzahl;
                Console.WriteLine("Mal sehen 7,5 + " + Ganzzahl.ToString()+" = " + GebrocheneZahl.ToString());
                Console.WriteLine("Also ich wüde sagen, dass das richtig ist oder?");
                Thread.Sleep(1000);
                Console.WriteLine("Ok damit haben wir wieder 2 weiter Datentypen abgearbeitet.");
                Console.WriteLine("Also was haben wir gemacht? Wir haben einen Integer oder ganzzahl mit einem Double also einer Gebrochenen Zahl/ Gleitkommazahl zusammen gerechnet.");
                Console.WriteLine("Ich hoffe das dir der keine Einblick geholfen hat :)");
                Thread.Sleep(1000);
            }
            else
            {
                Console.WriteLine("Ok dann wünsche ich dir einen schönen Tag :)");
                Thread.Sleep(2000);
            }
        }
    }
}
