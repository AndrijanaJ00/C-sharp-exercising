using System;
using System.Linq;

namespace CS322_DZ09_AndrijanaJovanovic3918
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------1-------------------------");
          
            int zbir1 = 0;
            int[] niz1 = Enumerable.Range(1, 3000).ToArray();
            //prikazuje niz od 1-3000 brojeva
           //Console.WriteLine(string.Join(",", niz1));

            for (int i = 1; i < niz1.Length - 1; i++)
            {
               zbir1 += niz1[i];
                 
            }
            Console.WriteLine("ZBIR SVIH BROJEVA OD 1 DO 3000 JE: " + zbir1);


            Console.WriteLine("-----------------------2-------------------------");

            int zbir2 = 0;
            int[] niz2 = Enumerable.Range(1, 100).ToArray();
            //prikazuje niz od 1-100 brojeva
            // Console.WriteLine(string.Join(",", niz2));

            for (int i = 1; i < niz2.Length - 1; i++)
            {
                if (niz2[i] % 2 == 0) {
                    zbir2 += niz2[i];
                }
            }
            Console.WriteLine("ZBIR SVIH PARNIH BROJEVA OD 1 DO 100 JE: " + zbir2);

            Console.WriteLine("-----------------------3-------------------------");

            int zbir3 = 0;
            int[] niz3 = new int[79];
           
            int broj = 21;
            for (int i = 0; i < niz3.Length; i++)
            {
                niz3[i] = broj++;
            }

            //prikazuje niz od 21-99 brojeva
           // Console.WriteLine(string.Join(",", niz3));

            for (int i = 0; i < niz3.Length - 1; i++)
            {
                if (niz3[i] % 2 == 0)
                {
                    zbir3 += niz3[i];
                }
            }
            Console.WriteLine("ZBIR SVIH PARNIH BROJEVA OD 21 DO 99 JE: " + zbir3);



        }
    }
}
