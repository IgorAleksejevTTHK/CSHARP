using tarpv24_Ckeel;

namespace tarpv24_keel
{
    internal class StartClass
    {


        public static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Red;


            Console.WriteLine("Tere tulemast! Mis on sinu nimi?");
            string tekst = Console.ReadLine();
            Console.WriteLine($"{tekst}, Rõõn näha!");
            int a = 1000;
            char taht = 'A';
            Console.Write($"Esimene arv on {a}, sisesta b=...");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Summa={a + b}");
            double d = double.Parse(Console.ReadLine());
            Console.WriteLine(d);
            float f = float.Parse(Console.ReadLine());
            Console.WriteLine(f);
            bool t=true;

            Random rnd = new Random();
            a = rnd.Next(-100,200);
            Console.WriteLine(a);
            float vastus=Osal_funktsioonid.Kalkulaator(f, a);
            Console.WriteLine($"kalkulaatori tulemus:",vastus);
        }
    }
}

namespace tarpv24_Ckeel
{

    internal class Osal_funktsioonid
    {

        public static float Kalkulaator(float arv1, float arv2)

        {
            float k = arv1 * arv2;
            return k;


        }







    }
}




