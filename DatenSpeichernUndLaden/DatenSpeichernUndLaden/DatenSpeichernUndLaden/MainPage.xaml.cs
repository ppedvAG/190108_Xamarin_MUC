using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DatenSpeichernUndLaden
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ButtonSpeichern_Clicked(object sender, EventArgs e)
        {
            var service = DependencyService.Get<ITextHelper>(); // Wenn es keine implementierung gibt => null
            service.SaveText("demo.txt", entryDaten.Text);
            DisplayAlert("Speichern", "Speichern erfolgreich !", "Yay");
        }

        private void ButtonLaden_Clicked(object sender, EventArgs e)
        {
            var service = DependencyService.Get<ITextHelper>(); // Wenn es keine implementierung gibt => null
            DisplayAlert("Laden", service.LoadText("demo.txt"), "Yay");
        }
    }
}
