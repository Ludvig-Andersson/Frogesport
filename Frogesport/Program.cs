using System;

namespace Frogesport
{
    class Program
    {
        static void Main(string[] args)
        {
            int points = 0;
            int health = 5;

            System.Console.WriteLine("Vill du börja Frågesporten? (ja eller nej)");

            String fråga1 = Console.ReadLine();

            if (fråga1 == "ja")
            {
                Console.WriteLine("Då startar vi!!");

            }

            else
            {

            }

            Console.WriteLine("Vad heter du?");
            System.Console.WriteLine("A. Herbert");
            System.Console.WriteLine("B. Albertina");
            System.Console.WriteLine("C. Ludvig");

            string svar1 = Console.ReadLine();

            if (svar1 == "C")
            {

                points++;
                System.Console.WriteLine("Grattis du hade rätt");
            }

            else
            {
                health = health - 1;
                System.Console.WriteLine("Det var fel!");

            }

            Console.ReadLine();

        }
    }
}
