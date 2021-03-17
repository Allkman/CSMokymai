using System;

namespace CSMokymai.P10.Switch.Condition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int menuChoice = 3;
            switch (menuChoice)
            {
                case 1: Console.WriteLine("Opt1");
                    break;
                case 2:
                    Console.WriteLine("Opt2");
                    break;
                case 3:
                    Console.WriteLine("Opt3");
                    break;
                case 4:
                    Console.WriteLine("Opt4");
                    break;

                default: Console.WriteLine("Other Opt");
                    break;
            }
            var operation = 2;

            var result = operation switch
            {
                1 => "Case 1",
                2 => "Case 2",
                3 => "Case 3",
                _ => "No Case",
            };

        }
    }
}
