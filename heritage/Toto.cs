using enfants;
using System;
using System.Collections.Generic;
using System.Text;

namespace heritage
{
    public class Toto
    {
        public string Nom { get; set; }
        public Voiture LaVoitureDeToto { get; set; }
        public Velo SonVelo { get; set; }

        public Toto() {
            this.SonVelo = new Velo();
        }
    }
}
