namespace Boucle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int numero = 2;
            ////tant que
            //while (numero == 2)
            //{
            //    Console.WriteLine(DateTime.Now);
            //    //if (DateTime.Now.ToString("HH:mm:ss") == "20:26:03")
            //    break;
            //}

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

            int numero = 3;
            if (numero > 0 || numero < 5)
            {
                Console.WriteLine(">0 et <5");
            } else
            {
                Console.WriteLine("faux");
            }
        }
    }
}
