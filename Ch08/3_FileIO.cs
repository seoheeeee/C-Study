﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜 : 2022/06/20
 * 이름 : 이서희
 * 내용 : 파일 입출력 실습하기
 * 
 * 파일 입출력(I/O)
 * - 파일(File)은 컴퓨터 저장매체(HDD)에 저장되는 데이터 묶음
 * - 프로그램은 데이터 처리(Process)와 더물어 처리 결과를 저장하기 위해 파일 입출력을 수행
 */
namespace Ch08
{
    internal class _3_FileIO
    {
        static void Main1(string[] args)
        {
            /////////////////////////
            ///파일 입력(Read)
            /////////////////////////
            string path1 = "C:\\Users\\1302\\Desktop\\sample1.txt";
            FileStream fs = null;
            StreamReader sr = null;

            try
            {

                //스트림 생성
                fs = new FileStream(path1, FileMode.Open, FileAccess.Read);

                //텍스트 파일 전용 보조 스트림 생성
                sr = new StreamReader(fs);

                //파일 읽기
                string line;
                while ((line = sr.ReadLine()) != null)//while값이 null이 아니면
                {
                    Console.WriteLine(line);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                //파일 닫기(자원해제)
                sr.Close();
                fs.Close();
            }
            
           


            /////////////////////////
            //파일 출력(write)
            /////////////////////////
            string path2 = "C:\\Users\\1302\\Desktop\\sample2.txt";
            FileStream outFs = null;
            StreamWriter sw = null;

            try
            {
                //스트림 생성
                outFs = new FileStream(path2, FileMode.OpenOrCreate, FileAccess.Write);
                sw = new StreamWriter(outFs);

                //파일 쓰기
                sw.WriteLine("Welcome World!");
                sw.WriteLine("Welcome Korea!");
                sw.WriteLine("Welcome Busan!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                //파일 닫기
                sw.Close();
                outFs.Close();
            }

            ////////////////////
            ///파일 읽기/쓰기
            ////////////////////

            string f1 = "C:\\Users\\1302\\Desktop\\sample1.txt";
            string f3 = "C:\\Users\\1302\\Desktop\\sample3.txt";

            try
            {
                //using 선언으로 스트림 자원 해제 자동 실행
                using StreamReader reader = new StreamReader(new FileStream(f1, FileMode.Open));
                using StreamWriter writer = new StreamWriter(new FileStream(f3, FileMode.OpenOrCreate));  
                
                string txt;

                while((txt = reader.ReadLine()) != null)
                {
                    writer.WriteLine(txt);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }


            Console.WriteLine("프로그램 종료...");
        }
    }
}
