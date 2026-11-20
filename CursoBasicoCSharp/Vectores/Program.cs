using System;

namespace Vectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = {"Carlos", "Pedro", "Arturo", "Juan", "Bodoque"};

            for (int i=0; i<nombres.Length; i++){
                Console.WriteLine("Ahora tengo el nombre de " + nombres[i]+" en la posición "+i+".");
            }

            Console.ReadKey();
        }
    }
}
