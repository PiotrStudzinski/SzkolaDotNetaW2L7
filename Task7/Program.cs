using System;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj pierwszą liczbę: ");
            int numOne = int.Parse(Console.ReadLine());

            Console.Write("Podaj drugą liczbę: ");
            int numTwo = int.Parse(Console.ReadLine());

            Console.Write("Podaj trzecią liczbę: ");
            int numThree = int.Parse(Console.ReadLine());

            if (numOne > numTwo && numOne > numThree)
            {
                Console.WriteLine($"{numOne} jest największą liczbą z podanych");
            }
            else if (numTwo > numOne && numTwo > numThree)
            {
                Console.WriteLine($"{numTwo} jest największą liczbą z podanych");
            }
            else
            {
                Console.WriteLine($"{numThree} jest największą liczbą z podanych");
            }
        }
    }
}
