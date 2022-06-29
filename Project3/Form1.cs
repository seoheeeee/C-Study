namespace Project3
{
    public partial class Form1 : Form
    {

        private int margin = 40;
        private int sizeNun = 30;
        private int sizeDol = 28;

        Graphics g;
        Pen pen;
        Brush wBrush, bBrush;

        bool isBlack = true;

        enum STONE{none, black, white};
        STONE[,] dataSet = new STONE[19, 19];



        public Form1()
        {
            InitializeComponent();

            //�׷��� ���� ��ü �ʱ�ȭ
            g = this.CreateGraphics();
            pen = new Pen(Color.Black);
            wBrush = new SolidBrush(Color.White);
            bBrush = new SolidBrush(Color.Black);


            //�ٵ��� ��, ũ��
            this.BackColor = Color.Orange;
            this.ClientSize = new Size(2*margin + 18*sizeNun, 2* margin + 18* sizeNun);

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            int x = (e.X - margin + sizeNun / 2) / sizeNun;
            int y = (e.Y - margin + sizeNun / 2) / sizeNun;
            //Console.WriteLine("x:{0}, y:{1}",x,y);



            Rectangle dol = new Rectangle(margin + sizeNun * x - sizeNun / 2,
                                          margin + sizeNun * y - sizeNun / 2,
                                          sizeDol,
                                          sizeDol);

            if (dataSet[x,y] != STONE.none)
            {
                MessageBox.Show("�̹� ���� �����־���","���!!");
                return;//�޼��带 �׳� ������ ��(return ���̶��� �������)
            }



            if (isBlack)
            {
                g.FillEllipse(bBrush, dol);
                dataSet[x, y] = STONE.black;

                isBlack = false;
            }
            else
            {
                g.FillEllipse(wBrush, dol);
                dataSet[x,y] = STONE.white;

                isBlack=true;
            }

            //���񿩺� ����
            CheckOmok(x, y);
        }


        public void CheckOmok(int x, int y)
        {
            int count = 1;

            //������
            for (int i = x + 1; i <= 18; i++)
            {
                if (dataSet[i, y] == dataSet[x, y])
                    count++;
                else
                    break;
            }
            //����
            for (int i = x - 1; i > 0; i--)
            {
                if (dataSet[i, y] == dataSet[x, y])
                    count++;
                else
                    break;
            }
           

            //����
            for (int i = y + 1; i <= 18; i++)
            {
                if (dataSet[x, i] == dataSet[x, y])
                    count++;
                else
                    break;
            }
            //�Ʒ���
            for (int i = y - 1; i > 0; i--)
            {
                if (dataSet[x, i] == dataSet[x, y])
                    count++;
                else
                    break;
            }


            //�밢�� 11��
            for (int i = x - 1,j = y - 1; i > 0 && j > 0; j--,i--)
            {
                if (dataSet[i, j] == dataSet[x, y])
                    count++;
                else
                    break;
            }
            //�밢�� 1��
            for (int i = x + 1, j = y - 1; i <= 18 && j > 0; j--, i++)
            {
                if (dataSet[i, j] == dataSet[x, y])
                    count++;
                else
                    break;
            }

            //�밢�� 4��
            for (int i = x + 1, j = y + 1; i <= 18 && j <= 18; j++, i++)
            {
                if (dataSet[i, j] == dataSet[x, y])
                    count++;
                else
                    break;
            }
            //�밢�� 7��
            for (int i = x - 1, j = y + 1; i > 0 && j <= 18; j++, i--)
            {
                if (dataSet[i, j] == dataSet[x, y])
                    count++;
                else
                    break;
            }

           CheckCountAlert(count);

            
        }

        public void NewGame()
        {
            this.Invalidate();//ȭ�鰻�� -> OnPaint ȣ��


            //�����ͼ� �ʱ�ȭ
            for (int x = 0; x < 19; x++)
                for (int y = 0; y < 19; y++)
                    dataSet[x, y] = STONE.none;

            //������ ����
            isBlack = true;
        }

        public void CheckCountAlert(int count)
        {
            if (count >= 5)
            {
                DialogResult result = MessageBox.Show("�����Դϴ�! ���ο� ������ �����ұ��?", "Ȯ��", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    NewGame();
                    return;
                }
                else
                {
                    this.Close();
                }

            }

        }
       

        protected override void OnPaint(PaintEventArgs e)
        {
            //�ٵ��� ���� �׸���
            for (int i = 0; i < 19; i++)
            {
                g.DrawLine(pen, new Point(margin + sizeNun * i, margin), new Point(margin + sizeNun * i, margin + 18 * sizeNun));
                g.DrawLine(pen, new Point(margin, margin + sizeNun * i), new Point(margin + 18 * sizeNun, margin + sizeNun * i));
            }


        }

    }
}