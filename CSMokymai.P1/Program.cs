using System;

namespace CSMokymai.P1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            var x = "Algirdas";
            Console.WriteLine($"Hey {x}");

            Console.Clear();
            Console.ReadKey();
            Nullable<int> skaiciusKurisGaliButiNull = null;

            int? skaiciusKurisGaliButiNull1 = null; // int? tai reiskia kad default reiksme yra null

            Console.WriteLine("Floating point");

            float f = 0.5F;
            double d = 10.9526662326;
            decimal dcm = 99.65448745454M;

            int skaiciusInt = 100;
            int skaiciusLong = 100;

            //implicit type casting 
            long castingLong = (long)skaiciusInt;
            long castingLong1 = skaiciusInt; //maziau skaitoma/suprantama bet validi salyga

            int castintasInt = (int)skaiciusLong;
            //int castintasInt1 = skaiciusLong; //implicit casting i mazesni negalimas

            long skaiciusLongDidesnis = 3_000_000_000;
            int skaiciusIntDidelis = (int)skaiciusLongDidesnis;
            Console.WriteLine($"skaiciusIntDidelis = {skaiciusIntDidelis} TAIP NEGALI BUTI");

            //var - isesmes yra implicit kintamasis

            //***
            var tekstasYraSKiacius = skaiciusLongDidesnis.ToString();

            //explicit type casting (letesnis uz implicit bet saugesnis)

            int castintasInt1 = int.Parse(skaiciusLong.ToString());
            //int castintasInt2 = int.Parse(skaiciusLongDidesnis.ToString());//overflow exeption

            //****convert
            long castintasLong2 = Convert.ToInt32(skaiciusInt);
            //int castintasInt3 = Convert.ToInt32(skaiciusLongDidesnis);//overflow exeption // luzta, nes netalpina

            //*** darbas su nullable kintamaisiais
            int? skaiciusIntNull = null;
            //long castingLong3 = (long)skaiciusIntNull; // luzta implicit cast nedirba su null

            long castintasLong4 = Convert.ToInt64(skaiciusIntNull);//grazina default t.y 0

            KeyValuePair<int, string> raktasIrReiksme = new KeyValuePair<int, string>(10, "Laptop");
            Tuple<int, int, string> tuple1 = new Tuple<int, int, string>(1000, 10, "Daiktas"); // gali irasyti iki 7 reiksmiu
        }
    }
}
