using System;
using System.IO;
using System.Text;

namespace CSMokymai.String
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "Banana";
            string whiteSpace = " ";
            string emptyStr = string.Empty;

            char[] letterArray = { 'H', 'e', 'l', 'l', 'o', };
            Console.WriteLine(letterArray);


            Console.WriteLine("String concat....");

            string firstName = "Algirdas";
            string lastName = "Cernevicius";

            string fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);

            Console.WriteLine("Composite format");
            DateTime today = DateTime.Today;
            var nameAndDate = string.Format("Vardas = {0} siandien {1}", firstName, today);
            Console.WriteLine(nameAndDate);

            Console.WriteLine("String interpolation");
            var nameSurnameDate = $"Name = {firstName}, Surname = {lastName}, Date = {today}";
            Console.WriteLine(nameSurnameDate);

            Console.WriteLine($"Length of the name {firstName.Length}");
            string isItFirstName = "algirdas";

            bool areNamesEqual = firstName == isItFirstName;
            Console.WriteLine($"Is Name {firstName} equals {isItFirstName}? {areNamesEqual}");


            bool areNamesEqual1 = firstName.Equals(isItFirstName, StringComparison.OrdinalIgnoreCase);
            Console.WriteLine($"Is Name {firstName} equals {isItFirstName} with IgnoreCase {areNamesEqual}");

            bool isNameEmpty = string.IsNullOrEmpty(firstName);
            bool isItWhiteSpace = string.IsNullOrWhiteSpace(whiteSpace);

            Console.WriteLine($"Is firstName empty {isNameEmpty} | Is it whiteSpace {isItWhiteSpace}");

            Console.WriteLine($"If i want to print in new line \n I can do it but it is not working in every OS");

            Console.WriteLine($"If I want to print text in {Environment.NewLine} new line");
            Console.WriteLine($"if i need to print {Path.DirectorySeparatorChar} catalogue separator symbol ");
            Console.WriteLine($" escape curly brackets {{ }}");
            string verbatim = 
                @"We can write text in 
                  multiple lines with verbatim
                    (@) symbol";
            Console.WriteLine($"");

            Console.WriteLine("digits after comma");
            double number01 = 55.54568443546468466486;
            var numberWihTwoDigitsAfterComma = number01.ToString("#.00");
            Console.WriteLine(numberWihTwoDigitsAfterComma);

            var stringOfNUmber = "66";
            var opt01 = int.Parse(stringOfNUmber);
            var opt02 = Convert.ToInt32(stringOfNUmber);
            Console.WriteLine($"Now lets add numbers {opt01} + {opt02} = {opt01 + opt02}");

            StringBuilder sb = new StringBuilder();

            sb.Append("Added Text");
            sb.AppendLine("Added Text In New Line");
            sb.Insert(4, "54565");
            sb.Remove(2, 3);
            sb.Replace("word", "WORD");

            var textIsStringBuilder = sb.ToString();
            Console.WriteLine(textIsStringBuilder);

            Console.WriteLine("Try Parse!!!!");
            string v1 = null;
            string v2 = "150";
            string v3 = "155.88";

            int number1;
            bool success1 = int.TryParse(v1, out number1); // if FALSE: int the spotof number1 it will return 0
            Console.WriteLine("Attempted conversion of '{0}' . passed - {1} ({2})", v1, success1, number01);

            Console.WriteLine("--------------------------Užduotys---------------------------------");
            string str01 = "John";
            string str02 = "Tom";
            string str03 = "Anna";

            int coffeeCups = 7;

            string namesAndCoffe = $"{str01}, {str02} and {str03} drank {coffeeCups} coffee cups";
            Console.WriteLine(namesAndCoffe);

            var nameAndCoffeComposite = string.Format("{0}, {1} and {2} drank {3} coffee cups", str01, str02, str03, coffeeCups);
            Console.WriteLine(nameAndCoffeComposite);

            Console.WriteLine($"\"kompiuteris{Environment.NewLine}su Windows{Environment.NewLine}su linux{Environment.NewLine}su Mac\"");

            Console.WriteLine(
@"""Kompiuteris su Windows
su Linux
su Mac""");
            Console.WriteLine();
            StringBuilder sb02 = new StringBuilder();

            sb02.Append("\"Kompiuteris su Windows");
            sb02.AppendLine($"su Linux");
            sb02.AppendLine($"su Max\"");

            Console.WriteLine(sb02);
            Console.WriteLine();

            Console.WriteLine(sb02.Length);

            Console.WriteLine("[==== Press any key to continue! ====]");
            Console.ReadKey();
        }
    }
}
