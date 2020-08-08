using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj swój wzrost: ");
            float height = float.Parse(Console.ReadLine());

            Console.WriteLine();
            if(height < 10)
            {
                Console.WriteLine("Jesteś Krasnoludkiem.");
            }
            else if ((height >= 10) && (height < 20))
            {
                Console.WriteLine("Jesteś Smerfem i jesteś niebieski.");
            }
            else if ((height >= 20) && (height < 100))
            {
                Console.WriteLine("Jesteś Chochlikiem i jesteś złośliwy z natury. :)");
            }
            else if ((height >= 100) && (height < 150))
            {
                Console.WriteLine("Jesteś Krasnoludem");
            }
            else if ((height >= 150) && (height < 180))
            {
                Console.WriteLine("Jesteś Marudus pospolitus");
            }
            else if ((height >= 180) && (height < 240))
            {
                Console.WriteLine("Jesteś Olbrzymem");
            }
            else
            {
                Console.WriteLine("Jesteś Gigantem");
            }
        }
    }
}
