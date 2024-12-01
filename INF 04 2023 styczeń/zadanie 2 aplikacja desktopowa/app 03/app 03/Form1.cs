using System.Diagnostics;

namespace app_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int RandomowaLiczba(int liczba, int liczba2)
        {
            Random random = new Random();
            return random.Next(liczba, liczba2);

        }

        public string Haslo { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            int iloscznakow = int.Parse(textBox3.Text);
            string haslo = "";
            string litery = "qwertyuiopasdfghjklzxcvbnm";
            string specjalneZnaki = "!@#$%^&*()_-=+`~{[}];:'\'<>.,?/";
            if (checkBox1.Checked)
            {

                haslo += litery[RandomowaLiczba(0, 25)];
                haslo = haslo.ToUpper();
                iloscznakow--;
            }
            if (checkBox2.Checked)
            {

                haslo += RandomowaLiczba(0, 10);
                iloscznakow--;
            }
            if (checkBox3.Checked)
            {

                haslo += specjalneZnaki[RandomowaLiczba(0, 30)];
                iloscznakow--;
            }
            for (int i = 0; i < iloscznakow; i++)
            {
                haslo += litery[RandomowaLiczba(0, 25)];
            }
            Haslo = haslo;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dane pracownika: "+textBox1.Text + " "+textBox2.Text+" "+comboBox1.Text+ " Haslo: "+ Haslo);
        }
    }
}