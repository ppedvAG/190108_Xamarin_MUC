using MVVM_Demo.Models;
using MVVM_Demo.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace MVVM_Demo.ViewModels
{
    class MainViewModel : BaseViewModel
    {
        public MainViewModel()
        {
            // Controllfreak-Antipattern
            service = new PersonenService();
            GetPersonenCommand = new Command(GetPersonen);
        }

        private void GetPersonen(object obj)
        {
            Personenliste = service.GetPersonen();
        }

        private readonly PersonenService service;

        private List<Person> personenliste;
        public List<Person> Personenliste
        {
            get => personenliste;
            set => SetProperty(ref personenliste, value);
        }
        public Command GetPersonenCommand { get; set; }
    }
}
