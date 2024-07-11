using System;

namespace Ispit.Proizvodi
{
    public class Polaznik
    {
        public delegate void PredajIspit(Polaznik polaznik);

        public event PredajIspit IspitZavrsen;

        public string ImePrezime { get; set; }

        public void OdgovoriNaPitanja(DateTime vrijemePocetka)
        {
            Console.WriteLine($"Polaznik \t{ImePrezime}\t je započeo pisanje ispita u: \t{vrijemePocetka} ");
            Console.WriteLine("=========================================================================================="); 
        }

        public void PredajOdgovoreNaPitanja()
        {
            Console.WriteLine($"\nPolaznik {ImePrezime} je predao odgovore.");
            IspitZavrsen?.Invoke(this);
        }
    }
}
