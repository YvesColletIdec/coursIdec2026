using enfants;
using heritage;

namespace toto
{
    public class Program
    {
        public static  void Main(string[] args)
        {
            //Program.TestHeritage();
            //Program.TestPolymorphisme();
            //Program.CallVehicule2();
            Program.Encapsulation();
        }

        public static void Encapsulation()
        {
            Toto t = new Toto();
            t.LaVoitureDeToto = new Voiture();
            t.LaVoitureDeToto.Annee = 2000;
            t.SonVelo.NbVitesses = 5;
        }

        public static Vehicule GetNewVehicule()
        {
            int now = DateTime.Now.Millisecond;
            if (now % 2  == 0) 
            {
                return new Velo();
            } else
            {
                return new Voiture();
            }
        }
        public static void CallVehicule2()
        {
            List<Object> listeVehicules = new();
            listeVehicules.Add(new Voiture());
            listeVehicules.Add("asdasf");
            listeVehicules.Add(23);
            listeVehicules.Add(43.4);
            for (int i = 0; i < 10; i++)
            {
                Task.Delay(12 + i);
                listeVehicules.Add(GetNewVehicule());
            }
            foreach(Object v in listeVehicules)
            {
                if (v is Velo)
                {
                    Console.WriteLine("youpie c'est un vélo");
                }
                else if (v is string)
                {
                    Console.WriteLine("zut c'est une voiture");
                }
            }
        }

        public static void CallVehicule()
        {
            Object v = null;
            v = GetNewVehicule();
            if (v is Velo)
            {
                Console.WriteLine("youpie c'est un vélo");
                Velo v1 = (Velo) v;    
            }
            else if (v is Voiture)
            {
                Console.WriteLine("zut c'est une voiture");
            } else
            {
                Console.WriteLine("connais pas...");
            }
        }

        public static void TestPolymorphisme()
        {
            bool isVelo = false;

            Vehicule ve1;

            if (isVelo)
            {
                ve1 = new Velo();
            }
            else
            {
                ve1 = new Voiture();

                ((Voiture)ve1).Prix = 2;

                Voiture v1 = ve1 as Voiture;
                v1.Prix = 2;

                Voiture v2 = (Voiture)ve1;
                v2.Prix = 2;
                Console.WriteLine(v2.Prix);


            }
            if (ve1 is Velo)
            {
                Velo velo = (Velo)ve1;
            } else
            {
                Voiture voiture = (Voiture)ve1;
            }
            bool x = ve1 is Vehicule;
            Console.WriteLine(x);
                


        }

        public static void TestHeritage()
        {
            Voiture v = new Voiture(1);
            v.Prix = 1;
            v.NbChevaux = 2;
            v.Marque = "Ford";
            v.Annee = 2000;
            v.GetType();
            Voiture ford = new Voiture(1);
            Voiture hyundai = new Voiture(2);
            ford.nbplaces = 3;
            hyundai.nbplaces = 4;
            Voiture.nbroues = 5;
        }
    }
}
