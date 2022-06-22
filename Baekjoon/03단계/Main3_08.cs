using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._03단계
{
    internal class Main3_08
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            string[] num;
            int a = 0;  

            for(int i = 1; i <= t; i++)
            {
                num = Console.ReadLine().Split();
                a = int.Parse(num[0]) + int.Parse(num[1]);
                sb.Append($"Case #{i}: {num[0]} + {num[1]} = " +a +"\n");
            }
            Console.WriteLine(sb);
        }
    }
}
