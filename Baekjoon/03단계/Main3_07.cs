using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._03단계
{
    internal class Main3_07
    {
        static void Main1(string[] args)
        {
              int t = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            string[] num;
           

            for (int i = 1; i <= t; i++)
            {
                
                num = Console.ReadLine().Split();
                sb.Append($"Case #{i}: "+(int.Parse(num[0]) + int.Parse(num[1]))+"\n");
            }
            Console.WriteLine(sb);
        }
    }
}
