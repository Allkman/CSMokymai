using System;

namespace CSMokymai.ConditionalOp
{
    class Program
    {
        static void Main(string[] args)
        {
            int oddNum01 = 5;
            int evenNum01 = 2;

            bool tiesa = true;

            if (oddNum01 > evenNum01)
            {
                Console.WriteLine($"{oddNum01} is greater than {evenNum01}");
            }
            if (oddNum01 < evenNum01)
            {
                Console.WriteLine($"{evenNum01} is greater than {oddNum01}");
            }
            else
            {
                Console.WriteLine($"{oddNum01} number is greater than {evenNum01}");
            }


            Console.WriteLine("----------Užduotis-1--------------------");

            Console.WriteLine("How many cup of coffee do you want?");

            int coffeeCups = 7;
            Console.WriteLine($"I want {coffeeCups}");
            int freeCupOfCoffee = 0;

            if (coffeeCups > 0 && coffeeCups <= 7)
            {
                Console.WriteLine("Pirkėjui priklauso {0} nemokami puodeliai", (freeCupOfCoffee + 2));
            }
            if(coffeeCups > 8)
            {
                Console.WriteLine("Pirkėjau priklauso daugiau nei du nemokami kavos puoldeliai");
            }
            

            Console.WriteLine("----------Užduotis-2--------------------");
            int num01 = 5;
            int num02 = 15;
            int num03 = -25;
            int num04 = 0;
            int negativeInt = -1;
            if (num01 > 0 || num01 < 0)
            {
                Console.WriteLine($"{num01} -> {num01 * negativeInt}; {num02} -> {num02 * negativeInt}; {num03} -> {num03 * negativeInt}; {num04} -> N/A;");
            }

        }
    }
}
