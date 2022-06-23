﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._5
{
    internal class _5_08
    {
        static void Main1(string[] args)
        {
            Random random = new Random();
            int answer = random.Next(1, 11);
            int input = 0;
            int count = 0;

            do
            {
                count++;
                Console.WriteLine("----------------");
                Console.WriteLine("answer의 값을 맞춰보세요.");
                Console.WriteLine("1 ~ 10 사이의 값을 입력 : ");

                try
                {
                    input= Convert.ToInt32(Console.ReadLine());

                    if (input < 0)
                        throw new Exception("음수는 입력 할 수 없습니다.");
                }
                catch(FormatException e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                    continue ;
                }

                if (answer > input)
                {
                    Console.WriteLine("더 큰 수를 입력하세요.");
                }
                else if (answer < input)
                {
                    Console.WriteLine("더 작은 수를 입력하세요.");
                }
                else
                {
                    Console.WriteLine("answer : " +answer);
                    Console.WriteLine("정답입니다.");
                    Console.WriteLine("시도 횟수 : "+count + "회");
                    break;
                }
            }
            while (true);
            Console.WriteLine("프로그램이 정상 종료 되었습니다.");
        }
    }
}
