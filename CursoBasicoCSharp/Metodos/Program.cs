using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tabla;

            bool bandera = true;
            do {
                try
                {
                    Console.WriteLine("=========================================================================");
                    Console.Write("Ingrese la tabla deseada: ");
                    tabla = int.Parse(Console.ReadLine());
                    Console.WriteLine("=========================================================================");

                    MostrarTabla(tabla);
                    bandera = false;
                } catch(Exception e)
                {
                    Console.WriteLine("El tipo de datos ingresado no es valido. Vuelve a intentarlo...");
                }
            } while (bandera == true);
        }

        static void MostrarTabla(int numero)
        {
            for (int i=1; i<13; i++)
            {
                Console.WriteLine(numero+ " X "+ i +" = "+(numero*i));
            }
        }
    }
}
