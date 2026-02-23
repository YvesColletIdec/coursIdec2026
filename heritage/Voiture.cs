using System;
using System.Collections.Generic;
using System.Text;
using heritage;
using toto;

namespace enfants
{
    public class Voiture : Vehicule
    {
        Program p;
        private int age;
        public float Prix { get; set; }
        public int NbChevaux { get; set; }
        public Voiture(int toto) : base()
        {
            Console.WriteLine("je suis une voiture");
            p = new Program();
            base.Km = 23;
            this.Description = string.Empty;
        }

        public Voiture()
        {
        }

        private void SetAge(int age)
        {
            this.age = age;
        }

        public void SetAnnee(int Annee)
        {
            Annee = Annee;
        }

        public static void Coucou()
        {
            Console.WriteLine("coucou");
        }

        public static int nbroues = 4;
        public int nbplaces;
    }
}
