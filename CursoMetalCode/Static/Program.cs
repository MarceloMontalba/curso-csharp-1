using System.Net.NetworkInformation;

namespace Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person persona = new Person("Marcelo Montalba", 28);
            Console.WriteLine(persona.GetPerson());

            Console.WriteLine(Person.Count);    // Al ser estatica la propiedad Count, es propia de la clase y no del objeto
            Console.WriteLine(Person.GetExample());

            A.Some();
        }
    }

    public static class A   // Todos sus metodos deben ser estaticos
    {
        public static void Some()
        {
            Console.WriteLine("Soy un metodo dentro de una clase estatica");
        }
    }

    public class Person
    {
        public static int Count = 0;

        private string _fullName;
        private int _age;

        public Person(string fullName, int age){
            _fullName = fullName;
            _age = age;
            Count += 1;
        }

        public string GetPerson()
        {
            return $"Full Name : {_fullName}.\nAge : {_age}."; // Interpolacion de cadenas
        }

        public static string GetExample(){
            return "Soy de la clase y no del objeto";
        }
    }
}
