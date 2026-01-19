namespace Boucle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////int numero = 2;
            ////tant que
            ////while (numero == 2)
            ////{
            ////    Console.WriteLine(DateTime.Now);
            ////    if (DateTime.Now.ToString("HH:mm:ss") == "20:26:03")
            ////        break;
            ////}

            //int numero = 0;
            //while (numero <= 0)
            //{
            //    Console.WriteLine("saisi un numero plus grand que 0");
            //    numero = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine($"youpie tu as saisi {numero}");


            //int numero = 4;
            //do
            //{
            //    Console.WriteLine("saisi un numero plus grand que 0");
            //    numero = int.Parse(Console.ReadLine());
            //} while (numero <= 0);


            //int j = 1;
            //for (; ; )
            //{
            //    Console.WriteLine(++j);
            //    --j;
            //    j--;
            //    if (j > 10)
            //    {
            //        break;
            //    }
            //}

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //int xyz = 2;
            //Console.WriteLine(xyz++);
            //Console.WriteLine(++xyz);

            //int numero = 3;

            //if (numero < 0 && numero < 5)
            //{
            //    Console.WriteLine(">0 et <5");
            //}
            //else if (numero % 2 == 1)
            //{
            //    Console.WriteLine("faux");
            //}
            //else if (xyz % 2 == 2)
            //{
            //    {

            //    }


            //}

            //continue

            //int i = 1;
            //while (i < 10)
            //{
            //    Console.WriteLine(i++);
            //    if (i % 2 == 1)
            //        continue;
            //    if (i == 5)
            //        break;
            //}
            int z = 10;
            string[] tab = { "a", "b", "c", "d" };
            for (int j = 0; j < tab.Length; j++)
            {
                Console.WriteLine(tab[j]);
            }

            //foreach
            int f = 0;
            foreach(string s in tab)
            {
                
                if (s == "c")
                {
                    Console.WriteLine($"'c' se trouve en position {f}");
                    break;
                }
                f++;
            }

            if (z % 2 == 1 & z < (z/2+1) | z > 3)
                Console.WriteLine();

#if DEBUG
            Console.WriteLine("debug");
#else
            Console.WriteLine("Release");
#endif

            Console.WriteLine("adsfas");
            
        }
    }
}
