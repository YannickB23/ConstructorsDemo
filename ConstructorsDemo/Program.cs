using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ////var Factuur = new Factuur();
            //Factuur factuur = new Factuur();
            //Console.WriteLine(factuur.Id);
            //Console.WriteLine(factuur.Article);

            //Factuur factuur = new Factuur(23100257);
            //Console.WriteLine(factuur.Id);

            //Factuur factuur = new Factuur(23100257, "Tafel");
            //Console.WriteLine(factuur.Id);
            //Console.WriteLine(factuur.Article);
            //Console.WriteLine(factuur.BTW);

            //Factuur factuur = new Factuur(57889001, "Tafel", 250.25);
            //Console.WriteLine(factuur.Id);
            //Console.WriteLine(factuur.Article);
            //Console.WriteLine($"${factuur.Price}");
            //Console.WriteLine(factuur.BTW);

            //Factuur factuur = new Factuur();
            //factuur.Id = 3100547;
            //factuur.Article = "Tafel";
            //factuur.Price = 250.25;
            //Console.WriteLine(factuur.Id);
            //Console.WriteLine(factuur.Article);
            //Console.WriteLine($"${factuur.Price}");

            Factuur factuur = new Factuur()
            {
                Id = 3025047,
                Article = "Tafel",
                Price = 250.25,
                BTW = 21.00
            };
            Console.WriteLine(factuur.Id);
            Console.WriteLine(factuur.Article);
            Console.WriteLine($"${factuur.Price}");
            Console.WriteLine(factuur.BTW);

            Console.ReadLine();
        }
    }
}
