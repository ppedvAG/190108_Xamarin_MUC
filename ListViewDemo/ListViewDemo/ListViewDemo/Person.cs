using System;
using System.Collections.Generic;
using System.Text;

namespace ListViewDemo
{
    class Person
    {
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public byte Alter { get; set; }
        public decimal Kontostand { get; set; }
    }

    class PersonenGruppe : List<Person>
    {
        public string Titel { get; set; }
        public string Kurztitel { get; set; }
        public List<Person> Items => this;
    }
}
