using System;

namespace CS322_DZ06_AndrijanaJovanovic3918
{
    class Pravougaonik : Oblik, IComparable<Pravougaonik>
    {
        int a, b;

        public Pravougaonik(int a, int b, int x, int y) : base(x, y)
        {
            this.a = a;
            this.b = b;
        }
        public int getA() { return a; }
        public void setA(int a) { this.a = a; }
        public int getB() { return b; }
        public void setB(int b) { this.b = b; }

        public override double obim()
        {
            return 2 * (a + b);
        }

        public override double povrsina()
        {
            return a * b;
        }
        public override string crtaj()
        {
            return $"Crta se pravougaonik sa stranicama a={a}, b={b}: " + base.crtaj();
        }

        public int CompareTo(Pravougaonik other)
        {
            return povrsina().CompareTo(other.povrsina());
        }

        public override string ToString()
        {
            return $"Pravougaonik sa stranicama a={a}, b={b}: " + base.crtaj() + ", Povrsine: " + povrsina();
        }
    }
}
