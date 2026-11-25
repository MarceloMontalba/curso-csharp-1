namespace ClasesYObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sale mensaje1 = new Sale(300, DateTime.Now);
            Sale mensaje2 = new Sale(340, DateTime.Now);
            Sale mensaje3 = new Sale(56450, DateTime.Now);
            Sale mensaje4 = new Sale(40, DateTime.Now);

            Console.WriteLine(mensaje1.GetInfo());
            Console.WriteLine(mensaje2.GetInfo());
            Console.WriteLine(mensaje3.GetInfo());
            Console.WriteLine(mensaje4.GetInfo());
        }
    }

    class Sale
    {
        int total;
        DateTime date;

        public Sale(int total, DateTime date)
        {
            this.total = total;
            this.date  = date;
        }

        public string GetInfo()
        {
            return this.total + "; " + this.date.ToLongDateString();
        }

        public void Show()
        {
            Console.WriteLine("Hola soy una venta");
        }
    }
}
