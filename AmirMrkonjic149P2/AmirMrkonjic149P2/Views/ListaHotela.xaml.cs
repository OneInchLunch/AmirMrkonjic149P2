using AmirMrkonjic149P2.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AmirMrkonjic149P2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListaHotela : ContentPage
    {
        public ObservableCollection<Hotel> hotelsList { get; set;}
        public ListaHotela()
        {
            hotelsList = new ObservableCollection<Hotel>();
            hotelsList.Add(new Hotel("1", "Hotel Tarcin", "5",
               "Tarcin Forest Resort & Spa Sarajevo", "Vilovac B B, Sarajevo 7124", "3", "Breakfast",
               "Duis vestibulum elit vel neque pharetra vulputate. Quisque scelerisque nisi urna. Duis rutrum non risus in imperdiet.",
               "tarcin.jpg", 250.0, 17.27059, 44.34203));
            hotelsList.Add(new Hotel("2", "Hotel Blanca", "5",
               "Hotel Blanca Resort & Spa", "Babanovac Bb Vlašić, 72286", "5", "All Inclusive",
               "Duis vestibulum elit vel neque pharetra vulputate. Quisque scelerisque nisi urna. Duis rutrum non risus in imperdiet.",
               "blanca.jpg", 350.0, 17.191000, 44.772182));
            hotelsList.Add(new Hotel("3", "Hotel Europe", "5",
               "Stay in the heart of Sarajevo", "Vladislava Skarica 5, Sarajevo 71000", "7", "All Inclusive",
               "Duis vestibulum elit vel neque pharetra vulputate. Quisque scelerisque nisi urna. Duis rutrum non risus in imperdiet.",
               "europa.jpg", 450.0, 17.66583, 44.22637));
            hotelsList.Add(new Hotel("4", "Hotel Swissotel", "5",
               "Get the celebrity treatment with world-class service", "Vrbanja 1, Sarajevo 71000", "3", "Breakfast",
               "Duis vestibulum elit vel neque pharetra vulputate. Quisque scelerisque nisi urna. Duis rutrum non risus in imperdiet.",
               "swiss.jpg", 550.0, 18.413029, 43.856430));
            hotelsList.Add(new Hotel("5", "Hotel Malak", "5",
               "Malak Regency Hotel", "Ilidža bb, Sarajevo 71000", "8", "Breakfast",
               "Duis vestibulum elit vel neque pharetra vulputate. Quisque scelerisque nisi urna. Duis rutrum non risus in imperdiet.",
               "malak.jpg", 650.0, 15.868565, 44.811962));

            InitializeComponent();
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Hotel hot = e.Item as Hotel;
            await Navigation.PushModalAsync(new DetaljiHotela());
        }
        

    }
}
