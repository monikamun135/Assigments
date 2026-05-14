using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace B9
{
    class Program
    {
       
        static void Main(string[] args)
        {
            

            List<string> animalList = new List<string>()
            {
                "kozica (Rupicapra rupicapra)",
                "żubr",
                "wilk",
                "żbik",
                "ryś",
                "tchórz stepowy",
                "norka europejska",
                "niedźwiedź brunatny",
                "foka szara",
                "foka obrączkowana",
                "foka pospolita",
                "walenie wszystkie gatunki",
                "podkowiec duży",
                "podkowiec mały",
            };

           
            ZooTree zooBinaryTree = new ZooTree();
            for (int i = 0; i < animalList.Count; i++)
            {
                zooBinaryTree.Add(animalList[i]);
                Console.WriteLine(animalList[i]);
            }

            //Wypisanie elementow drzewa
            Console.WriteLine("InOrder Traversal:");
            zooBinaryTree.TraverseInOrder(zooBinaryTree.Root);
            Console.WriteLine();

           
            // #dodawanie nowego zwierzęcia do drzewa (2 pkt),
            string animalToAdd = "";
            Console.WriteLine("Podaj nazwę zwierzęcia które przyjechło do Zoo: ");
            animalToAdd = Console.ReadLine();
            if(animalToAdd != "")
                zooBinaryTree.Add(animalToAdd);
            // wpisanie elementow drzewa
            Console.WriteLine("InOrder Traversal:");
            zooBinaryTree.TraverseInOrder(zooBinaryTree.Root);
            Console.WriteLine();

          

            // #wyszukiwanie, czy dane zwierzę występuje w ogrodzie (2 pkt),
            string animalToFind1 = "";
            string animalToFind2 = "";
            string animalToFind3 = "";
            animalToFind1 = "żubr";   
            animalToFind2 = "kot";  
            Console.WriteLine("Mogę poszukać żubra a potem kota <Enter> a jak nie chcesz to podaj swoje zwierzę:");
            animalToFind3 = Console.ReadLine();

            if (animalToFind3 == "")
            {
                ZooTreeNode foudedNode1 = zooBinaryTree.Find(animalToFind1);
                if (foudedNode1 != null)
                    Console.WriteLine("Znalazłem "+ foudedNode1.Val.ToString());
                else
                    Console.WriteLine("NIE znalazłem " + animalToFind1);

                ZooTreeNode foudedNode2 = zooBinaryTree.Find(animalToFind2);
                if (foudedNode2 != null)
                    Console.WriteLine("Znalazłem " + foudedNode2.Val.ToString());
                else
                    Console.WriteLine("NIE znalazłem " + animalToFind2);
            }
            else 
            {
                ZooTreeNode foudedNode3 = zooBinaryTree.Find(animalToFind3);
                if (foudedNode3 != null)
                    Console.WriteLine("Znalazłem " + foudedNode3.Val.ToString());
                else
                    Console.WriteLine("NIE znalazłem " + animalToFind3);
            }

            
            // #usuwanie istniejącego zwierzęcia z drzewa
            string animalToFree = "";
            Console.WriteLine("Które zwierzę chcesz wypuścić na wolność: ");
            animalToFree = Console.ReadLine();
            zooBinaryTree.Remove(animalToFree);
            // Write tree elemnts
            Console.WriteLine("PreOrder Traversal:");
            zooBinaryTree.TraversePreOrder(zooBinaryTree.Root);
            Console.WriteLine();
            Console.WriteLine("PostOrder");
            zooBinaryTree.TraversePostOrder(zooBinaryTree.Root);
            Console.WriteLine();


            // #zapisywanie bieżącego stanu drzewa do pliku tekstowego
            string nazwaPikuNaZoo = "C:\\Robo\\Monika\\Inf\\B9\\ZoowPliku.txt";
            
            // rysuj drzewo (z internetu)
            zooBinaryTree.Root.PrintZoo(); 

            // zapisz do pliku
            try
            {
                zooBinaryTree.DumpTreeToFile(zooBinaryTree.Root, nazwaPikuNaZoo);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
                Environment.Exit(0); // quit the program if the file could not be opened
            }
        }
 

    }
}
