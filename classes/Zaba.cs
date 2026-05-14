using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt_C
{
    
    /*Klasa z konstruktorem konstruktorem kopiującym*/
    class Zaba
    {
        public int Wiek { get; set; }
        public string Kolor { get; set; }


        public Zaba(string kolor, int wiek)  //konstruktor, 2 parametry
        {
            Kolor = kolor;
            Wiek = wiek;
        }

        public Zaba (Zaba PoprzedniaZaba)  // ##  konstruktor kopiujący --> argument tego konstruktora jest obiekt tej klasy 
        {
           Kolor = PoprzedniaZaba.Kolor;
            Wiek = PoprzedniaZaba.Wiek;
        }
        

        public string WypiszSzczegoly()
        {
            return "Kolor żaby:  " +  Kolor+"  wiek żaby: " + Wiek.ToString();
        }
    }
}
