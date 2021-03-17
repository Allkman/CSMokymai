using System;
using System.Collections.Generic;

namespace CSMokymai.P12.Cycles
{
    class Program
    {
        static void Main(string[] args)
        {

            WhileLoop();
            Console.WriteLine();

            DoWhileLoop();
            Console.WriteLine();

            ForLoop();
            Console.WriteLine();

            CikloNutraukimas();
            Console.WriteLine();

            CikloNutraukimas2();
            Console.WriteLine();


            LoopNesting();
            Console.WriteLine();

            IgnoreIteration();
            Console.WriteLine();

            ForeachLoop();
            Console.WriteLine();

            Console.WriteLine("------------ Uzduotis 1--------------");
            ReadIntNumber();

            Console.WriteLine("------------ Uzduotis 2--------------");
            string sakinys = Console.ReadLine();


            Console.WriteLine("------- Press any key to continue --------");
            Console.ReadKey();
        }
        static void WhileLoop()
        {
            int x = 1;
            while (x <= 5)
            {
                Console.WriteLine($"skaicius {x}");
                x++;
            }
            int zaidejoNumeris = 0;
            while (zaidejoNumeris < 1 || zaidejoNumeris > 5)
            {
                Console.WriteLine("Iveskite zaidejo numeri");
                var ivestasZaidejoNumeris = Console.ReadLine();
                zaidejoNumeris = Convert.ToInt32(ivestasZaidejoNumeris);
            }
        }
        static void DoWhileLoop()
        {
            int zaidejoNumeris = 0;
            do
            {
                Console.WriteLine("Iveskite zaidejo numeri");
                var ivestasZaidejoNumeris = Console.ReadLine();
                zaidejoNumeris = Convert.ToInt32(ivestasZaidejoNumeris);
            }
            while (zaidejoNumeris < 1 || zaidejoNumeris > 5);
        }
        static void ForLoop()
        {

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Skaicius {i}");
            }
        }
        static void CikloNutraukimas()
        {
            int blogasSkaicius = 5;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Skaicius {i}");

                if (i == blogasSkaicius)
                {
                    break;
                }
            }
        }
        static void CikloNutraukimas2()
        {
            while (true)
            {
                Console.WriteLine("Say something ");
                string input = Console.ReadLine();
                if (input == "quite" || input == "exit")
                    break;

            }
        }
        static void LoopNesting()
        {
            for (int row = 0; row < 10; row++)
            {
                for (int column = 0; column < row + 1; column++)
                {
                    Console.WriteLine("*");
                }
                Console.WriteLine();
            }
        }
        static void IgnoreIteration()
        {
            for (int i = 1; i <= 5; i++)
            {
                if (i == 3) continue;
                Console.WriteLine($"Skaicius {i}");
            }
        }
        static void ForeachLoop()
        {
            int[] scores = new int[10];
            foreach (var score in scores)
            {
                Console.WriteLine($"Kazkas turi tiek tasku {score}");
            }
            List<string> vardai = new List<string> { "Tomas", "Lina", "Giedrė" };
            foreach (var vardas in vardai)
            {
                Console.WriteLine($"Vardas yra {vardas}");
            }

            Dictionary<int, string> skaiciai = new Dictionary<int, string>
            {
                {1, "Vienas" },
                {2, "Du" },
                {3, "Trys" },
            };
            Console.WriteLine("----------------------------------------");
            foreach (var skaicius in skaiciai)
            {
                Console.WriteLine($"skaicius: key {skaicius.Key} Value= {skaicius.Value}");
            }
            string tekstas = "Kazkas svarbaus";
            foreach (var raide in tekstas)
            {
                Console.WriteLine($"raides: {raide}");
            }
        }

        static int ReadIntNumber()
        {
            Console.WriteLine("Iveskite sveikaji skaiciu");
            int skaicius;
            while (!int.TryParse(Console.ReadLine(), out skaicius))
            {
                Console.WriteLine("Neteisinga ivestis, iveskite sveikaji skaiciu");
            }
            return skaicius;
        }
        ///sumarry
        ///Sukurti metodą SentenceAnalysis 
        ///Paduodama simbolių eilutė(sakinys). Metodas išanalizuoja, kiek ir kokių simbolių yra sakinyje.
        /// - Visa analizės informacija turi būti išsaugota žodyne(simbolis, pasikartojimai).
        ///- Tarpų neskaičiuoti ir į žodyną nedėti.
        ///1 Atspausdinti gautus rezultatus.
        ///2 Atspausdinti dažniausiai pasikartojantį simbolį.
        ///Jeigu yra keletas simbolių tiek pat pasikartojančių, atspausdinti juos visus.
        /// 3 Atspausdinti rečiausiai pasikartojantį simbolį.
        ///Jeigu yra keletas simbolių tiek pat pasikartojančių, atspausdinti juos visus.
        ///

        ///formule yra 1 + x + x / 2 + x / 3 + x / 2 + 1 * 2;
        ///x = 3;
        public static double FormulesSprendimas(string formule, int kintamasisX)
        {
            var naujaFormule = formule.Replace("x", kintamasisX.ToString()).Replace(" ", ""); //mes nebeturim problemos su X, nes isirasem jo reiksme = 3
            var chrArr = naujaFormule.ToCharArray();
            double result = double.Parse(chrArr[0].ToString());

            for (int i = 0; i < chrArr.Length; i++)
            {
                if (chrArr[i] == '+')
                {
                    var sk = int.Parse(chrArr[i + 1].ToString());
                    result += sk;
                }
                else if (chrArr[i] == '/')
                {
                    var sk = int.Parse(chrArr[i + 1].ToString());
                    result /= sk;
                }
                else if (chrArr[i] == '*')
                {
                    var sk = int.Parse(chrArr[i + 1].ToString());
                    result *= sk;
                }
                else if (chrArr[i] == '-')
                {
                    var sk = int.Parse(chrArr[i + 1].ToString());
                    result -= sk;
                }
            }
            return result;
        }
        public static double FormulesSprendimas2(string formule, int kintamasisX)
        {
            {
                var naujaFormule = formule.Replace("x", kintamasisX.ToString()).Replace(" ", ""); //mes nebeturim problemos su X, nes isirasem jo reiksme = 3
                var chrArr = naujaFormule.ToCharArray();
                var tokens = new List<string>();
                foreach (var simbolis in chrArr)
                {
                    tokens.Add(simbolis.ToString());
                }
                while (tokens.Contains("/") || tokens.Contains("*"))
                {
                    for (int i = 0; i < tokens.Count; i++)
                    {
                        var token = tokens[i];
                        if (token == "/")
                        {
                            tokens[i] = (double.Parse(tokens[i - 1]) / double.Parse(tokens[i + 1])).ToString(); //kairi elem dalinu is desinio
                            tokens.RemoveAt(i - 1); //pasalinamas kairys elementas
                            tokens.RemoveAt(i); //pasalinamas desinys elementas
                            break;
                        }
                        else if (token == "*")
                        {
                            tokens[i] = (double.Parse(tokens[i - 1]) * double.Parse(tokens[i + 1])).ToString(); //kairi elem dalinu is desinio
                            tokens.RemoveAt(i - 1); //pasalinamas kairys elementas
                            tokens.RemoveAt(i); //pasalinamas desinys elementas
                            break;
                        }
                    }
                }
                while (tokens.Contains("+") || tokens.Contains("-"))
                {
                    for (int i = 0; i < tokens.Count; i++)
                    {
                        var token = tokens[i];
                        if (token == "+")
                        {
                            tokens[i] = (double.Parse(tokens[i - 1]) + double.Parse(tokens[i + 1])).ToString(); //kairi elem dalinu is desinio
                            tokens.RemoveAt(i - 1); //pasalinamas kairys elementas
                            tokens.RemoveAt(i); //pasalinamas desinys elementas
                            break;
                        }
                        else if (token == "-")
                        {
                            tokens[i] = (double.Parse(tokens[i - 1]) - double.Parse(tokens[i + 1])).ToString(); //kairi elem dalinu is desinio
                            tokens.RemoveAt(i - 1); //pasalinamas kairys elementas
                            tokens.RemoveAt(i); //pasalinamas desinys elementas
                            break;
                        }
                    }
                }
                return double.Parse(tokens[0]);
            }
        }
    }
}