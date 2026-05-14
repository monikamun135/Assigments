using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt_C
{

    /*Klasa z różnymi konstruktorami domyślnym i parametrycznymi, zmienna statyczna i metoda statyczna */
    class KlasaZnaczek
    {
        public static int LicznikZnaczkow = 0;    // ##zmienna static
        public static int LicznikZnaczkowW { get; set; } = 0;  //właściwość statyczna  przechowująca licznik  dotychczas stworzonych obiektów typu KlasaZnaczek
        public string Nazwa { get; set; }
        public string Wydawca { get; set; }
        public int IlZabkow { get; set; }
        public int RokWydania { get; set; }

        
        /* KONSTRUKTORY PRZECIĄŻONE--> z różnymi argumentami (ilość typ) */

        //prosty konstruktor
        public KlasaZnaczek()    
        {
            Nazwa = "Nazwa z prostego konsruktora";
            Wydawca = "Wydawcaz prostego konsruktora";
            RokWydania = 1999;
            LicznikZnaczkowW++;
            LicznikZnaczkow++;
          }

        // ## konstruktor parametryczny  z 2 parametrami
        public KlasaZnaczek(string Naz,  int RokWydaniaKlasera) 
        {
            Nazwa = Naz;
            RokWydania = RokWydaniaKlasera;
            LicznikZnaczkowW++;
            LicznikZnaczkow++;
        }

        // ## konstruktor parametryczny  z 4 parametrami
        public KlasaZnaczek(string Naz, string NazwaWydawcy, int IlZab, int RokWydaniaKlasera)  
        {
            Nazwa = Naz;
            Wydawca = NazwaWydawcy;
            if (IlZabkow > 4)
                IlZabkow = IlZab;
            else
                IlZabkow = 4;

            RokWydania = RokWydaniaKlasera;
            LicznikZnaczkowW++;
            LicznikZnaczkow++;
           }

        //##metoda statyczna zerująca LicznikZnaczkow
        public static int WyczyscLicznikStworzonychZnaczkow()   
        {
            LicznikZnaczkow = 0;
            return (LicznikZnaczkow);
        }


        public void PokazInfoKlasaZnaczek()
        {
            Console.WriteLine("      PokazInfoKlasaZnaczek()      Nazwa: " + Nazwa.ToString() + "    Wydawca: "+Wydawca.ToString() +"   Rok wyd.: "+RokWydania.ToString()+"   Il ząbków: "+IlZabkow.ToString());
        }
    }
}
