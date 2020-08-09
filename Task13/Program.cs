using System;

namespace Task13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj pierwszą liczbę: ");
            float numFirst = float.Parse(Console.ReadLine());

            Console.Write("Podaj drugą liczbę: ");
            float numSecond = float.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Menu");
            Console.WriteLine("--------------");
            Console.WriteLine("1. Dodawanie");
            Console.WriteLine("2. Odejmowanie");
            Console.WriteLine("3. Mnożenie");
            Console.WriteLine("4. Dzielenie");

            Console.WriteLine();

            Console.Write("Podaj numer operacji do wykonania: ");
            int menu = int.Parse(Console.ReadLine());

            float result = 0;

            switch (menu)
            {
                case 1:
                    result = numFirst + numSecond;
                    break;
                case 2:
                    result = numFirst - numSecond;
                    break;
                case 3:
                    result = numFirst * numSecond;
                    break;
                case 4:
                    result = numFirst / numSecond;
                    break;
            }

            Console.WriteLine();

            Console.Write($"Twój wynik to: {result}.");
        }
    }
}
