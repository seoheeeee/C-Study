using Ch05.Sub2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜 : 2022/06/08
 * 이름 : 이서희
 * 내용 : 캡슐화 실습하기 교재 p203
 * 
 * 
 */


namespace Ch05
{
    internal class _2_Encaps
    {

        static void Main(string[] args)
        {
           
            //객체생성과 초기화(생성자 호출)
            Account kb = new Account("국민은행","110-11-1234","김유신",1000);



            //setter
            kb.Balance = -50000;
            kb.Bank = "새마을은행";
            kb.Name = "홍길동";
            //getter
            Console.WriteLine("은행 이름 : "+kb.Bank);



            //기능
            kb.Deposit(4000);
            kb.Withdraw(1000);
            kb.Show();


            //캡슐화로 취약코드 예방
            //kb.balance--;
            //kb.balance += 10;


            //Car 객체 생성과 초기화
            Car sonata = new Car("흰색", "소나타", 0);
            Car bmw = new Car("검정색", "BMW", 0);
            Car benz = new Car("흰색", "벤츠", 0);


            //setter 실행
            sonata.Name = "EF소나타";
            sonata.Speed = -100;
            sonata.Color = "빨간색";

            //getter 실행
            Console.WriteLine("sonata 객체 name : "+sonata.Name);


            sonata.SpeedUp(50);
            sonata.SpeedDown(10);
            sonata.Show();

            bmw.SpeedUp(30);
            bmw.Show();

            benz.SpeedUp(40);
            benz.Show();

        }

    }
}
