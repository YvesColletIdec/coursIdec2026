using System;
using System.Collections.Generic;
using System.Text;
using toto;

namespace heritage
{
    public class Velo : Vehicule
    {
        public int Poids { get; set; }
        public int NbVitesses { get; set; }
        Program p;
        public Velo()
        {
            p = new Program();
            //Program.Main(null);
        }
    }
}
