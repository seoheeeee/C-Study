using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch01
{
    internal class P159
    {
        static void Main1(string[] args)
        {
            int[] intarr = { 52, 273, 32, 65, 103 };

            intarr[0] = 0;

            Console.WriteLine(intarr[0]);
            Console.WriteLine(intarr[1]);
            Console.WriteLine(intarr[2]);
            Console.WriteLine(intarr[3]);



            Console.WriteLine(intarr.Length);
        }
    }
}
