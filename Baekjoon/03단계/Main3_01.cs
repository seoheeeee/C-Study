using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._03단계
{
    internal class Main3_01
    {
        static void Main(string[] args)
        {


            int N = int.Parse(Console.ReadLine());


            for(int i = 1; i <= 9; i++)
            {
                int j = N * i;
                Console.WriteLine("{0} * {1} = {2}", N, i, j);
            }
           
            
        }
        
      
    }
}
