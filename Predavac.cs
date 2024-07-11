using System;
using System.Threading;

namespace Ispit.Proizvodi
{
    public class Predavac
    {
        public event PocniPisatiIspit Ispit;

        public void ZvoniZvono()
        {
            Console.Beep();
            Console.WriteLine("Brrr Brrr Brrr zazvonilo je zvono i počinje ispit!\n");
            Ispit?.Invoke(DateTime.Now);
        }

        public void IspitZaprimljen(Polaznik polaznik)
        {
            Thread.Sleep(1000);
            Console.WriteLine($"Predavač je zaprimio odgovore od polaznika: {polaznik.ImePrezime}. ");
        }
    }
}
