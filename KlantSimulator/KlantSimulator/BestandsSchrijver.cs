using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlantSimulator
{
    public class BestandsSchrijver
    {
        public void SchrijfNaarBestand(List<Klant> klanten, string pad) {
            using (StreamWriter sw = new(pad)) {
                foreach(Klant klant in klanten) {
                    sw.WriteLine($"{klant.KlantNr}|{klant.Voornaam}|{klant.AchterNaam}|{klant.Adres.GemeenteNaam}|{klant.Adres.Postcode}|{klant.Adres.StraatNaam}|{klant.Adres.HuisNr}");
                }
            }
        }
    }
}
