namespace odciskpalca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "222")
            {
                pictureBox1.Image = Properties.Resources.zdjecie_222;
                pictureBox2.Image = Properties.Resources.odcisk_222;
            }

            if (textBox1.Text == "333")
            {
                pictureBox1.Image = Properties.Resources.zdjecie_333;
                pictureBox2.Image = Properties.Resources.odcisk_333;
            }

            ///Brak zdjec do egzaminu wiec robie tylko do dwoch zdjec ta mechanike bo mi sie nie chce
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string oczy = "";
            if (radioButton1.Checked == true) oczy = radioButton1.Text;
            if (radioButton2.Checked == true) oczy = radioButton2.Text;
            if (radioButton3.Checked == true) oczy = radioButton3.Text;

            if (textBox2.Text != "" && textBox3.Text != "") {
                MessageBox.Show(textBox2.Text + " " + textBox3.Text + " kolor oczu " + oczy);
            }
            else
            {
                MessageBox.Show("Wprowadü dane");
            }
        }
    }
}