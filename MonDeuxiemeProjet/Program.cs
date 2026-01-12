namespace MonDeuxiemeProjet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*demander 2 nombres à un utilisateur
            et afficher la somme des 2 nombres*/
            int num1 = 0, num2 = 0, resultat = 0;
            Console.WriteLine("saisir le tamère");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("saisir le num2");
            num2 = int.Parse(Console.ReadLine());
            resultat = num1 + num2;
            Console.WriteLine($"la somme de {num1} et {num2} fait {resultat}");
        }
    }
}
