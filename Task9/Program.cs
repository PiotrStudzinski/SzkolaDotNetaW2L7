using System;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj aktualną temperaturę: ");
            int temperature = int.Parse(Console.ReadLine());

            Console.WriteLine();

            if (temperature < 0)
            {
                Console.WriteLine("cholernie piździ");
            }
            else if (temperature >= 0 && temperature < 10)
            {
                Console.WriteLine("zimno");
            }
            else if (temperature >= 10 && temperature < 20)
            {
                Console.WriteLine("chłodno");
            }
            else if (temperature >= 20 && temperature < 30)
            {
                Console.WriteLine("w sam raz");
            }
            else if (temperature >= 30 && temperature < 40)
            {
                Console.WriteLine("w sam raz");
            }
            else
            {
                Console.WriteLine("a weź wyprowadzam się na Alaskę");
            }
        }
    }
}
