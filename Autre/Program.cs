using System;
using Salle3;

namespace Toto
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            n1 = 3;
            bool ok = false;
            do
            {
                Console.WriteLine("saisir un nombre");
                if (int.TryParse(Console.ReadLine(), out n2) == true)
                {
                    int somme = ProgramMethodes.Somme(n1, n2);
                    Console.WriteLine($"la somme est de : {somme}");
                    ok = true;
                }
                else
                {
                    Console.WriteLine("saisie incorrecte");
                }
            } while (ok == false);
            
                
            

            ////combien de mots dans une phrase
            //string phrase = "hello comment ça va?";
            //int nbMots = phrase.Split(" ").Length;
            //Console.WriteLine($"nb de mots : {nbMots}");

            ////inverser une phrase
            //phrase = "hello comment vas-tu?";
            //string phraseInversee = "";
            //foreach (char c in phrase)
            //{
            //    phraseInversee = c + phraseInversee;
            //}
            //Console.WriteLine(phraseInversee);
      
            //string[,] Tablero = new string[3, 2] {{"a","b"},
            //                          {"c","d"},
            //                          {"e","f"} };
            //for (int i = 0; i < Tablero.GetLength(0); i++)
            //{
            //    {
            //        for (int j = 0; j < Tablero.GetLength(1); j++)
            //        {
            //            Console.Write(Tablero[i, j]);
            //        }
            //    }
            //}
        }
    }
}
