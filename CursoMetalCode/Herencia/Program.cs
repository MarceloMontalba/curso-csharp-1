namespace Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            People persona1 = new People("Alexander Montalba", 14);
            Console.WriteLine(persona1.GetInfo());

            Console.WriteLine("\n====================================\n");

            Medic persona2 = new Medic("Agustina Ortega", 29, "Cardiología");
            Console.WriteLine(persona2.GetRecord());

            Console.WriteLine("\n====================================\n");

            Developer persona3 = new Developer("Marcelo Montalba", 28, "C#", ".NET");
            Console.WriteLine(persona3.GetRecord());
        }
    }

    public class People
    {
        private string _name;
        private int _age;

        public People(string name, int age)
        {
            _name = name;
            _age  = age;
        }

        public string GetInfo()
        {
            return $"Name : {_name}.\nAge  : {_age}.";
        }
    }

    public class Medic : People
    {
        private string _speciality;

        public Medic(string name, int age, string speciality) : base(name, age)
        {
            _speciality = speciality;
        }

        public string GetRecord()
        {
            return GetInfo() + $"\nSpeciality : {_speciality}.";
        }
    }

    public class Developer : People
    {
        private string _language;
        private string _framework;

        public Developer(string name, int age, string language, string framework) : base(name, age)
        {
            _language  = language;
            _framework = framework;
        }

        public string GetRecord()
        {
            return GetInfo() + $"\nLaguage : {_language}.\nFramework : {_framework}.";
        }
    }
}
