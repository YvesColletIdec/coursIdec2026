namespace Salle3
{
    public class ProgramMethodes
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(args.Length);
            //for(int i = 0; i < 100; i++)
            //    Calcul();
            int resultat = Somme(2, 3);
            Console.WriteLine(resultat);
            Console.WriteLine(Calcul());
            AfficheLesNombres(DonneMoi10Nombres());
        }

        static void AfficheLesNombres(int[] y)
        {
            foreach(int x in y)
                Console.WriteLine(x);
        }

        static int[] DonneMoi10Nombres()
        {
            int[] x = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            return x;
        }

        //fait la somme de 2 nombres et renvoie le résultat
        public static int Somme(int nb1, int nb2)
        {
            int resultat = nb1 + nb2;
            return resultat;
        }

        static int Calcul()
        {
            //calcul
            int i = 2;
            int j = 3;
            int resultat = j + i;
            return resultat;
        }

        static void EnvoiEmail(string to, string content, string title)
        {
            //envoi email
            Console.WriteLine("email envoyé");
        }


    }
}
