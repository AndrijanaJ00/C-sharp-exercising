using System; 

namespace CS322_DZ05_Zadatak2
{
    class Posetioc
    {
        private string ime, prezime;
        private int brUlaznica;

        public string getIme() { return ime; }
        public void setIme(string ime) { this.ime = ime; }

        public string getPrezime() { return prezime; }
        public void setPrezime(string prezime) { this.prezime = prezime; }

        public int getBrUlaznica() { return brUlaznica; }
        public void setBrUlaznica(int brUlaznica) { this.brUlaznica = brUlaznica; }

        public Posetioc() { }

        public Posetioc(string ime, string prezime, int brUlaznica)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.brUlaznica = brUlaznica;
        }
        ~Posetioc() { }

        public void stampaj()
        {
            Console.WriteLine("Ime: " + ime + ", Prezime: " + prezime + ", Broj ulaznice: " + brUlaznica);
        }

    }
}

