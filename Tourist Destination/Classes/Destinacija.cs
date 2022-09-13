using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Destinacija
    {
        public String Slika { get; set; }
        public String Naziv { get; set; }
        public String Agencija { get; set; }
        public int Cena { get; set; }
        public DateTime DatumPolaska { get; set; }
        public String Putanja { get; set; }

        public Destinacija()
        {

        }

        public Destinacija(string slika, string naziv, string agencija, int cena, DateTime datumPolaska, string putanja)
        {
            Slika = slika;
            Naziv = naziv;
            Agencija = agencija;
            Cena = cena;
            DatumPolaska = datumPolaska;
            Putanja = putanja;
        }
    }
}