using System;
using System.Collections.Generic;
using System.Text;
namespace B5
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentGradeSheet zestawOcenNowak = new StudentGradeSheet();

            //  #dodawanie oceny z danego przedmiotu,       StudentGradeSheet,
            zestawOcenNowak.DodajOcenezaPrzedmiot("Matematyka", 3);
            zestawOcenNowak.DodajOcenezaPrzedmiot("Prawo", 4);
            zestawOcenNowak.DodajOcenezaPrzedmiot("Fizyka", 5);

            StudentGradeSheet zestawOcenKowalski = new StudentGradeSheet();
            zestawOcenKowalski.DodajOcenezaPrzedmiot("Matematyka", 3);
            zestawOcenKowalski.DodajOcenezaPrzedmiot("Prawo", 3);
            zestawOcenKowalski.DodajOcenezaPrzedmiot("Fizyka", 3);

            StudentGradeSheet zestawOcenKowal = new StudentGradeSheet();
            zestawOcenKowal.DodajOcenezaPrzedmiot("Matematyka", 5);
            zestawOcenKowal.DodajOcenezaPrzedmiot("Prawo", 5);
            zestawOcenKowal.DodajOcenezaPrzedmiot("Fizyka", 2);


            //#dodawanie nowego ucznia wraz z jego dziennikiem ocen,
            StudentGroup studentOceny = new StudentGroup();
            studentOceny.DodajS("Nowak", zestawOcenNowak);
            studentOceny.DodajS("Kowalski", zestawOcenKowalski);
            studentOceny.DodajS("Kowal", zestawOcenKowal);


            //#pobieranie oceny z danego przedmiotu,     StudentGradeSheet,
            Console.WriteLine("");
            Console.WriteLine("Ocena z matematyki Nowaka: " + zestawOcenNowak.DajOcene("Matematyka"));


            //#obliczanie średniej ocen,                    StudentGradeSheet,
            Console.WriteLine("Średnia ocen  dla Nowaka wszystkie przedmioty:  " + zestawOcenNowak.Srednia().ToString());

            
            //#sprawdzanie czy semestr został zaliczony,        StudentGradeSheet,
            Console.WriteLine("Czy Nowak oblał semestr:  " + zestawOcenNowak.Niezal().ToString());

            
            //#pobieranie dziennika ocen dla danego ucznia                 StudentGroup
            //Drukuje dziennik ocen dla  poszczególnych studentów
            foreach (KeyValuePair<string, double> po in studentOceny.PobierzDziennikO("Nowak").listaOcen)
            {
                Console.WriteLine("Nowak  Przedmiot: {0}    Ocena: {1}", po.Key, po.Value);
            }


            Console.WriteLine("");
            foreach (KeyValuePair<string, double> po in studentOceny.PobierzDziennikO("Kowalski").listaOcen)
            {
                Console.WriteLine("Kowalski Przedmiot: {0}    Ocena: {1}", po.Key, po.Value);
            }

            Console.WriteLine("");
            foreach (KeyValuePair<string, double> po in studentOceny.PobierzDziennikO("Kowal").listaOcen)
            {
                Console.WriteLine("Kowal Przedmiot: {0}    Ocena: {1}", po.Key, po.Value);
            }



            //#obliczanie średniej ocen dla danego ucznia i wszystkich przedmiotów,
            Console.WriteLine("");
            Console.WriteLine("średnia Nowaka   " + studentOceny.PoliczSrS("Nowak"));
            Console.WriteLine("średnia Kowalskiego   " + studentOceny.PoliczSrS("Kowalski"));
            Console.WriteLine("średnia Kowala   " + studentOceny.PoliczSrS("Kowal"));

            //#obliczanie średniej ocen dla danego przedmiotu i wszystkich uczniów,
            Console.WriteLine("");
            Console.WriteLine("średnia z Fizyki dla wszystkich studentów " + studentOceny.PoliczSrPrzedmiotu("Fizyka"));
            Console.WriteLine("");


            //#pobieranie listy uczniów, którzy nie zaliczyli semestru
            Console.WriteLine("");
            Console.WriteLine("Lista studentów, którzy nie zaliczyli semestru");
            foreach (string s in studentOceny.ListaNZal())
            {
                Console.WriteLine(s);
            }



        }
    }
}
