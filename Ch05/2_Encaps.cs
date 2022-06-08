using Ch05.Sub1;
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
            Account kb = new Account();
            kb.bank = "국민은행";
            kb.id = "110-11-1234";
            kb.name = "김유신";
            kb.balance = 1000;

            kb.Deposit(4000);
            kb.Withdraw(1000);
            kb.Show();

            kb.balance--;
            kb.balance += 10;

            kb.Show();

        }
    }
}
