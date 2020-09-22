using System;

namespace Frogesport
{
    class Program
    {
        static void Main(string[] args)
        {

            int health = 3;

            System.Console.WriteLine("Vill du börja Frågesporten? (ja eller nej)");

            String fråga1 = Console.ReadLine();

            if (fråga1 == "ja")
            {
                Console.WriteLine("Då startar vi!!");
                Console.Clear();

            }

            else
            {
                System.Console.WriteLine("Stäng ner skiten då!!");
            }
            Console.WriteLine("health:" + health);
            Console.WriteLine("Vad heter du?");
            System.Console.WriteLine("a. Herbert");
            System.Console.WriteLine("b. Albertina");
            System.Console.WriteLine("c. Ludvig");

            string svar1 = Console.ReadLine();

            if (svar1 == "c")
            {

                System.Console.WriteLine("Grattis du hade rätt");
                Console.ReadLine();
            }

            else
            {
                health = health - 1;

                System.Console.WriteLine("Det var fel!");
                Console.ReadLine();

            }
            Console.Clear();
            Console.WriteLine("health:" + health);
            Console.WriteLine("Vad är världens farligaste djur?");
            System.Console.WriteLine("a. Flodhäst");
            System.Console.WriteLine("b. Lejon");
            System.Console.WriteLine("c. Elefant");

            string svar2 = Console.ReadLine();

            if (svar2 == "a")
            {


                System.Console.WriteLine("Grattis du hade rätt");
                Console.ReadLine();
            }

            else
            {
                health = health - 1;

                System.Console.WriteLine("Det var fel!");
                Console.ReadLine();
            }

            Console.Clear();
            Console.WriteLine("health:" + health);
            Console.WriteLine("Om man gräver ett 6 meter djupt hål, hur djupt är hålet?");
            System.Console.WriteLine("a. 20 meter");
            System.Console.WriteLine("b. 35 meter");
            System.Console.WriteLine("c. 6 meter");

            string svar3 = Console.ReadLine();

            if (svar3 == "c")
            {


                System.Console.WriteLine("Grattis du hade rätt");
                Console.ReadLine();
            }

            else
            {
                health = health - 1;

                System.Console.WriteLine("Det var fel!");
                Console.ReadLine();
            }

            if (health == 0)
            {
                Console.Clear();
                System.Console.WriteLine("Ajj du förlorade, bättre lycka nästa gång!!");
                Console.ReadLine();
            }

            else
            {
                Console.Clear();
                System.Console.WriteLine("Snyggt du vann och hade (" + health + ") health kvar!!");
                Console.ReadLine();
            }

            Console.ReadLine();

        }
    }
}
