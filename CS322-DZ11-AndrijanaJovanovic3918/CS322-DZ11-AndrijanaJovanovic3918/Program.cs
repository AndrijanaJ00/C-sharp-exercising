using System;
using System.Collections.Generic;

namespace CS322_DZ11_AndrijanaJovanovic3918
{
    class Kurs: IComparable<Kurs>
    {
        public String ImeKursa { get; set; }
        public int FondCasova { get; set; }
        public int MaksimalnoPrijava { get; set; }
        public Kurs(String imeKursa, int fondCasova, int maksimalnoPrijava)
        {
            this.ImeKursa = imeKursa;
            this.FondCasova = fondCasova;
            this.MaksimalnoPrijava = maksimalnoPrijava;
        }
        public override string ToString()
        {
            return $"Ime kursa: {ImeKursa}, Fond casova: {FondCasova}, Maksimalno prijava: {MaksimalnoPrijava}";
        }

        public int CompareTo(Kurs other)
        {
            return MaksimalnoPrijava.CompareTo(other.MaksimalnoPrijava);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            List<Kurs> kursevi = new List<Kurs>();
            kursevi.Add(new Kurs("Kurs 1", 10, 80));
            kursevi.Add(new Kurs("Kurs 2", 15, 40));
            kursevi.Add(new Kurs("Kurs 3", 30, 50));

            kursevi.Sort();
            kursevi.ForEach(x => Console.WriteLine(x.ToString()));
        }
    }
}
