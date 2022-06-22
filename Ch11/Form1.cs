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
            lbUid.Text ="��� : "+uid;
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            lbName.Text ="��� : "+txtName.Text;
        }

        private void btnHp_Click(object sender, EventArgs e)
        {
            lbHp.Text = "��� : " + txthp.Text;
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

            lbResultFruit.Text = "������ ���� : "+String.Join(",", fruits);
        }

        private void btnPerson_Click(object sender, EventArgs e)
        {
            if(rbtnMen.Checked)
            {
                lbPerson.Text = "��� : ����";
            }
            else
            {
                lbPerson.Text = "��� : ����";
            }


        }

        private void btnGrage_Click(object sender, EventArgs e)
        {
            if(rbtnGrage1.Checked)
            {
                lbGrage.Text = "��� : 1�г�";
            }
            else if(rbtnGrage2.Checked)
            {
                lbGrage.Text = "��� : 2�г�";
            }
            else if(rbtnGrage3.Checked)
            {
                lbGrage.Text = "��� : 3�г�";
            }
            else if(rbtnGrage4.Checked)
            {
                lbGrage.Text = "��� : 4�г�";
            }

        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}