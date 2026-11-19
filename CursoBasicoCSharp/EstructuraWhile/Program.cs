using System;

namespace EstructuraWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = 1;

            Console.WriteLine("===================================");
            Console.WriteLine("TABLA DEL 5");
            Console.WriteLine("===================================");
            while (n <= 12)
            {
                Console.WriteLine("5 X "+n+" = "+(5*n));
                n++;
            }
        }
    }
}
