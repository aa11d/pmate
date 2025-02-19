namespace _0219
{

    public partial class Form1 : Form
    {
        List<PictureBox> labdak = new List<PictureBox>();
        List<int> labdaVx = new List<int>();
        List<int> labdaVy = new List<int>();
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void uto_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            if (rnd.NextDouble() < 10000000)
            {
                PictureBox labda = new PictureBox();
                int vx = rnd.Next(-5, 6);
                int vy = rnd.Next(2, 6);

                labda.Location = new Point(ClientRectangle.Width / 2, 0);
                labda.Size = new Size(25, 25);
                labda.Image = Image.FromFile("..\\..\\..\\lapda.png");
                labda.SizeMode = PictureBoxSizeMode.StretchImage;
                labdak.Add(labda);
                labdaVx.Add(vx);
                labdaVy.Add(vy);
                Controls.Add(labda);

            }
            for (int i = 0; i < labdak.Count; i++)
            {
                int newLeft = labdak[i].Left + labdaVx[i];
                int newTop = labdak[i].Top + labdaVy[i];
                if (newLeft < 0)
                {
                    labdaVx[i] *= -1;
                }
                else if (newTop < 0)
                {
                    labdaVy[i] *= -1;
                }
                else if (newLeft + labdak[i].Width > ClientRectangle.Width)
                {
                    labdaVx[i] *= -1;
                }
                else
                {
                    labdak[i].Top = newTop;
                    labdak[i].Left = newLeft;
                }
            }
            int n = 0;
            while (n < labdak.Count)
            {
                if (labdak[n].Top > ClientRectangle.Height)
                {
                    Controls.Remove(labdak[n]);
                    labdak.RemoveAt(n);
                    labdaVx.RemoveAt(n);
                    labdaVy.RemoveAt(n);
                }
                else n++;
            }
        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (uto.Left > 10)
                {
                    uto.Left -= 10;
                }
            }
            else if (e.KeyCode == Keys.Right)
            {
                if(uto.Left + uto.Width+10 < ClientRectangle.Width)
                {
                    uto.Left += 10;
                }
            }
        }
    }
}
