using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._03단계
{
    internal class Main3_03
    {
        static void Main1(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int sum = 0;

            for(int i = 1; i <= a; i++)
            {
                sum += i;

            }
            Console.WriteLine(sum);
        }
    }
}
