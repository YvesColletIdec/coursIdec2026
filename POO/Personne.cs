using System;
using System.Collections.Generic;
using System.Text;

namespace MesClasses
{
    public class Personne
    {
        public string nom;
        private int _age;
        public bool estVivant;

        public int GetAge()
        {
            if (_age < 0)
            {
                return 0;
            } else
            {
                return _age; 
            }    
        }

        public void SetAge(int toto)
        {
            if (toto < 0)
            {
                _age = 0;
            } else if (toto > 100)
            {
                _age = 100;
            } else
            {
                _age = toto;
            }
        }
    }
}
