using System;

namespace EstructuraFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Ingrese la tabla a revelar: ");
            n= int.Parse(Console.ReadLine());

            for (int x = 1; x <= 12; x++)
            {
                Console.WriteLine(n+ " X "+x+" = "+(n*x));
            }

            Console.ReadKey();
        }
    }
}
