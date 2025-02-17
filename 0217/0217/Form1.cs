using System.Linq.Expressions;

namespace _0217
{
    public partial class foablak : Form
    {
        string teljesSzoveg;
        string[] szovegSoronkent;
        string path = @"..\..\..\be1.txt";
        public foablak()
        {
            InitializeComponent();
        }

        private void foablak_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Szia bojler eladó", "helo", MessageBoxButtons.OK);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void beolvasGomb_Click(object sender, EventArgs e)
        {
            string fajlUtvonal = fileNameText.Text;
            string fajlUt2 = @"..\..\..\" + fileNameText.Text;
            if (File.Exists(fajlUt2))
            {
                teljesSzoveg = File.ReadAllText(fajlUt2, System.Text.Encoding.UTF8);
                szovegMegjelenito.Text = teljesSzoveg;
            }
            else
            {
                MessageBox.Show("bibibi", "bibibi");
            }
            //szovegMegjelenito.Text = teljesSzoveg;


        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            File.WriteAllText(path, szovegMegjelenito.Text, System.Text.Encoding.UTF8);
            MessageBox.Show("Sikeredett a írás");
        }

        private void readLnBtn_Click(object sender, EventArgs e)
        {
            string FajlUt2 = @"..\..\..\" + fileNameText.Text;

            if (File.Exists(FajlUt2))
            {
                StreamReader sr = new StreamReader(FajlUt2);
                List<string> sorok = new List<string>();
                string sor = sr.ReadLine();
                while (sor != null)
                {
                    if (sor.Trim() != "")
                    {
                        sorok.Add(sor.Trim());
                    }
                    sor = sr.ReadLine();
                }
                sr.Close();
                szovegMegjelenito.Lines = sorok.ToArray();

                string[] nev = new string[sorok.Count];
                string[] datum = new string[sorok.Count];
                string[] varos = new string[sorok.Count];
                int[] pontszam = new int[sorok.Count];

                for (int i = 0; i < sorok.Count; i++)
                {
                    string[] darabolva = sorok[i].Split(";");
                    nev[i] = darabolva[0];
                    datum[i] = darabolva[1];
                    varos[i] = darabolva[2];
                    pontszam[i] = int.Parse(darabolva[3]);
                }
                int maxPont = pontszam.Max();
                int kivolt = Array.IndexOf(pontszam, maxPont);
                consoleOut.Text = $"Ez elsöprõ, {nev[kivolt]}, {maxPont}";
            }
        }
    }
}
