using System;
using System.Collections.Generic;

namespace CS322_DZ06_AndrijanaJovanovic3918
{

    class Program
    {
        static void Main(string[] args)
        {
            List<Pravougaonik> pravougaonici = new List<Pravougaonik>();
            List<Krug> krugovi = new List<Krug>();

            Console.WriteLine("--------------------------------");
            Pravougaonik p1 = new Pravougaonik(10, 10, 10, 10);
            Console.WriteLine(p1.crtaj());
            Console.WriteLine("Povrsina pravougaonika: " + p1.povrsina());
            Console.WriteLine("Obim pravougaonika: " + p1.obim());

            Console.WriteLine("--------------------------------");
            Pravougaonik p2 = new Pravougaonik(9, 4, 9, 8);
            Console.WriteLine(p2.crtaj());
            Console.WriteLine("Povrsina pravougaonika: " + p2.povrsina());
            Console.WriteLine("Obim pravougaonika: " + p2.obim());

            pravougaonici.Add(p1);
            pravougaonici.Add(p2);

            Console.WriteLine("----------------SORTIRANJE PRAVOUGAONIKA PO POVRSINI----------------");
          
            pravougaonici.Sort();
            pravougaonici.ForEach(x => Console.WriteLine(x.ToString()));

            Console.WriteLine("--------------------------------");
            Krug k1 = new Krug(5, 20, 15);
            Console.WriteLine(k1.crtaj());
            Console.WriteLine("Povrsina kruga: " + k1.povrsina());
            Console.WriteLine("Obim kruga: " + k1.obim());

            Console.WriteLine("--------------------------------");
            Krug k2 = new Krug(9, 9, 8);
            Console.WriteLine(k2.crtaj());
            Console.WriteLine("Povrsina kruga: " + k2.povrsina());
            Console.WriteLine("Obim kruga: " + k2.obim());

            krugovi.Add(k1);
            krugovi.Add(k2);

            Console.WriteLine("----------------SORTIRANJE KRUGOVA PO OBIMU----------------");

            krugovi.Sort();
            krugovi.ForEach(x => Console.WriteLine(x.ToString()));

            Console.WriteLine(p1.CompareTo(p2));
        }
    }
}
