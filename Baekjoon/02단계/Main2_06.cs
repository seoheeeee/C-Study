using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._02단계
{
    internal class Main2_06
    {
        static void Main1(string[] args)
        {
            string[] num = Console.ReadLine().Split();

            int h = int.Parse(num[0]);
            int m = int.Parse(num[1]);
            int mm = int.Parse(Console.ReadLine());

            m += mm;
            
                while(m >= 60)
                {
                    h++;
                    m -= 60;


                    if(h >= 24)
                    {
                        h -= 24;
                    }
                    
                
                }
                Console.WriteLine(h + " " + m);
            
        }
    }
}
