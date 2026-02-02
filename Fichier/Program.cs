namespace Fichier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] tab = { "1.salut", "2.Comment", "3.va" };
            string fichier = @"C:/Users/yvesc/testdotnet/fichier.txt";
            File.AppendAllLines( fichier, tab);
            string[] tab2 = File.ReadAllLines(fichier);
            
            foreach (string s in tab2)
            {
                Console.WriteLine(s);
            }
        }
    }
}
