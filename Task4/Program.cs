using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj rok:");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine();

            if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
            {
                Console.WriteLine($"{year} jest rokiem przestępnym.");
            }
            else
            {
                Console.WriteLine($"{year} nie jest rokiem przestępnym.");
            }
        }
    }
}
