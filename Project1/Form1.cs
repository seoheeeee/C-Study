namespace Project1
{
    public partial class Form1 : Form
    {
        private int var1 = 0;
        private int var2 = 0;

        private List<int> list = new List<int>();
        private List<int> operators = new List<int>();

        private int result = 0;

        private int operate = 0; //1:plus. 2:minus, 3:multi, 4:div



        public Form1()
        {
            InitializeComponent();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            list.Add(7);

            txtresult.Text = string.Join("", list);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            list.Add(8);

            txtresult.Text = string.Join("", list);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            list.Add(9);

            txtresult.Text = string.Join("", list);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            list.Add(4);

            txtresult.Text = string.Join("", list);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            list.Add(5);

            txtresult.Text = string.Join("", list);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            list.Add(6);

            txtresult.Text = string.Join("", list);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            list.Add(1);

            txtresult.Text = string.Join("", list);
            

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            list.Add(2);

            txtresult.Text = string.Join("", list);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            list.Add(3);

            txtresult.Text = string.Join("", list);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            list.Add(0);

            txtresult.Text = string.Join("", list);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtresult.Text = "0";
            var1 = 0;
            var2 = 0;
            operate = 0;
            list.Clear();

        }

        private void btnEq_Click(object sender, EventArgs e)
        {
            string currentNum = txtresult.Text.ToString();
            var2 = int.Parse(currentNum);
            list.Clear();

            switch (operate)
            {
                case 1:
                    result = var1 + var2;
                    break;

                case 2:
                    result = var1 - var2;
                    break;

                case 3:
                    result = var1 * var2;
                    break;

                case 4:
                    result = var1 / var2;
                    break;
            }
            
            txtresult.Text = result.ToString();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            operate = 1;
           string currentNum = txtresult.Text.ToString();
            var1 = int.Parse(currentNum);
            list.Clear();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            operate = 2;
            string currentNum = txtresult.Text.ToString();
            var1 = int.Parse(currentNum);
            list.Clear();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            operate = 3;
            string currentNum = txtresult.Text.ToString();
            var1 = int.Parse(currentNum);
            list.Clear();
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            operate = 4;
            string currentNum = txtresult.Text.ToString();
            var1 = int.Parse(currentNum);
            list.Clear();
        }
    }
}