using System;

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
            Console.WriteLine($"\nPredavač je zaprimio odgovore od polaznika: {polaznik.ImePrezime}. ");
        }
    }
}
