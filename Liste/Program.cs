namespace Liste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string phrase = "hello je m'appelle Yves";
            string[] mots = phrase.Split(" ");
            Console.WriteLine(mots.Length);
            //foreach(string m3 in mots)
            //{
            //    Console.WriteLine(m3);
            //}
            List<string> maliste = mots.ToList();
            foreach (string m3 in maliste)
            {
                Console.WriteLine(m3);
            }
            maliste.Add("bonsoir");
            maliste.RemoveAt(2);
            maliste[1] = "coucou";
            foreach (string m3 in maliste)
            {
                Console.WriteLine(m3);
            }
        }
    }
}
