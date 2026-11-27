using System.Text.Json;

namespace SerializacionObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Beer cerveza1 = new Beer()
            {
                Name = "Pikantus",
                Brand = "Erdinger"
            };

            Beer cerveza2 = new Beer()
            {
                Name = "Cristal Lager",
                Brand = "Cristal"
            };

            //string objetoJson1 = "{\"Name\" : \"Pikantus\", \"Brand\" : \"Erdinger\"}";
            string objetoJson1 = JsonSerializer.Serialize(cerveza1);
            Console.WriteLine(objetoJson1);

            Console.WriteLine("====================================================");

            string objetoJson2 = "[" +
                                    "{\"Name\" : \"Pikantus\", \"Brand\" : \"Erdinger\"}," +
                                    "{\"Name\" : \"Cristal Lager\", \"Brand\" : \"Cristal\"}"
                                  + "]";
            Console.WriteLine(objetoJson2);

        }
    }

    public class Beer
    {
        public string Name { get; set; }
        public string Brand { get; set; }
    }
}
