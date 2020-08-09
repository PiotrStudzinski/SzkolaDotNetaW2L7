using System;

namespace Tesk8
{
    class Program
    {
        static void Main(string[] args)
        {
            int maths = 80;
            int physics = 71;
            int chemistry = 0;

            if((maths >= 70 && physics >= 55 && chemistry >= 45) || (maths + physics >= 150) || (maths + chemistry >= 150))
            {
                Console.WriteLine("Kandydat dopuszczony do rekrutacji");
            }
            else
            {
                Console.WriteLine("Kandydat nie jest dopuszczony do rekrutacji");
            }
        }
    }
}
