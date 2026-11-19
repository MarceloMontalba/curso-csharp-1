using System;

namespace OperadoresRelacionales
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num1, num2;
            bool operaciones;

            num1 = 10;
            num2 = 10;
            operaciones = (num1 >= num2);

            Console.WriteLine("num1 es mayor a num2?: " +(num1>num2));
            Console.WriteLine("num1 es mayor o igual a num2?: " + (num1 >= num2));
            Console.WriteLine("num1 es igual a num2?: " + (num1 == num2));

            Console.ReadKey();
            
        }
    }
}
