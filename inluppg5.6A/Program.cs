using System;

namespace inluppg5_6A
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in en multiplikation");

            string input = Console.ReadLine();
            string[] calculation = input.Split('*');

            bool 
            foreach (string s in calculation)
            {
                if (s.Length > 4)
                {
                    Console.WriteLine(s + " är för långt. Det får inte vara mer än 4 siffror");
                    break;
                }
            }
            int produkt = 1;
            for (int i = 0; i < calculation.Length; i++)
            {
                produkt = produkt * int.Parse(calculation[i]);
            }
            Console.WriteLine("Produkten är " + produkt);

        }
    }
}