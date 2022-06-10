using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._02단계
{
    internal class Main2_01
    {
        static void Main1(string[] args)
        {


            string[] num = Console.ReadLine().Split();

            int a = int.Parse(num[0]);
            int b = int.Parse(num[1]);

            if (a > b)
            {
                Console.WriteLine(">");
            }
            else if(a < b)
            {
                Console.WriteLine("<");
            }
            else
            {
                Console.WriteLine("==");
            }
        }
    }
}
