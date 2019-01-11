using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DatenSpeichernUndLaden
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SQLitePage : ContentPage
	{

        public SQLitePage ()
		{
			InitializeComponent ();
            
            //if(Device.RuntimePlatform == Device.Android)
            //{
            //    // ....
            //}

            var fullPath = Path.Combine(FileSystem.AppDataDirectory, "db.sqlite");
            con = new SQLiteConnection(fullPath);
            DisplayAlert("Pfad:",fullPath,"Ok");
            con.CreateTable<Person>(); // Wenn die Tabelle bereits existiert, passiert nichts 


            // ApplicationProperties
            App.Current.Properties.Add("demo", "12345");
            // Speichert automatisch bei OnSleep(); 

            // Alternative, zB gemeinsam mit Dissappearing() => 
            App.Current.SavePropertiesAsync();
		}
        private SQLiteConnection con;

        private void ButtonNeuePerson_Clicked(object sender, EventArgs e)
        {
            Person p = new Person { Vorname = "Max",Körpergröße = 2, Alter = 20, Kontostand = 500m };
            con.Insert(p);

            DisplayAlert("Einfügen", "Neue Person wurde erfolgreich eingefügt", "Ok");
        }

        private void ButtonDatenLaden_Clicked(object sender, EventArgs e)
        {
            listViewPersonen.ItemsSource = con.Table<Person>();
        }

        private void ListViewPersonen_Refreshing(object sender, EventArgs e)
        {
            listViewPersonen.ItemsSource = con.Table<Person>();
            listViewPersonen.EndRefresh();
        }
    }
}