using System;

namespace CondicionLogicaIf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre = "Pepito";
            decimal sueldo = 55355;

            // Sueldo minimo de Chile es 553.553 clp
            if (sueldo == 553553)
            {
                Console.WriteLine(nombre + " el sueldo que tienes es el minimo en Chile.");
            } else if (sueldo < 553553)
            {
                Console.WriteLine(nombre + " el sueldo que tienes es menor al minimo en Chile. Hay que robar >:c");
            } else
            {
                Console.WriteLine(nombre + " el sueldo que tienes es mayor al minimo en Chile.");
            }

            Console.ReadKey();
        }
    }
}