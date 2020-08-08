using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj dowolną liczbę: ");
            double number = double.Parse(Console.ReadLine());

            Console.WriteLine();

            if (number > 0)
            {
                Console.WriteLine("Podana liczba jest liczbą dodatnią.");
            }
            else if (number < 0)
            {
                Console.WriteLine("Podana liczba jest liczbą ujemną.");
            }
            else
            {
                Console.WriteLine("Podana liczba zerem.");
            }
        }
    }
}
