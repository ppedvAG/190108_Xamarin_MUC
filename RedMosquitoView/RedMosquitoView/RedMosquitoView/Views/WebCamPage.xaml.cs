using Plugin.Media;
using RedMosquitoView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RedMosquitoView.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WebCamPage : ContentPage
    {
        public WebCamPage(WebCamItem item)
        {
            InitializeComponent();
            this.item = item;
            webViewWebcam.Source = item.Url;

        }
        private WebCamItem item;

        private void Button_Clicked(object sender, EventArgs e)
        {
            var location = new Location(item.Latitude, item.Longitude);
            Map.OpenAsync(location);
        }

        private async void ButtonKamera_Clicked(object sender, EventArgs e)
        {
            await CrossMedia.Current.Initialize();

            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
            {
                await DisplayAlert("No Camera", ":( No camera available.", "OK");
                return;
            }

            var file = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions
            {
                Directory = "Sample",
                Name = "test.jpg"
            });

            if (file == null)
                return;

            await DisplayAlert("File Location", file.Path, "OK");
        }
    }
}