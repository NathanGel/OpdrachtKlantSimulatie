using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlantSimulator
{
    public class Klant
    {
        public Klant(int klantNr, string voornaam, string achterNaam, Adres adres) {
            KlantNr = klantNr;
            Voornaam = voornaam;
            AchterNaam = achterNaam;
            Adres = adres;
        }

        public int KlantNr { get; set; }
        public string Voornaam { get; set; }
        public string AchterNaam { get; set; }
        public Adres Adres { get; set; }

    }
}
