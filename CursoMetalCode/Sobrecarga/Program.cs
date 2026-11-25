namespace Sobrecarga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();
            Console.WriteLine(math.Sum(1,4));
            Console.WriteLine(math.Sum("36", 4));
            Console.WriteLine(math.Sum(36, "4"));
            Console.WriteLine(math.Sum("36", "4"));
            Console.WriteLine(math.Sum([10, 5, 5, 6]));
            Console.WriteLine(math.Sum(["10", "5", "5", "6"]));
        }
    }

    public class Math
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }

        public int Sum(string a, int b)
        {
            return int.Parse(a) + b;
        }

        public int Sum(int a, string b)
        {
            return a + int.Parse(b);
        }

        public int Sum(string a, string b)
        {
            return int.Parse(a) + int.Parse(b);
        }

        public int Sum(int[] numbs)
        {
            int result = 0;
            for (int i=0; i < numbs.Length; i++)
            {
                result += numbs[i];
            }
            return result;
        }

        public string Sum(string[] numbs)
        {
            int result = 0;
            for (int i = 0; i < numbs.Length; i++)
            {
                result += int.Parse(numbs[i]);
            }
            return result.ToString();
        }
    }
}
