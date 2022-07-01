using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Final4
{
    class Box
    {
        private double widht;
        private double height;
        private double depth;

        public Box(double widht, double height, double depth)
        {
            this.widht = widht;
            this.height = height;
            this.depth = depth;
        }

        public double Volume()
        {
            return widht * height * depth;
        }
    }
     internal class F_01
    {
        static void Main1(string[] args)
        {
            Box box1 = new Box(10, 20, 30);
            Box box2 = new Box(3, 6, 9);

            Console.WriteLine("box1 부피 : "+box1.Volume());
            Console.WriteLine("box2 부피 : " + box2.Volume());
        }
    }

}
