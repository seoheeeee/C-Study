namespace Project4
{
    public partial class Form1 : Form
    {
        Graphics g;
        Rectangle racket = new Rectangle();
        Rectangle[] blocks = new Rectangle[100];
        bool[] blockVisible = new bool[100];

        Rectangle ball;

        Brush racketColor = new SolidBrush(Color.Red);
        Brush blockColor = new SolidBrush(Color.Orange);
        Brush ballColor = new SolidBrush(Color.Gold);
        Pen pen = new Pen(Color.Black);

        int formW = 300;
        int formH = 500;

        int nBlocks = 20;

        int racketY = 480;
        int racketW = 50;
        int racketH = 10;

        int blockY = 60;
        int blockW = 30;
        int blockH = 20;

        int ballW = 10;
        int ballH = 10;


        double slope; // ����
        double vDir;  // �� ���� �Ʒ��� ���ϴ� ���� ����

        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();

            // �� ������
            this.ClientSize = new Size(formW, formH);
            this.Text = "BlockBreak v1.0";

            // �׷��� ��ü ����
            g = this.CreateGraphics();

            // ��� �ʱ�ȭ
            InitBlocks();

            // ���� �ʱ�ȭ
            InitRacket();

            // �� �ʱ�ȭ
            InitBall();
        }
        public void InitBlocks()
        {
            for (int i = 0; i < nBlocks; i++)
            {
                blocks[i] = new Rectangle(i % 10 * blockW,
                                          blockY + blockH * (i / 10),
                                          blockW - 1,
                                          blockH - 1);

                blockVisible[i] = true;
            }
        }
        public void InitRacket()
        {
            racket.X = formW / 2 - racketW / 2;
            racket.Y = racketY;
            racket.Width = racketW;
            racket.Height = racketH;
        }
        public void InitBall()
        {
            ball = new Rectangle();
            ball.X = formW / 2 - ballW / 2;
            ball.Y = blockY + nBlocks / 10 * blockH;
            ball.Width = ballW;
            ball.Height = ballH;

            // ���Ⱚ �ʱ�ȭ
            slope = rand.Next(1, 20) / 10.0;
            if (rand.Next(2) % 2 == 1)
            {
                slope = -slope;
            }
            vDir = 1;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // ���� �׸���
            for (int i = 0; i < nBlocks; i++)
            {
                if (blockVisible[i])
                {
                    g.FillRectangle(blockColor, blocks[i]);
                }
            }

            // ���� �׸���
            g.FillRectangle(racketColor, racket);

            // �� �׸���
            g.FillEllipse(ballColor, ball);
            g.DrawEllipse(pen, ball);
        }

        private void myTimer_Tick(object sender, EventArgs e)
        {
            double dx = 0;
            double unit = ballW;

            dx = unit / slope;

            int x = (int)dx;
            int y = (int)(vDir * slope * dx);

            Console.WriteLine("x : {0}, y : {1}", x, y);

            ball.X += x;
            ball.Y += y;

            // ball�� �¿� ���� �浹 �ߴ��� üũ
            if (ball.X < 0 || ball.X > formW - ballW)
            {
                slope = -slope;
            }

            // ball�� ���Ͽ� �¾Ҵ��� üũ
            if (ball.Y < 0 || racket.IntersectsWith(ball))
            {
                vDir = -vDir;
            }

            // ball�� ������ �¾Ҵ��� üũ
            for (int i = 0; i < nBlocks; i++)
            {
                if (ball.IntersectsWith(blocks[i]))
                {
                    vDir = -vDir;
                    blockVisible[i] = false;
                }
            }

            // ball�� �������� ������ ��
            if (ball.Y > ClientSize.Height)
            {
                myTimer.Stop();

                DialogResult result = MessageBox.Show("�ٽ� �����Ͻðڽ��ϱ�?", "Ȯ��", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    InitBlocks();
                    InitRacket();
                    InitBall();

                    // ���� �ٽ� ����
                    myTimer.Start();
                }
                else
                {
                    this.Close();
                }
            }

            // ��� ������ �� ������



            Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                racket.X -= 10;
            }
            else if (e.KeyCode == Keys.Right)
            {
                racket.X += 10;
            }

            Invalidate();
        }
    }
}