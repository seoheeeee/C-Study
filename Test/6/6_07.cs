using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._6
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<int> Score { get; set; }
    }

    internal class _6_07
    {
        static void Main1(string[] args)
        {


            Person[] people =
            {
            new Person(){Name="김유신", Age=25, Score=new List<int>() {60, 70, 80 } },
            new Person(){Name="김춘추", Age=23, Score=new List<int>() {70, 72, 81 } },
            new Person(){Name="장보고", Age=35, Score=new List<int>() {68, 82, 76 } },
            new Person(){Name="강감찬", Age=45, Score=new List<int>() {88, 90, 82 } },
            new Person(){Name="이순신", Age=55, Score=new List<int>() {92, 96, 84 } },


        };

            var result = from person in people
                         where person.Score.Average() >= 60
                        orderby person.Score.Sum()descending
                         select new
                         {
                             Name = person.Name,
                             Age = person.Age,
                             Sum = person.Score.Sum(),
                             Avg = person.Score.Average()
                         };

            foreach (var person in result)
            {
                Console.WriteLine($"{person.Name}, {person.Age}, {person.Sum}, {person.Avg}");
            }
        }
    }
}
