using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._01단계
{
    internal class Main1_07
    {
        static void Main1(string[] args)
        {
            string[] num = Console.ReadLine().Split();

            int a = int.Parse(num[0]);
            int b = int.Parse(num[1]);

            Console.WriteLine(a * b);
        }
    }
}
