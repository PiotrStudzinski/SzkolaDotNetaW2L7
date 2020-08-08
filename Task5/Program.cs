using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj swój wiek: ");
            byte age = byte.Parse(Console.ReadLine());

            Console.WriteLine();

            // nie znalazłem informacji o minimalnym wieku na premiera :)
            if (age >= 21)
            {
                Console.WriteLine("Możesz zostać posłem.");

                if (age >= 30)
                {
                    Console.WriteLine("lub też");
                    Console.WriteLine("Możesz zostać senatorem.");
                    
                    if (age >= 35)
                    {
                        Console.WriteLine("lub też");
                        Console.WriteLine("Możesz zostać prezydentem.");
                    }
                }
            }
            else if ((age < 21) && (age >= 18))
            {
                Console.WriteLine("Możesz już głosować, ale nie możesz zostać posłem, premierem, senatorem i prezydentem.");
            }
            else
            {
                Console.WriteLine("Nie możesz głosować i nie możesz zostać posłem, premierem, senatorem i prezydentem.");
            }
        }
    }
}
