using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch01
{
    internal class P163
    {
        static void Main1(string[] args)
        {
            int i = 0;
            int[] intarr = { 52, 273, 32, 65, 103 };

            while(i < intarr.Length)
            {
                Console.WriteLine(i + "번째 출력 : " + intarr[i]);
                i++;
            }
        }
    }
}
