﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._4
{
    partial class MyClass
    {
        public void Method1()
        {
            Console.WriteLine("Method1...");
        }
        public void Method2()
        {
            Console.WriteLine("Method2...");
        }
    }

    partial class MyClass
    {
        public void Method3()
        {
            Console.WriteLine("Method3...");
        }

        public void Method4()
        {
            Console.WriteLine("Method4...");
        }
    }
    internal class _4_02
    {
        static void Main1(string[] args)
        {
            MyClass my = new MyClass();

            my.Method1();
            my.Method2();
            my.Method3();
            my.Method4();
        }
    }
}
