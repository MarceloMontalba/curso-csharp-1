using System.ComponentModel;

namespace Sobreescritura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sales ventas = new Sales(10);
            ventas.Add(90);
            ventas.Add(10);
            ventas.Add(10);

            Console.WriteLine(ventas.GetSum());
            Console.WriteLine("=========================================================");

            SalesWithTax ventasConImpuesto = new SalesWithTax(20, 0.19m);
            ventasConImpuesto.Add(90);
            ventasConImpuesto.Add(10);
            ventasConImpuesto.Add(10);
            Console.WriteLine(ventasConImpuesto.GetSum());
        }
    }

    public class Sales
    {
        private decimal[] _amounts;
        private int _n;
        private int _end;

        public Sales(int n)
        {
            _amounts = new decimal[n];
            _n = n;
            _end = 0;
        }

        public void Add(decimal number)
        {
            if (_end < _n)
            {
                _amounts[_end] = number;
                _end++;
            }
        }

        public virtual decimal GetSum()
        {
            decimal result = 0;
            for (int i=0; i < _amounts.Length; i++)
            {
                result += _amounts[i];
            }

            return result;
        }
    }

    public class SalesWithTax : Sales
    {
        private decimal _tax;
        
        public SalesWithTax(int n, decimal tax) : base(n)
        {
            _tax = tax;
        }

        public override decimal GetSum()
        {
            decimal sum = base.GetSum();
            return sum + sum * _tax;
        }
    }
}
