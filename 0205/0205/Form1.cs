using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0205
{
    public partial class Form1 : Form
    {
        int szamlalo;
        Random rnd = new Random();

        PictureBox[,] kepek = new PictureBox[6, 8];
        int[,] deltax = new int[6, 8];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int x = 0; x < kepek.GetLength(0); x++)
            {
                for (int y = 0; y < kepek.GetLength(1); y++)
                {
                    kepek[x, y] = new PictureBox();
                    kepek[x, y].Location = new Point(100+105*x, 100+105*y);
                    kepek[x, y].Size = new Size(100, 100);
                    kepek[x, y].Image = Image.FromFile(@"d:/palffymate/pmate/0205/kula.png");
                    kepek[x, y].Name = "kep" + x.ToString() + "_" + y.ToString();
                    Controls.Add(kepek[x, y]);
                    deltax[x, y] = rnd.Next(1, 10);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            szamlalo++;
            button1.Font = new Font("Papyrus", szamlalo*10);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button1.Left = rnd.Next(0, Width-button1.Width/2);
            button1.Top = rnd.Next(0, Height-button1.Height/2); 
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
