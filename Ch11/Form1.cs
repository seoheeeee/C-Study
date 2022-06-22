namespace Ch11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUid_Click(object sender, EventArgs e)
        {
            string uid = txtUid.Text;
            lbUid.Text ="결과 : "+uid;
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            lbName.Text ="결과 : "+txtName.Text;
        }

        private void btnHp_Click(object sender, EventArgs e)
        {
            lbHp.Text = "결과 : " + txthp.Text;
        }

        private void btnFruit_Click(object sender, EventArgs e)
        {
            CheckBox[] chbFruits = { chbFruit1, chbFruit2, chbFruit3, chbFruit4, chbFruit5 };

            List<string> fruits = new List<string>();
            foreach(CheckBox chb in chbFruits)
            {
                if(chb.Checked)
                {
                    fruits.Add(chb.Text);
                }
            }

            lbResultFruit.Text = "선택한 과일 : "+String.Join(",", fruits);
        }

        private void btnPerson_Click(object sender, EventArgs e)
        {
            if(rbtnMen.Checked)
            {
                lbPerson.Text = "결과 : 남자";
            }
            else
            {
                lbPerson.Text = "결과 : 여자";
            }


        }

        private void btnGrage_Click(object sender, EventArgs e)
        {
            if(rbtnGrage1.Checked)
            {
                lbGrage.Text = "결과 : 1학년";
            }
            else if(rbtnGrage2.Checked)
            {
                lbGrage.Text = "결과 : 2학년";
            }
            else if(rbtnGrage3.Checked)
            {
                lbGrage.Text = "결과 : 3학년";
            }
            else if(rbtnGrage4.Checked)
            {
                lbGrage.Text = "결과 : 4학년";
            }

        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}