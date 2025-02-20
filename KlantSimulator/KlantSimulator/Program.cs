using System.Net;
using System.Runtime.Intrinsics.X86;

namespace KlantSimulator
{
    internal class Program
    {
        static void Main()
        {
            const string padNamen = @"C:\Users\natha\softwareontwerp\OpdrachtKlantSimulatie\KlantSimulator\KlantData\FamilieNamen.txt";
            const string padVoornamen = @"C:\Users\natha\softwareontwerp\OpdrachtKlantSimulatie\KlantSimulator\KlantData\belgische_voornamen.txt";
            const string steden = @"C:\Users\natha\softwareontwerp\OpdrachtKlantSimulatie\KlantSimulator\KlantData\ProvincieGemeenteStraatnamen.txt";
            const string padGemeenten = @"C:\Users\natha\softwareontwerp\OpdrachtKlantSimulatie\KlantSimulator\KlantData\postcode.txt";
            const string padKlantLijst = @"C:\Users\natha\softwareontwerp\OpdrachtKlantSimulatie\KlantSimulator\KlantData\klantenlijst";

            BestandLezer Bl = new();
            List<string> voornamen = Bl.DataList(padVoornamen);
            List<string> achternamen = Bl.DataList(padNamen);
            List<string> straatnamen = Bl.StraatNamenData(steden);
            Dictionary<int, string> gemeenten = Bl.DataDictionary(padGemeenten);
            List<int> postcodes = gemeenten.Keys.ToList();
            
            SessieBeheer sb = new();
            List<Klant> klanten = sb.Uitvoer(voornamen, achternamen, straatnamen, postcodes, gemeenten);

            BestandsSchrijver Bs = new();
            Bs.SchrijfNaarBestand(klanten, padKlantLijst);
        }
    }
}
