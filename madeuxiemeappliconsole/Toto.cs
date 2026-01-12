namespace monespace
{
    internal class Toto
    {
        static void Main(string[] args)
        {
            //ceci est une variable
            //division <- 0 : entier
            int division = 0;
            /*récupération
             de
             la
             valeur
             à 
             l'écran
             */
            //demander 2 mots à l'utilisateur et afficher ces 2 mots
            string mot1, mot2;
            Console.WriteLine("Entrez deux mots");
            mot1 = Console.ReadLine();
            mot2 = Console.ReadLine();
            //Console.WriteLine("Vous avez entré les mots suivants : " + mot1 + " et " + mot2);
            Console.WriteLine($"Vous avez entré les mots suivants : {mot1} et {mot2}");
            //tester si les 2 mots sont identiques
            mot1 = null;
            if (mot1.Length <= 3)
            {
                Console.WriteLine("3-");
            }
            else if (mot1.Length >= 4 && mot1.Length <= 10)
            {
                Console.WriteLine("entre 4 et 10");
            }
            else
            {
                Console.WriteLine("10+");
            }
            //exemple boolean
            bool estVrai = true;
            if (!estVrai)
            {
                Console.WriteLine("C'est faux");
            }
            else
            {
                Console.WriteLine("C'est vrai");
            }
            Console.ReadLine();

            //expliquer différence & et &&
            //expliquer différence | et ||
            int x = 1;
            if (x > 2 && x < 10)
            {
                Console.WriteLine("x");
            }
            x = 1;
            if (x > 2 || x < 10)
            {
                Console.WriteLine("x");
            }
        }
    }
}
