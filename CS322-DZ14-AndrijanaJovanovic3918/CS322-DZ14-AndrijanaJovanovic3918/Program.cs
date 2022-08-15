using System;

namespace CS322_DZ14_AndrijanaJovanovic3918
{
    class Program
    {
        static void Main(string[] args)
        {
            string ime, prezime;
            int dan, mesec, godina;

            Console.WriteLine("Unesite ime: ");
            ime = Console.ReadLine();

            Console.WriteLine("Unesite prezime: ");
            prezime = Console.ReadLine();

            Console.WriteLine("Unesite dan rodjenja: ");
            dan = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Unesite mesec rodjenja: ");
            mesec = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Unesite godinu rodjenja: ");
            godina = Int32.Parse(Console.ReadLine());

            if ((dan >= 21 && mesec == 3) || (dan <= 20 && mesec == 4))
                Console.WriteLine("Ovan");
            if ((dan >= 24 && mesec == 9) || (dan <= 23 && mesec == 10))
                Console.WriteLine("Vaga");
            if ((dan >= 21 && mesec == 4) || (dan <= 21 && mesec == 5))
                Console.WriteLine("Bik");
            if ((dan >= 24 && mesec == 10) || (dan <= 22 && mesec == 11))
                Console.WriteLine("Skorpija");
            if ((dan >= 22 && mesec == 5) || (dan <= 21 && mesec == 6))
                Console.WriteLine("Blizanc");
            if ((dan >= 23 && mesec == 11) || (dan <= 21 && mesec == 12))
                Console.WriteLine("Strelac");
            if ((dan >= 21 && mesec == 6) || (dan <= 23 && mesec == 7))
                Console.WriteLine("Rak");
            if ((dan >= 22 && mesec == 12) || (dan <= 20 && mesec == 1))
                Console.WriteLine("Jarac");
            if ((dan >= 24 && mesec == 7) || (dan <= 23 && mesec == 8))
                Console.WriteLine("Lav");
            if ((dan >= 21 && mesec == 1) || (dan <= 19 && mesec == 2))
                Console.WriteLine("Vodolija");
            if ((dan >= 24 && mesec == 8) || (dan <= 23 && mesec == 9))
                Console.WriteLine("Devica");
            if ((dan >= 20 && mesec == 2) || (dan <= 20 && mesec == 3))
                Console.WriteLine("Riba");

        }
    }
}
