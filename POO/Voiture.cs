using System;
using System.Collections.Generic;
using System.Text;

namespace POO
{
    public class Voiture
    {
        private string _marque;
        private int _puissance;


        public int Puissance
        {
            get { return _puissance; }
            set { _puissance = value; }
        }

        public bool IsAutomatic { get; set; }

        private string _couleur;

        public string Couleur
        {
            get {
                Console.WriteLine("");
                return _couleur;
            }
            set { _couleur = value; }
        }



        public void SetMarque(string marque)
        {
            Couleur = "rouge";
            Console.WriteLine(Couleur);
            _marque = marque; 
        }

        public string GetMarque()
        {
            return $"je suis de la marque {_marque}";
        }
    }
}
