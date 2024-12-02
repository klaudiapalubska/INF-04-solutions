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
                label1.Text = "Cena: 1z³";
                pictureBox1.Image = Properties.Resources.pocztowka;

            }
            if (radioButton2.Checked)
            {
                label1.Text = "Cena: 1,5z³";
                pictureBox1.Image = Properties.Resources.list;

            }
            if (radioButton3.Checked)
            {
                label1.Text = "Cena: 10z³";
                pictureBox1.Image = Properties.Resources.paczka;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {


            string liczby = "0123456789";

            bool sprawdzlitery = textBox2.Text.All(c => liczby.Contains(c));

            if (sprawdzlitery == false)
            {
                MessageBox.Show("Kod pocztowy powinien siê sk³adaæ z samych cyfr");
            }


            if (textBox2.Text.Length == 5 && sprawdzlitery == true)
            {
                MessageBox.Show("Dane przesy³ki zosta³y wprowadzone");
            }
            if (textBox2.Text.Length != 5 && sprawdzlitery == true)
            {
                MessageBox.Show("Nieprawid³owa liczba cyfr w kodzie pocztowym");
            }


        }
    }
}
