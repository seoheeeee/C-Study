using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._03단계
{
    internal class Main3_06
    {
        static void Main1(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for(int i = n; i > 0; i--)
            {
                sb.Append(i+"\n");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
