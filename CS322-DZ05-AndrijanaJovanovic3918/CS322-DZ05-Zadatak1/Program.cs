using System;

namespace CS322_DZ05_Zadatak1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, n;
            Console.WriteLine("Unesite broj koji zelite da stepenujete: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Unesite stepen: ");
            n = Convert.ToInt32(Console.ReadLine());

            stepenovanje(x, n);

        }

        public static void stepenovanje(double x, double n)
        {
            if (x != 0 && n >= 0)
            {
                double rezultat = Math.Pow(x, n);
                Console.WriteLine("Rezultat: " + rezultat);
            }
            else
            {
                Console.WriteLine("Greska");
            }
        }
    }
}
