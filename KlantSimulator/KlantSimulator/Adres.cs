using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlantSimulator
{
    public class Adres
    {
        public Adres(int postcode, string gemeenteNaam, string straatNaam, int huisNr) {
            Postcode = postcode;
            GemeenteNaam = gemeenteNaam;
            StraatNaam = straatNaam;
            HuisNr = huisNr;
        }

        public int Postcode { get; set; }
        public string GemeenteNaam { get; set; }
        public string StraatNaam { get; set; }
        public int HuisNr { get; set; }
    }
}
