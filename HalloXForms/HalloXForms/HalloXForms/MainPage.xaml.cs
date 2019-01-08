using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HalloXForms
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            // MessageBox
            DisplayAlert("Meine erste Nachricht", "Hallo Welt", "OK");
            
            // "Ja/Nein"- MessageBox
            DisplayAlert("Wichtige Frage", "Pause ???", "Ja", "Nein");

            // "Combobox-Dialog"
            DisplayActionSheet("Wähle ein Obst", "Ok", "Abbrechen", new string[] { "Apfel", "Birne", "Banane" });
        }
    }
}
