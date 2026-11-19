using System;

namespace HolaMundo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Mundo!");

            Console.Write("Este texto no hara un ");
            Console.Write("salto con este otro.");

            Console.WriteLine();
            Console.WriteLine(3+1);
            Console.WriteLine(23/2);
            Console.WriteLine(23%2);
            Console.WriteLine(45-20);
            Console.WriteLine(40+4);
            
            Console.ReadKey();
        }
    }
}
