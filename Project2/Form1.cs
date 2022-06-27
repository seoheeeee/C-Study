using MySql.Data.MySqlClient;

namespace Project2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //�����ͺ��̽� ���� ����
            string server = "127.0.0.1";
            string port = "3306";
            string username = "tester";
            string password = "5678";
            string database = "testdb";

            //�����ͺ��̽� Ŀ�ؼ�
            string strConn = $"server={server};port={port};username={username};password={password};database={database}";
            MySqlConnection conn = new MySqlConnection(strConn);

            //������ ���� ����Ʈ ����
            List<User> users = new List<User>();


            try
            {
                //�����͸��̽� ����
                conn.Open();

                //SQL ����
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM `user1`";

                MySqlDataReader reader = cmd.ExecuteReader();

                //�������Ʈ ����
                while(reader.Read())
                {
                    User user = new User();
                    user.Uid = reader[0].ToString();
                    user.Name = reader[1].ToString();
                    user.Hp = reader[2].ToString();
                    user.Age = Convert.ToInt32(reader[3]);
                    
                    users.Add(user);
                }





            }
            catch(Exception except)
            {
                Console.WriteLine(except.Message);
            }
            finally
            {
                conn.Close();
            }
            //������ �׸���� ������ ����
            dataGridView1.DataSource = users;
        }

       

        private void btnInsert_Click_1(object sender, EventArgs e)
        {
            string uid = txtUid.Text.ToString();
            string name = txtName.Text.ToString();
            string hp = txtHp.Text.ToString();
            string age = nAge.Text.ToString();


            //�����ͺ��̽� ���� ����
            string server = "127.0.0.1";
            string port = "3306";
            string username = "tester";
            string password = "5678";
            string database = "testdb";

            //�����ͺ��̽� Ŀ�ؼ�
            string strConn = $"server={server};port={port};username={username};password={password};database={database}";
            MySqlConnection conn = new MySqlConnection(strConn);


            try
            {
                conn.Open();

                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"INSERT INTO `user1` VALUES('{uid}','{name}','{hp}',{age})";
                cmd.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            finally
            {
                conn.Close();
            }
            MessageBox.Show("�����Ͱ� ����Ǿ����ϴ�.", "Insert �Ϸ�");
            Reset();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
           Reset();
        }
        public void Reset()
        {
            txtUid.Text = "";
            txtName.Text = "";
            txtHp.Text = "";
            nAge.Text = "0";
        }
    }
}