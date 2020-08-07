using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj liczbę całkowitą: ");
            int intNumber = int.Parse(Console.ReadLine());

            Console.WriteLine();

            if ((intNumber % 2) != 0)
            {
                Console.WriteLine($"{intNumber} jest liczbą nieparzystą");
            }
            else
            {
                Console.WriteLine($"{intNumber} jest liczbą parzystą");
            }
        }
    }
}
