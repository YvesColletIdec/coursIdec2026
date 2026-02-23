using System;
using System.Collections.Generic;
using System.Text;

namespace heritage
{
    public class Vehicule
    {
        public string Marque { get; set; }
        public int Annee { get; set; }
        public Vehicule(int titi) {
            Console.WriteLine("je suis un véhicule");
            GetType();
            this.Description = string.Empty;
        }
        public Vehicule() { }
        protected string Description;

        private int _km;

        public int Km { get { return _km; } set { _km = value; } }
    }
}
