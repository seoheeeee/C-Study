using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜:2022/06/03
 * 이름:이서희
 * 내용:조건문 실습 교재 p127
 */
namespace Ch03
{
    internal class _2_Switch
    {
        static void Main(string[] args)
        {
            Console.Write("점수입력 : ");
            string strScore = Console.ReadLine();

            int score = int.Parse(strScore);
            int grade = score / 10;

            switch(grade)
            {
                case 9:
                    Console.WriteLine("A는 입니다.");
                    break;
                case 8:
                    Console.WriteLine("B입니다.");
                    break;
                case 7:
                    Console.WriteLine("C 입니다.");
                    break;
                case 6:
                    Console.WriteLine("D 입니다.");
                    break;
                default:
                    Console.WriteLine("F 입니다.");
                    break;

            }
        }
    }
}
