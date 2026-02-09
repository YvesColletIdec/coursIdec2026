using CoursRepetition;
using MesClasses;
using System.Numerics;
using System.Security.Cryptography;

namespace POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable();
            //Objet();
            //TestPersonne();
            //TestVoiture();
            //TestCours();
            TestCD();
        }

        private static void TestCD()
        {
            CD c = new CD();
            c = new CD("KoRn");
            Console.WriteLine(c.GetInfos());
            c.SetGroupe("Kiss");
            Console.WriteLine(c.GetGroupe());
            c.Annee = 2000;
            Console.WriteLine(c.Annee);
            c.Genre = "Progressive Vegetarian Grindcore";
            Console.WriteLine(c.Genre);
            Console.WriteLine(c.GetType);
            Console.WriteLine(c.GetInfos());
            CD c2 = new CD();
            c2.Annee = c.Annee;
            c2 = c;
            c.Genre = "jazz";
            List<CD> maliste = new List<CD>();
            maliste.Add(c2);
            maliste.Add(c);
            c2 = null;
            Console.WriteLine(maliste[0].Genre);
        }

        private static void TestCours()
        {
            Cours c = new Cours();
            c.NumSalle = 23;
            c.NombreDEleves = 12;
            Console.WriteLine(c.Nom);
        }

        static void TestVoiture()
        {
            Voiture v1 = new Voiture();
            v1.SetMarque("Hyundai");
            v1.Couleur = "blanc";
            Console.WriteLine(v1.Couleur);
            Console.WriteLine(v1.GetMarque());
            v1.IsAutomatic = true;
        }

        static void TestPersonne()
        {
            //déclaration d'un objet
            Personne p = null;
            p = new Personne();
            p.nom = "Jean";
            p.SetAge(23);
            p.estVivant = true;
            p.SetAge(30);
            Personne p2 = null;
            p2 = p;
            Console.WriteLine(p.GetAge());
            Console.WriteLine(p2.GetAge());
            p2.SetAge(42);
            Console.WriteLine(p.GetAge());
            Console.WriteLine(p2.GetAge());
            p2 = new Personne();
            p2.SetAge(p.GetAge());
            p.SetAge(p.GetAge() + 1);
            p = null;
            p2 = p;
            Console.WriteLine(p.GetAge());
        }

        static void Variable()
        {
            int a = 0;
            a = 2;
            int b = 3;
            b = a;
            Console.WriteLine($"a = {a} et b = {b}");
        }

        static void Objet()
        {
            int? a = new int();
            a = 2;
            int? b = new int();
            b = 3;
            b = a;
            b = 4;
            Console.WriteLine($"a = {a} et b = {b}");
            a = null;
            Console.WriteLine($"a = {a} et b = {b}");
        }
    }
}
