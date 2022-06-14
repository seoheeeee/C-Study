﻿using Ch06.Sub3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜 : 2022/06/14
 * 이름 : 이서희
 * 내용 : 제네릭 실습하기 교재 p395
 * 
 * 제네릭(Gneric)
 * - 클래스 내부의 변수의 타입을 동적으로 일반화 시키는 문법
 * - 제네릭 사용으로 클래스를 범용성을 갖도록 활용
 */
namespace Ch06
{
    
    
    class FruitBox<T> //제네릭선언은 '<>'
    {
        private T fruit;

        //getter, setter
        public T Fruit
        {
            get { return fruit; }
            set { fruit = value; }
        }
    }


    internal class _4_Generic
    {
        static void Main(string[] args)
        {
            Apple apple = new Apple("한국", 3000);
            Banana banana = new Banana("대만", 4000);

            FruitBox<Apple> box1 = new FruitBox<Apple>();
            box1.Fruit = apple; //setter 호출
            box1.Fruit.show();  //getter 호출

            FruitBox<Banana> box2 = new FruitBox<Banana>();
            box2.Fruit = banana;
            box2.Fruit.show();

        }
    }
}
