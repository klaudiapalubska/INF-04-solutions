namespace app_03
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
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            button1 = new Button();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            textBox3 = new TextBox();
            label4 = new Label();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(95, 116);
            groupBox1.Margin = new Padding(10, 3, 3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(780, 575);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dane Pracownika";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Kierownik", "Starszy programista", "Młodszy programista", "Tester" });
            comboBox1.Location = new Point(320, 263);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(332, 49);
            comboBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(320, 171);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(332, 47);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(320, 74);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(332, 47);
            textBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 263);
            label3.Name = "label3";
            label3.Size = new Size(168, 41);
            label3.TabIndex = 2;
            label3.Text = "Stanowisko";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 171);
            label2.Name = "label2";
            label2.Size = new Size(144, 41);
            label2.TabIndex = 1;
            label2.Text = "Nazwisko";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 74);
            label1.Name = "label1";
            label1.Size = new Size(75, 41);
            label1.TabIndex = 0;
            label1.Text = "Imię";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(checkBox3);
            groupBox2.Controls.Add(checkBox2);
            groupBox2.Controls.Add(checkBox1);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(982, 121);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(10, 3, 3, 3);
            groupBox2.Size = new Size(753, 570);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Generowanie hasła";
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.ForeColor = Color.White;
            button1.Location = new Point(284, 445);
            button1.Name = "button1";
            button1.Size = new Size(218, 58);
            button1.TabIndex = 5;
            button1.Text = "Generuj hasło";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(89, 334);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(258, 45);
            checkBox3.TabIndex = 4;
            checkBox3.Text = "Znaki specjalne";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(89, 254);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(124, 45);
            checkBox2.TabIndex = 3;
            checkBox2.Text = "Cyfry";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(89, 165);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(308, 45);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "Małe i wielkie litery";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(344, 81);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(285, 47);
            textBox3.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(89, 84);
            label4.Name = "label4";
            label4.Size = new Size(171, 41);
            label4.TabIndex = 0;
            label4.Text = "Ile znaków?";
            // 
            // button2
            // 
            button2.BackColor = Color.SteelBlue;
            button2.ForeColor = Color.White;
            button2.Location = new Point(652, 794);
            button2.Name = "button2";
            button2.Size = new Size(530, 60);
            button2.TabIndex = 2;
            button2.Text = "Zatwierdź";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1849, 938);
            Controls.Add(button2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Dodaj Pracownika PESEL";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Button button1;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private TextBox textBox3;
        private Label label4;
        private Button button2;
    }
}