using System;

namespace CSMokymai.P11.Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("------------Metodai--------------");
            Console.WriteLine("---------------------------------");

            float someRndNum = GetFloatNumber();
                Console.WriteLine($"Some number float {someRndNum}");


            PrintToCW();

            PrintNumberToConsole(66);

            PrintMultipleNUmbers(88, 99);

            int sumOfNumbers = PrintSum(5, 9);
            Console.WriteLine($"Sum of numbers is: {sumOfNumbers}");

            TextToConsole();
            TextToConsole("Some text into console");

            var multiplyResult = MultiplyAndReminder(5, 2, out int remaind);
            Console.WriteLine($"Result = {multiplyResult}, liekana = {remaind}");

            int someNumber = 1;
            NumberReference(ref someNumber);
            Console.WriteLine($"Kintamasis skaicius lygu: {someNumber}");

            Console.WriteLine();
            ModifyNUmber(someNumber);
            Console.WriteLine($"Kintamasis skaicius lygu: {someNumber}");
            var sumaResult = Suma(5,5);
            var atimtisResult = Atimtis(15, 5);
            var daugybaResult = Daugyba(5, 5);
            var dalybaResult = Dalyba(117, 5);
            Console.WriteLine(sumaResult);
            Console.WriteLine(atimtisResult);
            Console.WriteLine(daugybaResult);
            Console.WriteLine(dalybaResult);

            Console.WriteLine("The sum of all results: {0} ", (sumaResult + atimtisResult + daugybaResult + dalybaResult));
            
            Console.WriteLine();

            Console.WriteLine($"");
            int aaa= 18;
            int bbb = 18;
            int ccc = 18;
            ArLygusKintamieji(ref aaa, ref bbb, ref ccc);
            Console.WriteLine();

            DoSomething(x:2,z:9);
            int x = 7;
            Console.WriteLine();

            DoSomethingElse(x, 8, 14, 13, 22);
            Console.WriteLine();

            int[] skaiciuMasyvas = { 1, 77, 9, 3, 404 };
            DoSomethingElse(x, skaiciuMasyvas);
            Console.WriteLine();

            Console.WriteLine($"Isvesta {year1} {year2} {year3} {year4}");

            var year1 = DateTime.Parse(Console.ReadLine());
            var year2 = DateTime.Parse(Console.ReadLine());
            var year3 = DateTime.Parse(Console.ReadLine());
            var year4 = DateTime.Parse(Console.ReadLine());

            if (year1.Month == 12 && year1.Day == 24)
            {
                Console.WriteLine("Jums priklauso nemokami sausainiai");
            }
            if (year2.Month == 12 && year2.Day == 24)
            {
                Console.WriteLine("Jums priklauso nemokami sausainiai");
            }
            if (year3.Month == 12 && year3.Day == 24)
            {
                Console.WriteLine("Jums priklauso nemokami sausainiai");
            }
            if (year4.Month == 12 && year4.Day == 24)
            {
                Console.WriteLine("Jums priklauso nemokami sausainiai");
            }

            UseParams2(1, 'a', "test", 14.888888888525644);





            Console.WriteLine("------- Press any key to continue --------");
            Console.ReadKey();
        }
        public static void DoSomethingElse(int x, params int[] masyvas)
        {
            x = 658;
            Console.Write($" = {x} / ");
            for (int i = 0; i < masyvas.Length; i++)
            {
                Console.Write(masyvas[i] + " ");
            }
        }
        public static void UseParams2(params object[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();
        }
        static void DoSomething(int x, params int[] numbers)
        {
            
        }
        static void DoSomething(int x, int y = 3, int z = 4)
        {
            Console.WriteLine($"{x},{y},{z}");
        }

        static void PrintToCW()
        {
            Console.WriteLine("Hello");
        }

        static float GetFloatNumber()
        {
            return 4.88F;
        }
        static void PrintNumberToConsole(int num01) //priimA SKAICIU JAU IS JI KVIECIANCIO KITO METODO
        {
            Console.WriteLine($"number is{num01}");
        }

        static void PrintMultipleNUmbers(int num02, int num03)
        {
            Console.WriteLine($"number are {num02}   {num03} ");
        }

        static void PrintTextToConsole(string text01)
        {
            Console.WriteLine($"some text = {text01}");
        }

        static int PrintSum(int a, int b)
        {
            return (a + b);
        }
        static void TextToConsole(string text02 = "HOLLALALA")
        {
            Console.WriteLine($"Text: {text02}");
        }

        static int MultiplyAndReminder(int num04, int multiplier, out int remainder)
        {
            remainder = num04 % multiplier;
            return num04 / multiplier;
        }

        static void NumberReference(ref int num05)
        {
            num05 = 54;
        }

        static void ModifyNUmber(int num06)
        {
            num06 = 54;
        }


            /// <summary>
            /// 1. Sukurti metodus Suma, Atimtis, Daugyba, Dalyba.
            ///- Kiekvienas metodas turi priimti 2 int tipo parametrus ir grąžinti atlikto veiksmo rezultatą.
            ///- Gautus rezultatus atspausdinti.
            ///- Atspausdinti gautų rezultatų sumą. 
            ///2.Sukurti metodus ArLygusKintamieji su 3 int tipo parametrais.
            ///- Metodo viduje palyginti visus kintamuosius tarpusavyje.Jeigu lygūs atspausdinti „Kintamieji lygūs“.
            ///- Jeigu nelygūs: atspausdinti visus kintamuosius ir parašyti „Kintamieji nelygūs“.
            ///- Metodas turi grąžinti loginę reikšmę true jeigu lygūs kintamieji, false jeigu nelygūs."

            /// </summary>
            static int Suma(int a, int b)
        {
            return a * b;
        }
        static int Atimtis(int a, int b)
        {
            return a - b;
        }
        static int Daugyba(int a, int b)
        {
            return a * b;
        }
        static double Dalyba(int a, int b)
        {
            return (double)(a / b);
        }

        static bool ArLygusKintamieji(ref int aa, ref int bb, ref int cc)
        {
            aa = 15;
            bb = 16;
            cc = 15;

            if (aa == bb && bb == cc)
            {
                Console.WriteLine("Numbers are equal");
            }
            else
            {
                Console.WriteLine($"{aa} {bb} {cc} are not equal");
            }
            return true; /// nenenenene
        }

        ///UŽDUOTIS 1
        ///1.Sukurti metodą, kuris paprašytų vartotojo įvesti tris skaičius.
        ///2.Paskui programa paprašytų pasirinkti vieną skaičių iš trijų.
        ///3.Paskui programa paprašytų pasirinkti ką nori su skaičiumi daryti(pridėti, atimti, ar
        ///4.Paskui paprašytų įvesti dar vieną skaičių
        ///5.Atspausdintų paskaičiuotą rezultatą pagal vartotojo padarytus pasirinkimus.

        ///UŽDUOTIS 2
        ///1.Sukurti naują metodą.
        ///2.Paprašyti vartotojo įvesti du skaičius su kableliu.
        ///3.Paprašyti vartotojo pasirinkti kokį veiksmą jis nori atlikti su su skaičiaus: sudėti, atimti (iš pirmojo atimti antrąjį), padauginti,
        ///padalinti(pirmąjį iš antro), abiejų skaičių sumą pakelti kvadratu,
        ///abiejų skaičių sumą pakelti kubu.
        ///4.Pasirinkimams panaudoti switch sakinį



    }
}
