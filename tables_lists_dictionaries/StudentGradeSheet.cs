using System;
using System.Collections.Generic;
using System.Text;

namespace B5
{
    class StudentGradeSheet
    {
        
        public Dictionary<string, double> listaOcen = new Dictionary<string, double>();
     
        //#dodawanie oceny z danego przedmiotu,
        public void DodajOcenezaPrzedmiot(string przedmiotP, double ocenaP)  
        {
            if (!listaOcen.ContainsKey(przedmiotP))
            {
                listaOcen.Add(przedmiotP, ocenaP);
            }
            else
            {
                listaOcen[przedmiotP] = ocenaP;   
            }
            return;
        }

        //#pobieranie oceny z danego przedmiotu,
        public string DajOcene(string przedmiotP)   
        {
            if (listaOcen.GetValueOrDefault(przedmiotP) != 0)
                return (listaOcen.GetValueOrDefault(przedmiotP).ToString());
            else
                return ("Nie ma takiego przedmiotu w słowniku Ocen");
        }

        //#obliczanie średniej ocen
        public double Srednia()              
        {
            
            double sr = 0;
          
            foreach (KeyValuePair<string, double> dpo in listaOcen)
            {
                sr = sr + dpo.Value;
            }
            if (listaOcen.Count > 0)
                return sr / listaOcen.Count;
            else
                return 0;
        }


        //#sprawdzanie czy semestr został zaliczony
        public bool  Niezal()   
        {
         
                if (listaOcen.ContainsValue(2))
                    return (true);
                else
                    return false;

        }
            
               
    }
       
}
