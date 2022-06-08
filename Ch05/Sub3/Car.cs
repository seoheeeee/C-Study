using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05.Sub3
{
    internal class Car
    {

        //속성(필드)
        private string color;
        private string name;
        private int speed;//멤버(멤버를 지칭할 때는 this를 붙인다.)
        private static int count; 


        //Getter, Setter - C#에서는 프로퍼티
        public string Name { get{return name;} set {name = value;}}
        public int Speed { 
            get
            {
                return speed;
            }
            set 
            {
                if(value < 0)
                {
                    Console.WriteLine("speed는 0보다 작을 수 없습니다.");
                    speed = 0;
                }
                else
                {
                    speed = value;
                }
               
            }
        }
        public string Color { get { return color; } set { color = value; } }


        //생성자
        public Car(string color, string name, int speed)
        {
            this.color = color;
            this.name = name;
            this.speed = speed;
            count++;
        }


        //소멸자
        ~Car()
        {
            Console.WriteLine("{0} Car 소멸자 실행...", name);
        }




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
            Console.WriteLine("전체 차량수 : "+count);
        }

        public override bool Equals(object? obj)
        {
            return obj is Car car &&
                   color == car.color &&
                   name == car.name &&
                   speed == car.speed;
        }
    }
}
