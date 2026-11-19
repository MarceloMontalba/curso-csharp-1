using System;

namespace CondicionLogicaSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dia;
            Console.Write("Ingrese un número de día de la semana: ");
            dia = int.Parse(Console.ReadLine());

            switch(dia){
                case 1:
                    Console.WriteLine("El día ingresado es Lunes.");
                    break;
                case 2:
                    Console.WriteLine("El día ingresado es Martes.");
                    break;
                case 3:
                    Console.WriteLine("El día ingresado es Miercoles.");
                    break;
                case 4:
                    Console.WriteLine("El día ingresado es Jueves.");
                    break;
                case 5:
                    Console.WriteLine("El día ingresado es Viernes.");
                    break;
                case 6:
                    Console.WriteLine("El día ingresado es Sábado.");
                    break;
                case 7:
                    Console.WriteLine("El día ingresado es Domingo.");
                    break;
                default:
                    Console.WriteLine("El día ingresado no existe.");
                    break;
            }

            Console.ReadKey();
        }
    }
}
