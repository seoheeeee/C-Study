using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._5
{
    internal class _5_10
    {
        static void Main1(string[] args)
        {
            //배열
            string[] arrName = new string[5];
            arrName[0] = "dog";
            arrName[1] = "cow";
            arrName[2] = "rabbit";
            arrName[3] = "goat";
            arrName[4] = "sheep";

            Array.Sort(arrName);

            Console.WriteLine("배열");
            foreach(string name in arrName)
            {
                Console.Write(name + " ");
            }
            Console.WriteLine();

            //리스트
            List<string> lstNames = new List<string>();
            lstNames.Add("dog");
            lstNames.Add("cow");
            lstNames.Add("rabbit");
            lstNames.Add("goat");
            lstNames.Add("sheep");

            lstNames.Sort();

            Console.WriteLine("리스트");
            foreach(string name in lstNames)
            {
                Console.Write(name+" ");
            }
            Console.WriteLine();

        }
    }
}
