﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1
{
    internal class _1_09
    {
        static void Main1(string[] args)
        {
            int count = 0;
            for(int i = 1; i <= 9; i++)
            {
                if (i <= 5)
                    count++;
                else
                    count--;
                for(int j = 1; j <= 5 - count; j++)
                {
                    Console.WriteLine(" ");
                }
                for(int k = 1; k <= 2 * count - 1; k++)
                {
                    Console.WriteLine("*");
                }
                Console.WriteLine();
            }
        }
    }
}
