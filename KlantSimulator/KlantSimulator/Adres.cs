﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlantSimulator
{
    public class Adres
    {
        public Adres(string gemeenteNaam ,int postcode, string straatNaam, int huisNr) {
            GemeenteNaam = gemeenteNaam;
            Postcode = postcode;
            StraatNaam = straatNaam;
            HuisNr = huisNr;
        } 

        private int _postcode;
        public int Postcode { 
            get { return _postcode; }   
            set
            {
                if(value.ToString().Length != 4)
                {
                    throw new ArgumentException($"Postcode {value} moet 4 cijfers bevatten!");
                }
                _postcode = value;
            } 
        }
        public string GemeenteNaam { get; set; }
        public string StraatNaam { get; set; }
        
        private int _huisNr;
        public int HuisNr { 
            get { return _huisNr; }
            set
            {
                if (value < 1 || value > 1000)
                {
                    throw new ArgumentException($"Huisnummer {value} moet tussen 1 en 1000 liggen!");
                }
                _huisNr = value;
            } 
        }
    }
}
