namespace _0311_szamologepKetablakos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Ltextbox = new TextBox();
            button1 = new Button();
            clearButton = new Button();
            button3 = new Button();
            button4 = new Button();
            AdditionButton = new Button();
            SubstractButton = new Button();
            DivisionButton = new Button();
            MultiplyButton = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            LdelButton = new Button();
            button19 = new Button();
            solveButton = new Button();
            richTextBox1 = new RichTextBox();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // Ltextbox
            // 
            Ltextbox.Enabled = false;
            Ltextbox.Font = new Font("Cascadia Code", 72F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Ltextbox.Location = new Point(12, 12);
            Ltextbox.Name = "Ltextbox";
            Ltextbox.Size = new Size(344, 119);
            Ltextbox.TabIndex = 0;
            Ltextbox.Text = "0";
            Ltextbox.TextAlign = HorizontalAlignment.Right;
            // 
            // button1
            // 
            button1.Location = new Point(362, 318);
            button1.Name = "button1";
            button1.Size = new Size(50, 50);
            button1.TabIndex = 2;
            button1.Text = "Sqrt";
            button1.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(418, 318);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(50, 50);
            clearButton.TabIndex = 3;
            clearButton.Text = "Anyád";
            clearButton.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(474, 318);
            button3.Name = "button3";
            button3.Size = new Size(50, 50);
            button3.TabIndex = 4;
            button3.Text = "bu'on";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(530, 318);
            button4.Name = "button4";
            button4.Size = new Size(50, 50);
            button4.TabIndex = 5;
            button4.Text = "bu'on";
            button4.UseVisualStyleBackColor = true;
            // 
            // AdditionButton
            // 
            AdditionButton.Location = new Point(362, 262);
            AdditionButton.Name = "AdditionButton";
            AdditionButton.Size = new Size(50, 50);
            AdditionButton.TabIndex = 6;
            AdditionButton.Text = "+";
            AdditionButton.UseVisualStyleBackColor = true;
            AdditionButton.Click += OperationClick;
            // 
            // SubstractButton
            // 
            SubstractButton.Location = new Point(418, 262);
            SubstractButton.Name = "SubstractButton";
            SubstractButton.Size = new Size(50, 50);
            SubstractButton.TabIndex = 7;
            SubstractButton.Text = "-";
            SubstractButton.UseVisualStyleBackColor = true;
            SubstractButton.Click += OperationClick;
            // 
            // DivisionButton
            // 
            DivisionButton.Location = new Point(474, 262);
            DivisionButton.Name = "DivisionButton";
            DivisionButton.Size = new Size(50, 50);
            DivisionButton.TabIndex = 8;
            DivisionButton.Text = "/";
            DivisionButton.UseVisualStyleBackColor = true;
            DivisionButton.Click += OperationClick;
            // 
            // MultiplyButton
            // 
            MultiplyButton.Location = new Point(530, 262);
            MultiplyButton.Name = "MultiplyButton";
            MultiplyButton.Size = new Size(50, 50);
            MultiplyButton.TabIndex = 9;
            MultiplyButton.Text = "*";
            MultiplyButton.UseVisualStyleBackColor = true;
            MultiplyButton.Click += OperationClick;
            // 
            // button9
            // 
            button9.Location = new Point(93, 299);
            button9.Name = "button9";
            button9.Size = new Size(75, 69);
            button9.TabIndex = 10;
            button9.Text = "2";
            button9.UseVisualStyleBackColor = true;
            button9.Click += LbuttonsClick;
            // 
            // button10
            // 
            button10.Location = new Point(12, 137);
            button10.Name = "button10";
            button10.Size = new Size(75, 75);
            button10.TabIndex = 11;
            button10.Text = "7";
            button10.UseVisualStyleBackColor = true;
            button10.Click += LbuttonsClick;
            // 
            // button11
            // 
            button11.Location = new Point(93, 137);
            button11.Name = "button11";
            button11.Size = new Size(75, 75);
            button11.TabIndex = 12;
            button11.Text = "8";
            button11.UseVisualStyleBackColor = true;
            button11.Click += LbuttonsClick;
            // 
            // button12
            // 
            button12.Location = new Point(174, 137);
            button12.Name = "button12";
            button12.Size = new Size(75, 75);
            button12.TabIndex = 13;
            button12.Text = "9";
            button12.UseVisualStyleBackColor = true;
            button12.Click += LbuttonsClick;
            // 
            // button13
            // 
            button13.Location = new Point(12, 218);
            button13.Name = "button13";
            button13.Size = new Size(75, 75);
            button13.TabIndex = 14;
            button13.Text = "4";
            button13.UseVisualStyleBackColor = true;
            button13.Click += LbuttonsClick;
            // 
            // button14
            // 
            button14.Location = new Point(93, 218);
            button14.Name = "button14";
            button14.Size = new Size(75, 75);
            button14.TabIndex = 15;
            button14.Text = "5";
            button14.UseVisualStyleBackColor = true;
            button14.Click += LbuttonsClick;
            // 
            // button15
            // 
            button15.Location = new Point(174, 218);
            button15.Name = "button15";
            button15.Size = new Size(75, 75);
            button15.TabIndex = 16;
            button15.Text = "6";
            button15.UseVisualStyleBackColor = true;
            button15.Click += LbuttonsClick;
            // 
            // button16
            // 
            button16.Location = new Point(174, 299);
            button16.Name = "button16";
            button16.Size = new Size(75, 69);
            button16.TabIndex = 17;
            button16.Text = "3";
            button16.UseVisualStyleBackColor = true;
            button16.Click += LbuttonsClick;
            // 
            // button17
            // 
            button17.Location = new Point(12, 299);
            button17.Name = "button17";
            button17.Size = new Size(75, 69);
            button17.TabIndex = 18;
            button17.Text = "1";
            button17.UseVisualStyleBackColor = true;
            button17.Click += LbuttonsClick;
            // 
            // LdelButton
            // 
            LdelButton.BackColor = SystemColors.Control;
            LdelButton.Location = new Point(256, 137);
            LdelButton.Name = "LdelButton";
            LdelButton.Size = new Size(100, 119);
            LdelButton.TabIndex = 19;
            LdelButton.Text = "ELPUSZTÍT!!";
            LdelButton.UseVisualStyleBackColor = false;
            LdelButton.Click += LdelButton_Click;
            // 
            // button19
            // 
            button19.Location = new Point(12, 374);
            button19.Name = "button19";
            button19.Size = new Size(156, 65);
            button19.TabIndex = 20;
            button19.Text = "0";
            button19.UseVisualStyleBackColor = true;
            button19.Click += LbuttonsClick;
            // 
            // solveButton
            // 
            solveButton.Font = new Font("Showcard Gothic", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            solveButton.Location = new Point(256, 262);
            solveButton.Name = "solveButton";
            solveButton.Size = new Size(100, 106);
            solveButton.TabIndex = 21;
            solveButton.Text = "=";
            solveButton.UseVisualStyleBackColor = true;
            solveButton.Click += OperationClick;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(256, 373);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(324, 65);
            richTextBox1.TabIndex = 22;
            richTextBox1.Text = "   This is a SZÁMOLÓGÉP   !!!  ";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(362, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(213, 244);
            listBox1.TabIndex = 23;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(587, 450);
            Controls.Add(listBox1);
            Controls.Add(richTextBox1);
            Controls.Add(solveButton);
            Controls.Add(button19);
            Controls.Add(LdelButton);
            Controls.Add(button17);
            Controls.Add(button16);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(MultiplyButton);
            Controls.Add(DivisionButton);
            Controls.Add(SubstractButton);
            Controls.Add(AdditionButton);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(clearButton);
            Controls.Add(button1);
            Controls.Add(Ltextbox);
            Name = "Form1";
            Text = "Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Ltextbox;
        private TextBox Rtextbox;
        private Button button1;
        private Button clearButton;
        private Button button3;
        private Button button4;
        private Button AdditionButton;
        private Button SubstractButton;
        private Button DivisionButton;
        private Button MultiplyButton;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button LdelButton;
        private Button button19;
        private Button solveButton;
        private RichTextBox richTextBox1;
        private ListBox listBox1;
    }
}
