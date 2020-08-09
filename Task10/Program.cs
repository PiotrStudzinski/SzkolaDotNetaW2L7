using System;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            int sideOne =40;
            int sideTwo = 55;
            int sideThree = 65;

            if(((sideOne + sideTwo) > sideThree) && ((sideOne + sideThree) > sideTwo) && ((sideTwo + sideThree) > sideOne))
            {
                Console.WriteLine("Można zbudować trójkąt");
            }
            else
            {
                Console.WriteLine("Nie można zbudować trójkąta");
            }
        }
    }
}
