using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._03단계
{
    
    internal class Main3_04
    {
        static void Main1(string[] args)
        {

            StringBuilder sb = new StringBuilder();
            int t = int.Parse(Console.ReadLine());
            string[] num;

            for (int i = 0; i < t; i++)
            {
                num = Console.ReadLine().Split();

                sb.Append(int.Parse(num[0]) + int.Parse(num[1])+"\n");
            }
                Console.WriteLine(sb);
            
                

            
        }
    }
}

