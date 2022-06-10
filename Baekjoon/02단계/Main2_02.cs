using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._02단계
{
    internal class Main2_02
    {
        static void Main1(string[] args)
        {
            int score = int.Parse(Console.ReadLine());
            char grade;
           
            
            if(score >= 90 && score <= 100)
            {
                grade = 'A';
            }
            else if(score >= 80 && score < 90)
            {
                grade = 'B';
            }
            else if(score >= 70 && score < 80)
            {
                grade = 'C';
            }
            else if(score >= 60 && score < 70)
            {
                grade = 'D';
            }
            else
            {
                grade = 'F';
            }
            Console.WriteLine(grade);
        }
    }
}
