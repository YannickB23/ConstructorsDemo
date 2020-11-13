using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorsDemo
{
    public class Factuur
    {
        public double BTW;
        public int Id;  //default waarde = 0
        public string Article;  //objecten dafault waarde = NULL
        public double Price;

        public Factuur()
        {
            this.BTW = 21.00;
        }
        public Factuur(int id)
            :this()
        {
            Id = id;
        }
        public Factuur(int id, string article)
            :this(id)
        {
            this.Id = id;
            this.Article = article;
        }
        public Factuur(int id, string article, double price)
            :this(id, article)
        {
            this.Id = id;
            this.Article = article;
            this.Price = price;
        }

    }
}
