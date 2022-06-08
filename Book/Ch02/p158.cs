using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch01
{
    internal class P158
    {
        static void Main1(string[] args)
        {
            int[] intarr = { 52, 273, 32, 65, 103 };
            long[] longarr = { 52, 273, 32, 65, 103 };
            float[] flaotarr = { 1.0F, 2.0F, 3.0F, 4.0F, 5.0F };
            double[] doublearr = { 1.0, 2.0, 3.0, 4.0, 5.0 };
            char[] chararr = { 'a', 'b', 'c', 'd', 'e' };
            string[] stringarr = { "윤인성", "연하진", "윤아린" };

            foreach (int i in intarr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            foreach (long l in longarr)
            {
                Console.Write(l + " ");
            }
            Console.WriteLine();

            foreach (float f in flaotarr)
            {
                Console.Write(f + "F ");
            }
            Console.WriteLine();

            foreach (double d in doublearr)
            {
                Console.Write(d + " ");
            }
            Console.WriteLine();

            foreach(char c in chararr)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();

            foreach(string s in stringarr)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();
        }
    }
}
