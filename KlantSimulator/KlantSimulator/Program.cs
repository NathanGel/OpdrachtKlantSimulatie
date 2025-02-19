namespace KlantSimulator
{
    internal class Program
    {
        static void Main()
        {
            List<string> voornamen = new() {
                "Tom", "Nora", "Ines", "Seppe", "Suleyman", "Nathan", "Daan", "Sarmad", "Samrad", "Lucia"
            };
            List<string> achternamen = new() {
                "Elm", "Geleyn", "Smet", "De Cock", "Vandesteene", "Vertiest", "Cockaert", "Aerts", "Vandewiele", "Vermeersch"
            };
            List<string> straatnamen = new() {
                "Kerkstraat", "Antwerpsebaan", "Brusselssteenweg", "Denderstraat", "The hood", "Zandvleugel", "Sportbaan", "Mashallah", "Inshallah", "Bismillah"
            };
            List<int> postcodes = new() { 1000, 2000, 3000, 4000, 5000, 6000, 7000, 8000, 9000};
            Dictionary<int, string> gemeenten = new() {
                {1000, "Brussel"}, { 2000, "Antwerpen"}, { 3000, "Leuven"}, { 4000, "Luik"}, { 5000, "Namen"}, { 6000, "Charleroi"}, { 7000, "Mons"}, { 8000, "Brugge"}, { 9000, "Gent"}
            };

            SessieBeheer sb = new();
            List<Klant> klanten =  sb.Uitvoer(voornamen, achternamen, straatnamen, postcodes, gemeenten);
            for(int i = 0; i < klanten.Count; i++) {
                Console.WriteLine($"{klanten[i].Voornaam} {klanten[i].AchterNaam} || klantnr: {klanten[i].KlantNr}");
            }
        }
    }
}
