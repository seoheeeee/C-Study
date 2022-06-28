﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    internal class DBAccess
    {
        private const string SERVER = "127.0.0.1";
        private const string PORT = "3306";
        private const string USERNAME = "tester";
        private const string PASSWORD = "5678";
        private const string DATABASE = "testdb";
        private const string TABLE = "user1";

        private static DBAccess instance = new DBAccess();
        public static DBAccess Instance { get { return instance; } }
        private DBAccess() { }

        public MySqlConnection Connect()
        {
            string strConn = $"server={SERVER};port={PORT};username={USERNAME};password={PASSWORD};database={DATABASE}";
            MySqlConnection conn = new MySqlConnection(strConn);
            return conn;
        }

        public void InsertUser(string uid, string name, string hp, decimal age) 
        {
            MySqlConnection conn = Connect();

            try
            {
                conn.Open();

                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"INSERT INTO `{TABLE}` VALUES ('{uid}','{name}', '{hp}',{age})";
                cmd.ExecuteNonQuery();
            }
            catch(Exception except)
            {
                Console.WriteLine(except.Message);
            }
            finally
            {
                conn.Close();
                    
            }
            MessageBox.Show("데이터가 저장되었습니다.", "Insert 완료");
                
        }
        
        public List<User> SelectUsers()
        {
            List<User> users = new List<User>();

            MySqlConnection conn = Connect();


            try
            {
                //데이터베이스 접속
                conn.Open();

                //SQL 실행
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM `user1`";

                MySqlDataReader reader = cmd.ExecuteReader();

                //결과리스트 생성
                while (reader.Read())
                {
                    User user = new User();
                    user.Uid = reader[0].ToString();
                    user.Name = reader[1].ToString();
                    user.Hp = reader[2].ToString();
                    user.Age = Convert.ToInt32(reader[3]);

                    users.Add(user);
                }
            }
            catch (Exception except)
            {
                Console.WriteLine(except.Message);
            }
            finally
            {
                conn.Close();
            }

            return users;
        }
        
        
        public void UpdateUser(string uid, string name, string hp, decimal age) 
        {
            MySqlConnection conn = Connect();

            try
            {
                conn.Open();

                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"UPDATE {TABLE} SET `name`='{name}',`hp`='{hp}',`age`={age} WHERE `uid` = '{uid}'";
                cmd.ExecuteNonQuery();
            }
            catch (Exception except)
            {
                Console.WriteLine(except.Message);
            }
            finally
            {
                conn.Close();

            }
            MessageBox.Show("데이터가 수정되었습니다.", "Update 완료");
        }
       
        
        public void DeleteUser(string uid) 
        {
            MySqlConnection conn = Connect();

            try
            {
                conn.Open();

                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"DELETE FROM {TABLE} WHERE `uid` = '{uid}'";
                cmd.ExecuteNonQuery();
            }
            catch (Exception except)
            {
                Console.WriteLine(except.Message);
            }
            finally
            {
                conn.Close();

            }
            MessageBox.Show("데이터가 삭제되었습니다.", "Delete 완료");
        }
       
    }
}
