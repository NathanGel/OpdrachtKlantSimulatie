using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlantSimulator
{
    public class SessieBeheer
    {
        public List<Klant> Uitvoer(List<string> voornamen, List<string> achternamen, List<string> straatnamen, List<int> postcodes, Dictionary<int, string> gemeenten) {
            List<Klant> klanten = new();
            HashSet<int> klantenNummers = new();
            Random rnd = new();
            try {
                for (int i = 0; i < 100; i++) {
                    int klantNr = rnd.Next(100000, 1000000);
                    string voornaam = voornamen[rnd.Next(0, 10)];
                    string achternaam = achternamen[rnd.Next(0, 10)];
                    string straatnaam = straatnamen[rnd.Next(0, 10)];
                    int postcode = postcodes[rnd.Next(0, 9)];
                    string gemeente = gemeenten[postcode];
                    int huisnummer = rnd.Next(1, 101);
                    Klant klant = new(klantNr, voornaam, achternaam, new Adres(postcode, gemeente, straatnaam, huisnummer));
                    klanten.Add(klant);
                }
            }catch(Exception e) {
                Console.WriteLine(e);
            }
            return klanten;
        }
    }
}
