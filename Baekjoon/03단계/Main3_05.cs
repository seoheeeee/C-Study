using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._03단계
{
    internal class Main3_05
    {
        static void Main1(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            
            for(int i = 1; i <= n; i++)
            {
                sb.Append(i+"\n");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
