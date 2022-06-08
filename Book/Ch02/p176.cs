using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch01
{
    internal class P176
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 10; i++)
            {
                for (int j = 10; i <= j; j--)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
            
        }
    }
}
