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

        public int KlantNr { get; set; } //nummer met bovengrens : 10 000 verschillende nodig met alles erop en eraan
        
        private string _voornaam;
        public string Voornaam { //mag niet leeg zijn!
            get { return _voornaam; }
            set 
            { 
                if(value == null || string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Voornaam mag niet leeg zijn!");
                }
                _voornaam = value;
            } 
        } 
        
        private string _achternaam;
        public string AchterNaam { //mag niet leeg zijn!
            get { return _achternaam; }
            set
            {
                if (value == null || string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Achternaam mag niet leeg zijn!");
                }
                _achternaam = value;
            }
        } 
        public Adres Adres { get; set; } 

    }
}
