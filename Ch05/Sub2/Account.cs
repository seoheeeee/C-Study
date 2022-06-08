using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * 날짜 : 2022/06/08
 * 이름 : 이서희
 * 내용 : 캡슐화 실습하기 교재p203
 * 
 * 캡슐화
 * - 캡슐화는 객체의 내용(필드)을 외부에서 참조하지 못하도록 객체의 정보를 은닉하는 큭성을 말한다.
 * - 캡슐화를 위한 접근 제한자 public, private, protected를 제공한다.
 * - 은닉된 정보의 안전한 제공을 위해 Getter와 Setter를 제공한다.(프로퍼티)
 * 
 * 
 */
namespace Ch05.Sub2
{
    internal class Account
    {
        //속성 - private 캡슐화 적용
        private string bank;
        private string id;
        private string name;
        private int balance;

       
        //setter, getter
        public string Bank { get { return bank; } set { bank = value; } }
        public string Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public int Balance
        {
            get { return balance; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("잔액은 0보다 작을 수 없습니다.");
                    balance = 0;
                }
                else { balance = value; }
            }
        }





        
        //생성자 - 캡슐화된 속성을 초기화 하기 위한 메서드
        public Account(string bank, string id, string name, int balance) 
        { 
            this.bank = bank;
            this.id = id;   
            this.name = name;   
            this.balance = balance; 
        }

       


        //기능
        public void Deposit(int money) 
        {
            this.balance += money;
        }
        public void Withdraw(int money)
        {
            this.balance -= money;
        }
        public void Show()
        {
            Console.WriteLine("==============");
            Console.WriteLine("은행명 : "+bank);
            Console.WriteLine("계좌번호 : "+id);
            Console.WriteLine("입금주 : "+name);
            Console.WriteLine("현재잔액 : "+balance);
            Console.WriteLine("==============");
        }
             
    }
}
