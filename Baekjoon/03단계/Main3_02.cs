using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._03단계
{
    internal class Main3_02

    {
        static void Main1(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

           

            int sum = 0;

            for(int i = 1; i <= t; i++)
            {
                string[] num = Console.ReadLine().Split();

                int a = int.Parse(num[0]);
                int b = int.Parse(num[1]);

                sum = a + b;
                Console.WriteLine(sum);
            }
            
        }
    }
}
