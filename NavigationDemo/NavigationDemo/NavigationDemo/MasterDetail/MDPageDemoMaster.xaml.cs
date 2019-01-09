using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NavigationDemo.MasterDetail
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MDPageDemoMaster : ContentPage
    {
        public ListView ListView;

        public MDPageDemoMaster()
        {
            InitializeComponent();

            BindingContext = new MDPageDemoMasterViewModel();
            ListView = MenuItemsListView;
        }

        class MDPageDemoMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MDPageDemoMenuItem> MenuItems { get; set; }
            
            public MDPageDemoMasterViewModel()
            {
                MenuItems = new ObservableCollection<MDPageDemoMenuItem>(new[]
                {
                    new MDPageDemoMenuItem { Id = 0, Title = "Page 1" },
                    new MDPageDemoMenuItem { Id = 1, Title = "Page 2" },
                    new MDPageDemoMenuItem { Id = 2, Title = "Page 3" },
                    new MDPageDemoMenuItem { Id = 3, Title = "Page 4" },
                    new MDPageDemoMenuItem { Id = 4, Title = "Page 5" },
                });
            }
            
            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}