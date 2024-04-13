namespace WordGuessingGameWindowsApp
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
            textBox1 = new TextBox();
            Guessing1 = new Button();
            button3 = new Button();
            listBox1 = new ListBox();
            textBox2 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Beige;
            textBox1.Location = new Point(77, 303);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(336, 33);
            textBox1.TabIndex = 1;
            // 
            // Guessing1
            // 
            Guessing1.BackColor = Color.Silver;
            Guessing1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Guessing1.Location = new Point(138, 357);
            Guessing1.Name = "Guessing1";
            Guessing1.Size = new Size(206, 54);
            Guessing1.TabIndex = 2;
            Guessing1.Text = "Guess";
            Guessing1.UseVisualStyleBackColor = false;
            Guessing1.Click += Guessing1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(128, 255, 128);
            button3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(580, 140);
            button3.Name = "button3";
            button3.Size = new Size(201, 41);
            button3.TabIndex = 3;
            button3.Text = "Wrong Guess";
            button3.UseVisualStyleBackColor = false;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.Beige;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(537, 187);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(313, 264);
            listBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(255, 128, 128);
            textBox2.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(21, 140);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(479, 147);
            textBox2.TabIndex = 6;
            textBox2.Text = "\r\n                c??????r";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(281, 29);
            label1.Name = "label1";
            label1.Size = new Size(303, 45);
            label1.TabIndex = 7;
            label1.Text = "Guess The Word";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(883, 536);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(listBox1);
            Controls.Add(button3);
            Controls.Add(Guessing1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private Button Guessing1;
        private Button button3;
        private ListBox listBox1;
        private TextBox textBox2;
        private Label label1;
    }
}
