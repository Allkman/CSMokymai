using System;

namespace CSMokymai.P09.UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            //------------Užduotis ------1

            Console.WriteLine("Input names of 3 friends");

            Console.WriteLine("Enter the name of 1st friend and age");
            string name1 = Console.ReadLine();
            int age1 = int.Parse(Console.ReadLine()); // = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the name of 2nd friend");
            string name2 = Console.ReadLine();
            int age2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the name of 3rd friend");
            string name3 = Console.ReadLine();
            int age3 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Names are: {name1} is {age1} years old || {name2} is {age2} years old || {name3} is {age3} years old");

            Console.WriteLine("Print and average age of all friends");
            Console.WriteLine("Average is: {0}", (age1 + age2 + age3) / 3);

            Console.WriteLine("Find youngest person");
            if (age1 < age2 && age1 < age3)
            {
                Console.WriteLine($"{name1} {age1}");
            }
            else if (age2 < age1 && age2 < age3)
            {
                Console.WriteLine($"{name2} {age2}");
            }
            else if (age3 < age1 && age3 < age2)
            {
                Console.WriteLine($"{name3} {age3}");
            }
            else
            {
                Console.WriteLine("Jauniausio draugo nustatyti nepavyko");
            }

            Console.WriteLine("Find Oldest person");
            if (age1 > age2 && age1 > age3)
            {
                Console.WriteLine($"{name1} {age1}");
            }
            else if (age2 > age1 && age2 > age3)
            {
                Console.WriteLine($"{name2} {age2}");
            }
            else if (age3 > age1 && age3 > age2)
            {
                Console.WriteLine($"{name3} {age3}");
            }
            else
            {
                Console.WriteLine("Vyriausio draugo nustatyti nepavyko");
            }
        }
    }
}
