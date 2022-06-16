using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3
{
    interface Buyer
    {
        public abstract void Buy();
    }

    interface seller
    {
        public abstract void Sell();
    }

    class Customers : Buyer, seller
    {
        public void Sell()
        {
            Console.WriteLine("판매하기");
        }

        public void Buy()
        {
            Console.WriteLine("구매하기");
        }
    }
    internal class _3_10
    {
        static void Main(string[] args)
        {
            Buyer buyer = new Customers();
            seller seller = new Customers();

            buyer.Buy();
            seller.Sell();
        }
    }
}
