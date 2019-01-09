using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListViewDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        //private List<PersonenGruppe> data;

        //private void Button_Clicked(object sender, EventArgs e)
        //{
        //    GetData();
        //    listViewPersonen.ItemsSource = data;
        //}

        //private void GetData()
        //{
        //    PersonenGruppe g1 = new PersonenGruppe
        //    {
        //         new Person{Vorname="Tom",Nachname="Ate",Alter=10,Kontostand=100m},
        //         new Person{Vorname="Anna",Nachname="Nass",Alter=20,Kontostand=2000m},
        //         new Person{Vorname="Peter",Nachname="Silie",Alter=30,Kontostand=-3000m},
        //         new Person{Vorname="Franz",Nachname="Ose",Alter=40,Kontostand=0m}
        //    };
        //    g1.Titel = "Jung";
        //    g1.Kurztitel = "J";

        //    PersonenGruppe g2 = new PersonenGruppe
        //    {
        //        new Person{Vorname="Martha",Nachname="Pfahl",Alter=50,Kontostand=5555200m},
        //        new Person{Vorname="Klara",Nachname="Fall",Alter=60,Kontostand=-212300m},
        //        new Person{Vorname="Rainer",Nachname="Zufall",Alter=70,Kontostand=70m},
        //        new Person{Vorname="Bill",Nachname="Dung",Alter=80,Kontostand=25678900m},
        //    };
        //    g2.Titel = "Alt";
        //    g2.Kurztitel = "A";

        //    PersonenGruppe g3 = new PersonenGruppe
        //    {
        //      new Person{Vorname="Anna",Nachname="Bolika",Alter=90,Kontostand=1111200m},
        //      new Person{Vorname="Axel",Nachname="Schweiß",Alter=100,Kontostand=-0.99m}
        //    };
        //    g3.Titel = "Grufti";
        //    g3.Kurztitel = "G";

        //    data = new List<PersonenGruppe> { g1, g2, g3 };
        //}

        //private void ListViewPersonen_Refreshing(object sender, EventArgs e)
        //{
        //    GetData();
        //    listViewPersonen.ItemsSource = data;
        //    // Variante 1)
        //    // listViewPersonen.IsRefreshing = false;

        //    // Variante 2)
        //    listViewPersonen.EndRefresh();
        //}

        //private void SearchBarVorname_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //    // listViewPersonen.ItemsSource = data.Where(x => x.Vorname.ToLower().StartsWith(searchBarVorname.Text.ToLower())).ToList();
        //    listViewPersonen.ItemsSource = data.SelectMany(x => x.Items).Where(x => x.Vorname.ToLower().StartsWith(searchBarVorname.Text.ToLower())).ToList();
        //}
    }
}
