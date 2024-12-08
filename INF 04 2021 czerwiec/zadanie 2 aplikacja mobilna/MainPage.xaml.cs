using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace rejestracjakonta
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string emailEntry = email.Text;
            if (haslo.Text != haslo2.Text || haslo.Text == null)
            {
                 komunikat.Text = "Hasła się różnią"; 
            }else if (emailEntry.Contains("@") && haslo.Text == haslo2.Text)
            {
              
                    komunikat.Text = "Witaj "+emailEntry;
            }
            else
            {
                komunikat.Text = "Nieprawidłowy adres email";
            }
        }
    }
}
