namespace Conditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //initialisation de la variable
            int numero = 0;
            Console.WriteLine("saisir un chiffre plus grand que 0");
            numero = int.Parse(Console.ReadLine());

            //selon que
            switch (numero)
            {
                case 2: Console.WriteLine(2);
                    break;
                case 3: Console.WriteLine(3);
                    break;
                default: Console.WriteLine("autre");
                    break;
            }

            if (numero <= 0)
            {
                Console.WriteLine("Saisie eronnée");
            }
            else
            {
                Console.WriteLine("Saisie correcte");
                if (numero % 2 == 0)
                {
                    Console.WriteLine("pair");
                }
                else
                {
                    Console.WriteLine("impair");
                }
            }
            //if simplifié
            if (numero == 3)
                Console.WriteLine("youpie");
            Console.WriteLine("salut");
            
            
        }
    }
}
