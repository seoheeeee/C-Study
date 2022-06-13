using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._02단계
{
    internal class Main2_07
    {
        static void Main1(string[] args)
        {
            string[] num = Console.ReadLine().Split();

            int a = int.Parse(num[0]);
            int b = int.Parse(num[1]);
            int c = int.Parse(num[2]);

            if( a==b && b==c)
            {
                Console.WriteLine(10000 + (a * 1000));
            }
            else if(a==b || a==c)
            {
                Console.WriteLine(1000+(a * 100));
            }
            else if(b == c)
            {
                Console.WriteLine(1000+(b * 100));
            }
            else
            {
                if(a>b&&a>c)
                { Console.WriteLine(100*a);}
                else if(b>c)
                {
                    Console.WriteLine(100*b);
                }
                else
                {
                    Console.WriteLine(100*c);
                }
            }
        }
    }
}
