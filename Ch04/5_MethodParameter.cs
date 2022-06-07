using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜 : 2022/06/07
 * 이름 : 이서희
 * 내용 : 메서드 출력전용 매개변수
 * 
 */
namespace Ch04
{
    internal class MethodParameter
    {
        static void Main(string[] args)
        {
            //ref 매개변수
            int num1 = 10;
            int num2 = 3;
            int num3 = 0;
            int num4 = 0;

            Divider1(num1, num2, ref num3, ref num4);

            Console.WriteLine("몫 : {0}, 나머지 : {1}", num3, num4);

            //out 매개변수
        }

        public static void Divider1(int a, int b, ref int quotient, ref int remainder)
        {
            quotient = a / b;
            remainder = a % b;

        }

        public static void Divider2(int a, int b, ref int quotient, ref int remainder)
        {
            quotient = a / b;
            remainder = a % b;

        }
    }
    

}
