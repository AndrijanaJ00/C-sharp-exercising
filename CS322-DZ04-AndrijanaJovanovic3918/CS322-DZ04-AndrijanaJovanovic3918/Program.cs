using System;

namespace CS322_DZ04_AndrijanaJovanovic3918
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadatak 1: ");
            Zadatak1();
            Console.WriteLine("");
            Console.WriteLine("Zadatak 2: ");
            Zadatak2();
            Console.WriteLine("");
            Console.WriteLine("Zadatak 3: ");
            Zadatak3();
        }

        private static void Zadatak1() {
            Console.WriteLine("Unesite neki n broj: ");

            int n = Convert.ToInt32(Console.ReadLine());
            int suma = 0;

            for (int i = 0; i < n; i++) {
                if (i % 2 != 0) {
                    suma += i;
                }
            }

            Console.WriteLine("Suma neparnih brojeva od 1 do n je: " + suma);

        }


        private static void Zadatak2()
        {
            for (int i = 16; i >= 8; i--)
            {
                Console.WriteLine("Dvostruka vrednost broja " + i + " je: " + (i * 2));
            }

        }

        private static void Zadatak3()
        {
            Console.WriteLine("Unesite broj: ");

            int n = Convert.ToInt32(Console.ReadLine());
            
            if (StrogoRastuciNiz(n))
            {
                Console.WriteLine("Cifre broja " + n + " obrazuju strogo rastuci niz");
            }
            else
            {
                Console.WriteLine("Cifre broja " + n + " ne obrazuju strogo rastuci niz");
            }

        }

        private static bool StrogoRastuciNiz(int n)
        {
            int prvi = n % 10;
            n /= 10;
           
            while(n != 0)
            {
                int drugi = n % 10;
                if (prvi > drugi)
                {
                    prvi = drugi;
                    n /= 10;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

    }
}
