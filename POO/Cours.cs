using System;
using System.Collections.Generic;
using System.Text;

namespace POO
{
    public class Cours
    {
        public int NumSalle { get; set; }
        public int NombreDEleves { get; set; }
        public string Nom { get { return $"{NumSalle} - {NombreDEleves}"; } }
    }
}
