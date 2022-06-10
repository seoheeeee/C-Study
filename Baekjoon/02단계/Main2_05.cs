using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._02단계
{
    internal class Main2_05
    {
        static void Main(string[] args)
        {
            string[] num = Console.ReadLine().Split();

            int h = int.Parse(num[0]);
            int m = int.Parse(num[1]);

            if (h < 0 || h < 24 || m < 0 || m > 60)
            {
                if (m < 45)
                {
                    h--;
                    m += 15;

                    if (h < 0)
                    {
                        h = 23;
                    }
                }
                else
                {
                    m -= 45;
                }
                Console.WriteLine("{0} {1}", h, m);
            }
           
        }
    }
}
