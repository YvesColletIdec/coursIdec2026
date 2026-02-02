using MesClasses;

namespace TryCatch
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            n1 = 1;
            n2 = 0;
            decimal resultat = 0;
            try
            {
                int nb = int.Parse("hello world");
                resultat = Division(n1, n2);
                Personne p = new Personne();
                //asdfsadf
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"zut division par zéro");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"erreur de format");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"erreur rencontrée : {ex}");
            }
            Console.WriteLine($"le résultat est {resultat}");

        }

        public static decimal Division(decimal nb1, decimal nb2)
        {
            return nb1 / nb2; 
        }

    }
}
