using System;
using System.CodeDom.Compiler;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj ocenę: ");
            int schoolGrade = int.Parse(Console.ReadLine());

            switch(schoolGrade)
            {
                case 1:
                    Console.WriteLine("Niedostateczny");
                    break;
                case 2:
                    Console.WriteLine("Dopuszczający");
                    break;
                case 3:
                    Console.WriteLine("Dostateczny");
                    break;
                case 4:
                    Console.WriteLine("Dobry");
                    break;
                case 5:
                    Console.WriteLine("Bardzo dobry");
                    break;
                case 6:
                    Console.WriteLine("Celujący");
                    break;
                default:
                    Console.WriteLine("Nie ma takiej oceny");
                    break;
            }
        }
    }
}
