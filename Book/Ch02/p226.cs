using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    
    internal class p226
    {
    class Product
        {
            private string name;
            private int price;

            public string Name { get { return name; } set { name = value; } }
            public int Price { get { return price; } set { price = value; } }

            public void Show()
            {
                Console.WriteLine("==========");
                Console.WriteLine("채소이름 : " +name);
                Console.WriteLine("가격 : " +price);
            }
        }
        static void Main1(string[] args)
        {
            Product product = new Product();

            product.Price = 1000;
            product.Name = "감자";
            product.Show();
           
        }
    }
}
