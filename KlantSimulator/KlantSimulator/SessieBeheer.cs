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
                for (int i = 0; i < 10001; i++) {
                    int klantNr;
                    do {
                        klantNr = rnd.Next(1, 100000);
                    } while (klantenNummers.Contains(klantNr));

                    klantenNummers.Add(klantNr);
                    string voornaam = voornamen[rnd.Next(0, voornamen.Count)];
                    string achternaam = achternamen[rnd.Next(0, achternamen.Count)];
                    string straatnaam = straatnamen[rnd.Next(0, straatnamen.Count)];
                    int postcode = postcodes[rnd.Next(0, postcodes.Count)];
                    string gemeente = gemeenten[postcode];
                    int huisnummer = rnd.Next(1, 1001);
                    Klant klant = new(klantNr, voornaam, achternaam, new Adres(gemeente, postcode, straatnaam, huisnummer));
                    klanten.Add(klant);
                }
            }catch(Exception e) {
                Console.WriteLine(e);
            }
            return klanten;
        }
    }
}
