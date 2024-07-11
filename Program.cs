using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit.Proizvodi
{
    public delegate void PocniPisatiIspit(DateTime pocetakIspita);

    internal class Program
    {

        static void Main(string[] args)
        {
            Predavac predavac = new Predavac();

            Polaznik polaznik1 = new Polaznik { ImePrezime = "Pero Perić" };
            Polaznik polaznik2 = new Polaznik { ImePrezime = "Iva Ivić" };
            Polaznik polaznik3 = new Polaznik { ImePrezime = "Ana Anić" };
            Polaznik polaznik4 = new Polaznik { ImePrezime = "Marko Marković" };

            predavac.Ispit += (vrijemePocetka) =>
            {
                polaznik1.OdgovoriNaPitanja(vrijemePocetka);
                polaznik2.OdgovoriNaPitanja(vrijemePocetka);
                polaznik3.OdgovoriNaPitanja(vrijemePocetka);
                polaznik4.OdgovoriNaPitanja(vrijemePocetka);
            };


            polaznik1.IspitZavrsen += (polaznik) => predavac.IspitZaprimljen(polaznik);

            predavac.ZvoniZvono();

            polaznik1.PredajOdgovoreNaPitanja();

            Console.ReadKey();
        }
    }
}
