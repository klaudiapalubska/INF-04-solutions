namespace desktop_poczta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label1.Text = "Cena: 1z�";
                pictureBox1.Image = Properties.Resources.pocztowka;

            }
            if (radioButton2.Checked)
            {
                label1.Text = "Cena: 1,5z�";
                pictureBox1.Image = Properties.Resources.list;

            }
            if (radioButton3.Checked)
            {
                label1.Text = "Cena: 10z�";
                pictureBox1.Image = Properties.Resources.paczka;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {


            string liczby = "0123456789";

            bool sprawdzlitery = textBox2.Text.All(c => liczby.Contains(c));

            if (sprawdzlitery == false)
            {
                MessageBox.Show("Kod pocztowy powinien si� sk�ada� z samych cyfr");
            }


            if (textBox2.Text.Length == 5 && sprawdzlitery == true)
            {
                MessageBox.Show("Dane przesy�ki zosta�y wprowadzone");
            }
            if (textBox2.Text.Length != 5 && sprawdzlitery == true)
            {
                MessageBox.Show("Nieprawid�owa liczba cyfr w kodzie pocztowym");
            }


        }
    }
}
