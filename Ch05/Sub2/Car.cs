using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05.Sub1
{
    internal class Car
    {

        //속성(필드)
        public string color;
        public string name;
        public int speed;//멤버(멤버를 지칭할 때는 this를 붙인다.)


        //기능(메서드)
        public void SpeedUp(int speed)//메서드의 매개변수
        {
            this.speed += speed;
        }
        public void SpeedDown(int speed)
        {
            this.speed -= speed;
        }
        public void Show()
        {
            Console.WriteLine("=============");
            Console.WriteLine("차량명 : "+name);
            Console.WriteLine("차량색 : "+color);
            Console.WriteLine("차량속도 : "+speed);
        }

    }
}
