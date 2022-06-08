using Ch05.Sub1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/08
 * 이름 : 이서희
 * 내용 : 클래스와 객체ㅐㅐ 실습하기 교재 p203
 * 
 * 
 */

namespace Ch05
{
    internal class _1_Class
    {
        static void Main(string[] args)
        {
            //객체 생성
            Car sonata = new Car();

            //객체 초기화
            sonata.name = "소나타";
            sonata.color = "흰색";
            sonata.speed = 0;

            //객체 기능
            sonata.SpeedUp(10);
            sonata.SpeedUp(50);
            sonata.SpeedDown(20);
            sonata.Show();

            //객체 생성(bmw, 검정색)

            Car bmw = new Car();

            bmw.name = "BMW";
            bmw.color = "검정색";
            bmw.speed = 0;

            bmw.SpeedUp(50);
            bmw.SpeedDown(20);
            bmw.Show();



            //Account 객체생성
            Account kb = new Account();

            //초기화
            kb.bank = "국민은행";
            kb.id = "101-12-1234";
            kb.name = "김유신";
            kb.balance = 10000;

            //기능
            kb.Deposit(25000);
            kb.Withdraw(5000);
            kb.Show();

            //nh객체생성
            Account nh = new Account();
            nh.bank = "농협은행";
            nh.id = "123-123-1234";
            nh.name = "이영희";
            nh.balance = 20000;

            nh.Deposit(30000);
            nh.Withdraw(6000);
            nh.Show();
        }
    }
}
