using System;

namespace EstructuraDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 41;
            do
            {
                Console.WriteLine("La variable es igual a: "+n);
                n++;
            } while (n < 44);
        }
    }
}
