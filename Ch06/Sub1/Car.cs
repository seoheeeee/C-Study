using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06.Sub1
{
    abstract class Car
    {

        //속성(필드)
        protected string color;
        protected string name;
        protected int speed;//멤버(멤버를 지칭할 때는 this를 붙인다.)

        public Car(string color, string name, int speed)
        {
            this.color = color;
            this.name = name;
            this.speed = speed;
        }


        //기능(메서드)
        public abstract void SpeedUp(int speed);//추상 메서드
        public abstract void SpeedDown(int speed);
        
        public virtual void Show()
        {
            Console.WriteLine("=============");
            Console.WriteLine("차량명 : "+name);
            Console.WriteLine("차량색 : "+color);
            Console.WriteLine("차량속도 : "+speed);
        }

    }
}
