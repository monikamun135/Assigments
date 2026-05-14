using System;

namespace Projekt_C
{


    class Program
    {

        static void Main(string[] args)
        {
            
            Console.WriteLine(" PRYWATNY KONSTRUKTOR   DOMYŚLNY  stworzenie obiektu klasy, której konstruktor jest prywatny KlasakonstruktorPrywatny.Licznik");
            Console.WriteLine("");

            //## stworzenie obiektu klasy której konstruktor domyślny jest prywatny
            //   KlasakonstruktorPrywatny z = new KlasakonstruktorPrywatny();     //NIE WOLNO TAK  bo wychodzi błąd--> konstruktor prywatny !!!!!!!!!
            KlasaKonstruktorPrywatny Obiekt1;   // jeszcze nie tworzymy oobiektu
            Obiekt1 = KlasaKonstruktorPrywatny.TworzenieObiektu();
       
           
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
                     
            
            Console.WriteLine(" K O N S T R U K T O R Y   + zmienna metoda static");
            Console.WriteLine(" ");
            Console.WriteLine("      Zmienna Static Jeszcze nie powstał obiekt typu KlasaZnaczek " + KlasaZnaczek.LicznikZnaczkow.ToString());
            Console.WriteLine(" ");

            KlasaZnaczek Z1 = new KlasaZnaczek()  //##   stworzenie obiektu klasy poprzez tzw inicjalizatora obiektów
            {
                Nazwa = "Z1_Nazwa",
                Wydawca = "Z1_Wydawca",
                IlZabkow = 8,
                RokWydania=1997
             };

            Console.WriteLine("Nowy obiekt Z1    ma właściwości nadane w inicjalizatorze obiektów mimo, że konstruktor KlasaZnaczek()  został wykonany !!! ");
            Z1.PokazInfoKlasaZnaczek();
            Console.WriteLine("      Zmienna STATIC:  KlasaZnaczek.LicznikZnaczkow= " + KlasaZnaczek.LicznikZnaczkow.ToString());
           
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            KlasaZnaczek Znaczek1 = new KlasaZnaczek();    //konstruktor prosty
            Console.WriteLine("Nowy obiekt Znaczek1  konstruktor prosty ");
            Znaczek1.PokazInfoKlasaZnaczek();
            Console.WriteLine("      Zmienna STATIC:  KlasaZnaczek.LicznikZnaczkow= " + KlasaZnaczek.LicznikZnaczkow.ToString());

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            // ##  konstruktor papametryczny   4 parametry
            KlasaZnaczek Znaczek2 = new KlasaZnaczek("NazwaZnaczka2",  "WydawcaZnaczka2", 6,2000);
            Console.WriteLine("Nowy obiekt Znaczek2 konstruktor z 4 parametrami   ");
            Znaczek2.PokazInfoKlasaZnaczek();


            //##STATIC właściwość publiczna licząca ilość obiektów, które zostały stworzone typu KlasaZnaczek 
            Console.WriteLine("      Zmienna STATIC :  KlasaZnaczek.LicznikZnaczkow= " + KlasaZnaczek.LicznikZnaczkow.ToString());
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            
            
            // ##  konstruktor papametryczny   2 parametry
            Console.WriteLine("nowy obiekt Znaczek3 konstruktor z 2 parametrami   ");
            KlasaZnaczek  Znaczek3 = new KlasaZnaczek("NazwaZnaczka3", 2000);
            Znaczek3.Wydawca = "Wydawca3";   //defoltowo nie przypisuje stringów
            Znaczek3.PokazInfoKlasaZnaczek();

            //STATIC właściwość publiczna licząca ilość obiektów, które zostały stworzone typu KlasaZnaczek 
            Console.WriteLine("      Zmienna STATIC:  KlasaZnaczek.LicznikZnaczkowc--->  " + KlasaZnaczek.LicznikZnaczkow.ToString());
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            //Console.WriteLine("KlasaZnaczek.LicznikZnaczkow    przed wyzerowaniem zmiennej static= " + KlasaZnaczek.LicznikZnaczkow.ToString());
            KlasaZnaczek.WyczyscLicznikStworzonychZnaczkow();  //##wywołanie metody statycznej która w tym przypadku zeruje  LicznikZnaczkow
            Console.WriteLine("KlasaZnaczek.LicznikZnaczkow po zresetowaniu zmiennej static= " + KlasaZnaczek.LicznikZnaczkow.ToString());


            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");


            Console.WriteLine("K O N S T R U K T O R     K O P I U J Ą C Y ");
                       
            Zaba zaba1 = new Zaba("Żółta", 5);
            //##KONSTRUKTOR KOPIUJĄCY (z argumentem tej samej klasy której jest konstruktorem  
            Zaba zaba2 = new Zaba(zaba1); // i już  mamy 2 żaby  z tymi samymi parametrami, które ewentualnie można zmienić
            Console.WriteLine("ŻABA   "+zaba1.WypiszSzczegoly());
            Console.WriteLine("Skopiowana żaba:  "+zaba2.WypiszSzczegoly());

            zaba2.Kolor = "Brązowa";
            zaba2.Wiek = 1;

            Console.WriteLine(" ");
            Console.WriteLine("Skopiowana żaba zmodyfikowana   "+zaba2.WypiszSzczegoly());
                      
        }      

    }
}
