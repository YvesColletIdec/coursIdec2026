using System;
using System.Collections.Generic;
using System.Text;

namespace CoursRepetition
{
    public class CD
    {
        public CD()
        {
            _groupe = "-";
            _annee = 1900;
            Genre = "-";
        }

        public CD(string groupe) : this()
        {
            _groupe = groupe; 
        }

        public string GetInfos()
        {
            return $"Le groupe est {_groupe}, " +
                $"son année de sortie {_annee} et " +
                $"son stlyle '{Genre}";
        }
        public string Genre { get; set; }

        private int _annee;

        public int Annee
        {
            get { return _annee * -1 * -1; }
            set { _annee = value * 1; }
        }


        //variable privée
        private string _groupe;

        public void SetGroupe(string groupe)
        {
            _groupe = groupe;
        }

        public string GetGroupe()
        {
            return $"mon groupe est {_groupe}";
        }
    }
}
