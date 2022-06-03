using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._01단계
{
    internal class Main1_08
    {
        static void Main1(string[] args)
        {
            string[] num = Console.ReadLine().Split();

            double a = double.Parse(num[0]);
            double b = double.Parse(num[1]);

            Console.WriteLine(a / b);
        }
    }
}
