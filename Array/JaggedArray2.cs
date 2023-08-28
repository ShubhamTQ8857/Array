using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
   

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }
    public class JaggedArray2
    {
        static void Main(string[] args)
        {
            Product[] List = new Product[3]
                {
                    new Product{Id = 1, Name = "mouse", Price = 499},
                    new Product{Id = 2, Name = "pen", Price = 20},
                    new Product{Id = 3, Name = "pencil", Price = 10},
                };
            foreach (Product p in List)
            {
                Console.WriteLine($"{p.Id} {p.Name}, {p.Price}");
            }

           

        }
    }
}
