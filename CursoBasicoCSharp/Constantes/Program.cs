using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constantes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            int edad;
            const double sueldo = 2500;

            nombre = "Marcelo";
            edad = 28;
            edad += edad;

            dynamic variableDinamica = 10;
            variableDinamica = "Pepito";
            variableDinamica = 231.3421;

            Console.WriteLine("Nombre: "+nombre+ "; Edad: "+edad+ "; Sueldo: "+sueldo);
            Console.WriteLine("Variable Dinamica: "+ variableDinamica);
        }
    }
}
