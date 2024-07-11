using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit.Proizvodi
{

    public class Polaznik
    {
        public delegate void PredajIspit(Polaznik polaznik);

        public event PredajIspit IspitZavrsen;

        public string ImePrezime { get; set; }

        public void OdgovoriNaPitanja(DateTime vrijemePocetka)
        {
            Console.WriteLine($"Polaznik {ImePrezime}, je započeo pisanje ispita u: {vrijemePocetka} ");
        }

        public void PredajOfgovoreNaPitanja()
        {
            Console.WriteLine($"Polaznik {ImePrezime} je predao odgovore.");
            IspitZavrsen?.Invoke(this);
        }
    }
}
