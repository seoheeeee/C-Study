﻿using Ch06.Sub2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜 : 2022/06/13
 * 이름 : 이서희
 * 내용 : 인터페이스 실습 교재 p425
 * 
 * 
 * 
 */
namespace Ch06
{
    internal class _2_Interface
    {
        static void Main(string[] args)
        {
            //인터페이스로 공통 클래스 구조설계
            IRemoteControl lg      = new LGRemocon();
            IRemoteControl samsung = new SamsungRemocon();

            lg.PowerOn();
            lg.ChDown();
            lg.SoundUp();
            lg.SoundDown();

            samsung.PowerOn();
            samsung.ChUP();
            samsung.SoundDown();
            samsung.PowerOff();

            //인터페이스를 활용한 다중 상속
            TV tv = new TV();
            tv.PowerOn();
            tv.Booting();
            tv.Access();
        }
    }
}
