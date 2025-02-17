namespace _0217
{
    partial class foablak
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
            fileNameText = new TextBox();
            label1 = new Label();
            beolvasGomb = new Button();
            szovegMegjelenito = new TextBox();
            closeBtn = new Button();
            writeBtn = new Button();
            readLnBtn = new Button();
            consoleOut = new TextBox();
            SuspendLayout();
            // 
            // fileNameText
            // 
            fileNameText.Location = new Point(12, 27);
            fileNameText.Name = "fileNameText";
            fileNameText.Size = new Size(650, 23);
            fileNameText.TabIndex = 0;
            fileNameText.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(278, 15);
            label1.TabIndex = 1;
            label1.Text = "írjad befele a dobozba mely fájlt akarol megnyílni !!!";
            // 
            // beolvasGomb
            // 
            beolvasGomb.Location = new Point(668, 26);
            beolvasGomb.Name = "beolvasGomb";
            beolvasGomb.Size = new Size(120, 23);
            beolvasGomb.TabIndex = 2;
            beolvasGomb.Text = "Gmob ami olvas mer jó gom";
            beolvasGomb.UseVisualStyleBackColor = true;
            beolvasGomb.Click += beolvasGomb_Click;
            // 
            // szovegMegjelenito
            // 
            szovegMegjelenito.Location = new Point(12, 56);
            szovegMegjelenito.Multiline = true;
            szovegMegjelenito.Name = "szovegMegjelenito";
            szovegMegjelenito.Size = new Size(466, 354);
            szovegMegjelenito.TabIndex = 3;
            // 
            // closeBtn
            // 
            closeBtn.Location = new Point(668, 416);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(120, 23);
            closeBtn.TabIndex = 4;
            closeBtn.Text = "menjanyádba'";
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += button1_Click;
            // 
            // writeBtn
            // 
            writeBtn.Location = new Point(550, 416);
            writeBtn.Name = "writeBtn";
            writeBtn.Size = new Size(112, 23);
            writeBtn.TabIndex = 5;
            writeBtn.Text = "írj paraszt";
            writeBtn.UseVisualStyleBackColor = true;
            writeBtn.Click += button1_Click_1;
            // 
            // readLnBtn
            // 
            readLnBtn.Font = new Font("Segoe UI", 6F);
            readLnBtn.Location = new Point(668, 1);
            readLnBtn.Name = "readLnBtn";
            readLnBtn.Size = new Size(120, 23);
            readLnBtn.TabIndex = 6;
            readLnBtn.Text = "olvass a sorok kozott";
            readLnBtn.UseVisualStyleBackColor = true;
            readLnBtn.Click += readLnBtn_Click;
            // 
            // consoleOut
            // 
            consoleOut.Location = new Point(484, 56);
            consoleOut.Multiline = true;
            consoleOut.Name = "consoleOut";
            consoleOut.Size = new Size(304, 354);
            consoleOut.TabIndex = 7;
            // 
            // foablak
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(consoleOut);
            Controls.Add(readLnBtn);
            Controls.Add(writeBtn);
            Controls.Add(closeBtn);
            Controls.Add(szovegMegjelenito);
            Controls.Add(beolvasGomb);
            Controls.Add(label1);
            Controls.Add(fileNameText);
            Name = "foablak";
            Text = "Szövegfájlok";
            Load += foablak_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox fileNameText;
        private Label label1;
        private Button beolvasGomb;
        private TextBox szovegMegjelenito;
        private Button closeBtn;
        private Button writeBtn;
        private Button readLnBtn;
        private TextBox consoleOut;
    }
}
