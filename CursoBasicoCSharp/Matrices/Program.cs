using System;

namespace Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] nombres = new string[4, 2];

            nombres[0, 0] = "Marcelo";
            nombres[0, 1] = "Montalba";

            nombres[1, 0] = "Elsa";
            nombres[1, 1] = "Pato";

            nombres[2, 0] = "Elvis";
            nombres[2, 1] = "Tec";

            nombres[3, 0] = "Waldo";
            nombres[3, 1] = "Salinas";

            for (int i = 0; i < nombres.GetLength(0); i++)
            {
                Console.WriteLine("El nombre que tengo en la fila " + i + " es el de " + nombres[i, 0] + " " + nombres[i, 1]);
            }

            Console.ReadKey();
        }
    }
}
