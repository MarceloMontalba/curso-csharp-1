using System;

namespace OperadoresLogicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            bool r1, r2, r3, r4;

            a = 10;
            b = 3;
            c = 67;
            d = 90;

            r1 = a > b;
            r2 = d < c;
            r3 = (c == d) || (a > b);
            r4 = (c == d) && (a>b);

            Console.WriteLine("El resultado de a > b: "+r1);
            Console.WriteLine("El resultado de d < c: " + r2);
            Console.WriteLine("El resultado de (c == d) || (a > b): " + r3);
            Console.WriteLine("El resultado de (c == d) && (a>b): " + r4);

        }
    }
}
