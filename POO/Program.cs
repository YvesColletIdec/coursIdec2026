using MesClasses;

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
            TestCours();
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
