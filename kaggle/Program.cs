namespace kaggle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Go();
        }

        public static void Go()
        {
            string chemin = @"C:\Users\yvesc\OneDrive\Bureau\IDEC_2025_2026\CSHARP\USA_cars_datasets.csv";
            try
            {
                List<string> fichier = File.ReadAllLines(chemin).ToList<string>();
                List<Car> cars = new List<Car>();
                //Console.WriteLine(fichier.Count());
                for (int i = 1; i < fichier.Count(); i++)
                {
                    try
                    {
                        Car c = new Car(fichier[i]);
                        cars.Add(c);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"la voiture n° {i} a un soucis : {ex}");
                    }
                }
                //ford
                int compte = 0;
                Console.WriteLine("quelle marque désires-tu?");
                string brand = Console.ReadLine();
                foreach (Car c in cars)
                {
                    if (c.Brand == brand)
                    {
                        compte++;
                    }
                    Console.WriteLine(c.GetInfos());
                }
                Console.WriteLine($"il y a {compte} {brand}");
                //linq
                Console.WriteLine($"le prix max est : {(int)cars.Average(x => x.Year)}");
            } catch (Exception ex)
            {
                Console.WriteLine("zut");
            }
            
        }
    }
}
