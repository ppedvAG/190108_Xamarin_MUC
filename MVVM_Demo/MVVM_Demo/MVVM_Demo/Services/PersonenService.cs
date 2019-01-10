using MVVM_Demo.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVVM_Demo.Services
{
    class PersonenService
    {
        public List<Person> GetPersonen()
        {
            return new List<Person>
            {
                new Person{Vorname="Tom",Nachname="Ate",Alter=10,Kontostand=100m},
                new Person{Vorname="Anna",Nachname="Nass",Alter=20,Kontostand=2000m},
                new Person{Vorname="Peter",Nachname="Silie",Alter=30,Kontostand=-3000m},
                new Person{Vorname="Franz",Nachname="Ose",Alter=40,Kontostand=0m},
                new Person{Vorname="Martha",Nachname="Pfahl",Alter=50,Kontostand=5555200m},
                new Person{Vorname="Klara",Nachname="Fall",Alter=60,Kontostand=-212300m},
                new Person{Vorname="Rainer",Nachname="Zufall",Alter=70,Kontostand=70m},
                new Person{Vorname="Bill",Nachname="Dung",Alter=80,Kontostand=25678900m},
                new Person{Vorname="Anna",Nachname="Bolika",Alter=90,Kontostand=1111200m},
                new Person{Vorname="Axel",Nachname="Schweiß",Alter=100,Kontostand=-0.99m}
            };
        }
    }
}
