﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._01단계
{
    internal class Main1_05
    {
        static void Main1(string[] args)
        {
            string[] num = Console.ReadLine().Split();

            int n1 = int.Parse(num[0]);
            int n2 = int.Parse(num[1]);

            Console.WriteLine(n1 + n2);

           // Console.WriteLine("num 1번째 값 : " + num[0]);
           // Console.WriteLine("num 2번째 값 : " + num[1]);
        }
    }
}
