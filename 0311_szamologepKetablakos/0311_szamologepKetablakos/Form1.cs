namespace _0311_szamologepKetablakos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool elsoszam = false;
        int bal, jobb;
        char operation1;
        private void LbuttonsClick(object sender, EventArgs e)
        {
            char numero = (sender as Button).Text[0];
            if (Ltextbox.Text == "0")
            {
                Ltextbox.Text = numero.ToString();
            }
            else
            {
                Ltextbox.Text += numero.ToString();
            }
        }

        private void LdelButton_Click(object sender, EventArgs e)
        {
            Ltextbox.Text = Ltextbox.Text.Substring(0, Ltextbox.Text.Length - 1);
            if (Ltextbox.Text == "")
            {
                Ltextbox.Text = "0";
            }
        }

        private void OperationClick(object sender, EventArgs e)
        {
            int inVal = int.Parse(Ltextbox.Text);
            bool hiba = false;
            int ered = 0;
            char muv = (sender as Button).Text[0];
            
            if (elsoszam)
            {
                switch (muv)
                {
                    case '=':
                        listBox1.Items.Add(Ltextbox.Text + " = " + Ltextbox.Text);
                        Ltextbox.Text = "0";
                        elsoszam = true;
                        break;
                    case '+':
                    case '-':
                    case '*':
                    case '/':
                        bal = int.Parse(Ltextbox.Text);
                        operation1 = muv;
                        listBox1.Items.Add(Ltextbox.Text + " " + operation1.ToString() + " ");
                        elsoszam = false;
                        Ltextbox.Text = "0";
                        break;
                    
                }           
            }
            else
            {
                switch (operation1)
                {
                    case '+':
                        ered = bal + jobb;
                        break;
                    case '-':
                        ered = bal - jobb;
                        break;
                    case '*':
                        ered = bal * jobb;
                        break;
                    case '/':
                        if (jobb != 0)
                        {
                            ered = bal / jobb;
                            break;
                        }
                        else
                        {
                            hiba = true;
                        }
                        break;
                    }
                }
            if (!hiba)
            }

        private void Form1_Load(object sender, EventArgs e)
        {
            elsoszam = true;
            bal = 0;
            jobb = 0;
            operation1 = '=';
        }
    }
}
