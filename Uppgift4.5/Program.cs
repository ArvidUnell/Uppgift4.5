using System;
namespace Uppgift4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett heltal");
            string tal = Console.ReadLine();

            string svar = "";           

            for (int i = 0;i < tal.Length;i++)
            {
                byte siffra = byte.Parse(tal[i].ToString());

                if (siffra == 9)
                {
                    siffra = 0;
                }
                else
                {
                    siffra += 1;
                }

                svar += siffra;
            }

            Console.WriteLine(svar);

            Console.WriteLine("Tryck på en valfri knapp för att avsluta");
            Console.ReadKey();
        }
    }
}