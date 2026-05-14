using System;
using System.Collections.Generic;
using System.Text;

namespace B5
{
    class StudentGroup
    {
        public  Dictionary<string, StudentGradeSheet> studentGS = new Dictionary<string, StudentGradeSheet>();
      
          
        public void DodajS(string nazwisko, StudentGradeSheet dziennikO)
        {
            if (!studentGS.ContainsKey(nazwisko))
            {
                studentGS.Add(nazwisko, dziennikO);
            }
            else
                studentGS[nazwisko] = dziennikO;
        }

        //  pobieranie dziennika ocen dla danego ucznia,
        public StudentGradeSheet PobierzDziennikO(string nazwisko)     
        {
                  return studentGS[nazwisko];
        }

        // #obliczanie średniej ocen dla danego ucznia i wszystkich przedmiotów,
        public double PoliczSrS(string nazwisko) 
        {
            return(studentGS[nazwisko].Srednia());
        }

        //#obliczanie średniej ocen dla danego przedmiotu i wszystkich uczniów
        public double PoliczSrPrzedmiotu(string przedmiot)   
        {
            double sr = 0;
            int i = 0;
            foreach (KeyValuePair<string, StudentGradeSheet> dzO in studentGS)
            {
                if (dzO.Value.listaOcen.ContainsKey(przedmiot))
                {
                    sr = sr + dzO.Value.listaOcen[przedmiot];
                    i++;
                }
               
            }

            if (sr > 0)
                sr = sr / i;

            return sr;
        }


        //pobieranie listy uczniów, którzy nie zaliczyli semestru
        public List<string> ListaNZal()  
        {
            List<string> listaS = new List<string>();
            foreach (KeyValuePair<string, StudentGradeSheet> dzO in studentGS)
            {

                if(dzO.Value.Niezal())
                    listaS.Add(dzO.Key);
            }

            return (listaS);
        }
    }


    
}
