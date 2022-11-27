using System;

namespace XO
{
    class Swap
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c;

            c = a;
            a = b;
            b = c;

            Console.WriteLine("A = " + a);
            Console.WriteLine("B = " + b);
        }
    }
}