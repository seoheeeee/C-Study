﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._8
{
    internal class _8_06
    {
        static void Main1(string[] args)
        {
            int index;
            int primes = 0;

            for(int i=2; i<1000; i++)
            {
                for(index =2; index < i; index++)
                {
                    if(i % index == 0)
                    {
                        break;
                    }
                }

                if(index == i)
                {
                    primes++;
                    Console.Write("{0,5}{1}",i,primes % 15 == 0 ? "\n" : "");
                }
            }
            Console.WriteLine("\n2부터 1000 사이의 소수의 개수 : {0}개", primes);
        }
    }
}
