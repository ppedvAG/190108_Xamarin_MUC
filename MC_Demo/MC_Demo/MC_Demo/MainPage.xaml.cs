using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MC_Demo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            MessagingCenter.Subscribe<Slider, double>(this, "SliderValueChanged", NachrichtVomSlider);
        }

        private void NachrichtVomSlider(Slider arg1, double arg2)
        {
            entryWertAusSlider.Text = arg2.ToString();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Seite2());
        }
    }
}
