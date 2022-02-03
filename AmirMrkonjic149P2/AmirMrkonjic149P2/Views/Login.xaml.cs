using AmirMrkonjic149P2.Models;
using AmirMrkonjic149P2.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AmirMrkonjic149P2
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Clicked(object sender, EventArgs e)
        {
            if (EmailInput.Text == User.Username && PasswordInput.Text == User.Password)
                Navigation.PushAsync(new ListaHotela());
            else
                DisplayAlert("Greška", "Pogrešan unos, pokušajte ponovo", "OK");

        }
    }
}
