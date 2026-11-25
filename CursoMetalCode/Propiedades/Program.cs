namespace Propiedades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sale v = new Sale(34, DateTime.Now);
            v.Total = -3432;

            Console.WriteLine(v.Total);
            Console.WriteLine(v.Date);

        }
    }

    class Sale
    {
        int total;
        DateTime date;

        public int Total
        {
            get                 // get tiene que retornar un tipo de dato acorde al establecido como retorno en la propiedad
            {
                return total;
            }
            set
            {
                if (value < 0)  // value se crea automaticamente con el accesors set y representa el valor que fue entregado a la propiedad
                    value = 0;
                this.total = value;
            }
        }

        public string Date
        {
            get
            {
                return this.date.ToLongDateString();
            }
        }

        public Sale(int total, DateTime date)
        {
            this.total = total;
            this.date = date;
        }
    }
}
