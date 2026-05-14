using System;
using System.Collections.Generic;
using System.Text;
/*  Klasa z prywatnym konstruktorem --> tworzenie obiektu takiej klasy*/
namespace Projekt_C
{
    class KlasaKonstruktorPrywatny  
    {
        private KlasaKonstruktorPrywatny() { }   // ##  Prywatny konstruktor domyślny moze być w klasie, ?(która ma tylko statyczne elementy członkowskie (pola, wlasciwości metody))?
        private static int licznik=0;

        public static KlasaKonstruktorPrywatny ObiektKlasy = new KlasaKonstruktorPrywatny();
        public static KlasaKonstruktorPrywatny TworzenieObiektu()
        {
            return new KlasaKonstruktorPrywatny();
        }
           
    }
}
