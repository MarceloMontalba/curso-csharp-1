using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionTipoDeDatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad;
            string nombre;
            double sueldo;
            bool estaCasado;

            Console.Write("Nombre: ");
            //nombre = Console.ReadLine();
            nombre = Console.ReadLine();

            Console.Write("Edad: ");
            //edad = Convert.ToInt32(Console.ReadLine());
            edad = int.Parse(Console.ReadLine());

            Console.Write("Sueldo: ");
            //sueldo = Convert.ToDouble(Console.ReadLine());
            sueldo = double.Parse(Console.ReadLine());

            Console.Write("Es Casado: ");
            //estaCasado = Convert.ToBoolean(Console.ReadLine());
            estaCasado = bool.Parse(Console.ReadLine());

            Console.WriteLine("========================================================");
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Sueldo: " + sueldo);
            Console.WriteLine("Es Casado: " + estaCasado);
            Console.WriteLine("========================================================");

            Console.ReadKey();
        }
    }
}
