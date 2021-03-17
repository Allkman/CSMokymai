using System;
using System.Collections.Generic;

namespace CSMokymai.P12.Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Masyvai();

            //PrintArraysToConsole();
            //Matrixs();
            WorkingWithLists();
            ListUzduotis();

            WorkWithDictionary();
            DictUzduotis();

            WorkingWithEnums();

            SavaitesDeinos savaitesDiena = SavaitesDeinos.Antradienis;
            Console.WriteLine($"Savaites diena: {savaitesDiena}");

            int savaitesDiena1 = (int)SavaitesDeinos.Penktadienis;
            Console.WriteLine($"Nauja Savaites diena: {savaitesDiena1}");
            Console.WriteLine();

            Console.WriteLine("Please enter the importance of the message");
            int messageImportanceLevel = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"");
            Console.WriteLine("------- Press any key to continue --------");
            Console.ReadKey();
        }
        public static void Masyvai()
        {
            int num01 = 4;
            int num02 = 44;
            int num03 = 444;


            int[] nuliuMasyvas = new int[10]; // desimt nuliu

            int[] intMasyvas1 = new int[] { 5, 6, 18, 99 };
            int[] intMasyvas2 = new int[] { 5, 6, 18, 99 };
            int[] intMasyvas3 = new int[] { 5, 6, 18, 99 };
            int[] intMasyvas4 = new int[] { 5, 6, 18, 99 };

            DateTime[] dates = new DateTime[4];

            intMasyvas1[2] = 555;

            // intMasyvas1[5] = 878; //masyvas talpina tik 4 narius tad 55 jau iseina is ribu
            int suma = intMasyvas1[0] + intMasyvas2[3];
            Console.WriteLine($"{intMasyvas1[0]} + {intMasyvas2[3]} = {suma}");

            string[] vardai = { "Jonas", "Petras", "Silvija" };
            vardai[2] = "Jolija";
            Console.WriteLine($"{vardai[0]}, {vardai[1]}, {vardai[2]}");

            string vardas = vardai[2];
            string vardas2 = "Vrdas";
            vardai[1] = vardas2;
            Console.WriteLine($"{vardai[0]}, {vardai[1]}, {vardai[2]}");

            int totalNUmberOfInts = intMasyvas1.Length;
            Console.WriteLine(totalNUmberOfInts);

            string text01 = "Something here";
            char[] textLetters = text01.ToCharArray();
            Console.WriteLine($"txto 3 raide {textLetters[4]}");
        }

        static void PrintArraysToConsole()
        {
            int[] intMasyvas5 = new int[] { 5, 6, 18, 99,88 };
            int sumArray = intMasyvas5[0] + intMasyvas5[4];
            Console.WriteLine($"{intMasyvas5[0]} + {intMasyvas5[4]} = {sumArray}");

            string[] vardai02 = { "Jonas", "Petras", "Silvija", "Erika" };
            Console.WriteLine($"{vardai02[0]}, {vardai02[1]}, {vardai02[2]}");
            vardai02[3] = "Emilija";
            Console.WriteLine($"{vardai02[3]}");
            Console.WriteLine();
            Console.WriteLine(string.Join(", ", vardai02));
        }

        static void Matrixs()
        {
            int[,] twoDArray = new int[4, 4]; // 4 x 4 array
            twoDArray[0, 0] = 1; //top left
            twoDArray[0, 1] = 2;
            twoDArray[4, 4] = 15;

            //int[][] matrix2 = new int[4][]; // nested array
            //matrix2[0] = new int[4];
            //matrix2[1] = new int[4];
            //matrix2[2] = new int[4];
            //matrix2[3] = new int[4];
            //matrix2[4] = new int[4];
        }

        static void WorkingWithLists()
        {
            List<int> newList = new List<int>(); // generic type: 
            List<int> newList01 = new List<int> { 6, 18, 99, 88, 1}; // generic type: 
            Console.WriteLine(newList);
            List<string> newStringList = new List<string>();
            List<string> automobiliai = new List<string> { "Audi", "VW", "Ford", "Volvo", "BMW"};
            Console.WriteLine();
            Console.WriteLine($"{automobiliai[0]}, {automobiliai[1]},{automobiliai[2]},{automobiliai[3]}, {automobiliai[4]},");
            Console.WriteLine();
            automobiliai.Add("Fiat");
            Console.WriteLine(string.Join(", ", automobiliai));

            int kiekis = automobiliai.Count;
            Console.WriteLine($"automobilu kiekis liste {kiekis}");

            string[] automobiliuArray = automobiliai.ToArray();
            Console.WriteLine(string.Join(", ", automobiliuArray));
        }
        static void ListUzduotis()
        {
            List<int> newList02 = new List<int> { 6, 18, 99, 88, 1 };
            int multiplyFirstLast = newList02[0] * newList02[4];
            Console.WriteLine($"{newList02[0]} x {newList02[4]} = {multiplyFirstLast}");

            string[] vardai02 = { "Jonukas", "Petriukas", "Onute", "Žaneta" };
            Console.WriteLine($"{vardai02[0]}, {vardai02[1]}, {vardai02[2]}, {vardai02[3]}");
            Console.WriteLine();
            vardai02[3] = "Emilija";
            Console.WriteLine($"{vardai02[3]}");

            
        }

        static void WorkWithDictionary()
        {
            Dictionary<string, int> miestuZodynas = new Dictionary<string, int>
            {
                {"Vilnius", 7 },
                {"Kaunas", 10 },
                {"Klaipėda", 8 },
                {"Šiauliai", 6 },
            };
            var vilnius = miestuZodynas["Vilnius"];
            //reiksmes keitimas
            miestuZodynas["Kaunas"] = 50;
            Console.WriteLine($"Kaunas reiksme = {miestuZodynas["Kaunas"]}");

        }
        static void DictUzduotis()
        {
            List<string> months = new List<string> { "June", "March", "February", "October", "December", "July" };
            Dictionary<string, int> monthsDict = new Dictionary<string, int>
            {
                {months[0], months.Count},
                {months[1], months.Count},
                {months[2], months.Count},
                {months[3], months.Count},
                {months[4], months.Count},
                {months[5], months.Count},
            };

            Console.WriteLine($"{months[0]}, {months[1]}, {months[2]}, {months[3]}, {months[4]}, {months[5]}");
        }
        enum SavaitesDeinos { Sekmadienis, Pirmadienis, Antradienis, Treciadienis, Ketvirtadienis, Penktadienis, Sestadienis };

        
        /// <summary>
        /// Sukurkite Enum su reikšmėmis Low, Medium, High
        ///Parašykite programą kuri naudotojo paprašys įvesti skaičių žinutės svarbumą(0 - Low, 1 - Medium, 2 - High)
        ///Pagal naudotojo pasirinkimą naudodami switch į ekraną išveskite: Low level, Medium level, High level.
        /// </summary>
        static void WorkingWithEnums()
        {
        var operation = enum Mesures { Low, Medium, High };
        var result = operation switch
            {
                0 => Mesures.Low,
                2 => Mesures.Medium,
                3 => Mesures.High,
                _ => "No Case",
            };
            
        }
    }
}
