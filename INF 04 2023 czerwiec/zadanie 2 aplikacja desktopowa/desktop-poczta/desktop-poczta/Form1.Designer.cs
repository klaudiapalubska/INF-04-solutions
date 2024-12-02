namespace desktop_poczta
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
            groupBox1 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            button1 = new Button();
            label1 = new Label();
            groupBox2 = new GroupBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(99, 84);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(617, 319);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Rodzaj przesyłki";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(37, 229);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(144, 45);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Paczka";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(37, 152);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(99, 45);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "List";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(37, 75);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(197, 45);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Pocztówka";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(99, 450);
            button1.Name = "button1";
            button1.Size = new Size(617, 55);
            button1.TabIndex = 1;
            button1.Text = "Sprawdź cenę";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(587, 664);
            label1.Name = "label1";
            label1.Size = new Size(172, 67);
            label1.TabIndex = 3;
            label1.Text = "Cena: ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(988, 84);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(859, 711);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dane adresowe:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(57, 495);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(718, 47);
            textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(57, 322);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(250, 47);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(57, 150);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(718, 47);
            textBox1.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 431);
            label4.Name = "label4";
            label4.Size = new Size(108, 41);
            label4.TabIndex = 2;
            label4.Text = "Miasto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 259);
            label3.Name = "label3";
            label3.Size = new Size(207, 41);
            label3.TabIndex = 1;
            label3.Text = "Kod pocztowy";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 95);
            label2.Name = "label2";
            label2.Size = new Size(240, 41);
            label2.TabIndex = 0;
            label2.Text = "Ulica z numerem";
            // 
            // button2
            // 
            button2.Location = new Point(99, 974);
            button2.Name = "button2";
            button2.Size = new Size(1748, 75);
            button2.TabIndex = 5;
            button2.Text = "Zatwierdź";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pocztowka;
            pictureBox1.Location = new Point(99, 552);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(433, 388);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(2069, 1076);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button button1;
        private Label label1;
        private GroupBox groupBox2;
        private Label label2;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Button button2;
        private PictureBox pictureBox1;
    }
}