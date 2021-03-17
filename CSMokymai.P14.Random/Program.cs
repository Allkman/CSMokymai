using System;
using System.Collections.Generic;
using System.Text;

namespace CSMokymai.P14.RandomUzduotys
{
    class Program
    {
        static void Main(string[] args)
        {
            int metimas;
            KauliukoMetimai(out metimas);
            Console.WriteLine($"Metimas: {metimas}");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
        static void KauliukoMetimai(out int metimas)
        {
            Random rand = new Random();

            metimas = rand.Next(1, 7);

            while (metimas ==1)
            {
                rand.Next(1, 5);
                Console.WriteLine("Meskite dar kartą");
                Console.ReadKey();
                
            }

            if (metimas >=2 && metimas <=4)
            {
                Console.WriteLine("Dėje pralaimėjote");
            }
            else if (metimas >= 5 && metimas <= 6 )
            {
                Console.WriteLine("Sveikiname, laimėjote");
            }
        }
        static void SkaiciuEile()
        {

        }

    }
}
