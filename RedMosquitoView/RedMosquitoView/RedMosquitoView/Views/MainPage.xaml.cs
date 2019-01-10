using RedMosquitoView.Models;
using RedMosquitoView.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RedMosquitoView
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var item = e.Item as WebCamItem;
            // Device.OpenUri(item.Url);
            Navigation.PushAsync(new WebCamPage(item));
        }
    }
}
