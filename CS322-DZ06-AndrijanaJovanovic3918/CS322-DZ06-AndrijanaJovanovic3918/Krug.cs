using System;

namespace CS322_DZ06_AndrijanaJovanovic3918
{
    class Krug : Oblik, IComparable<Krug>
    {
        int r;

        public Krug(int r, int x, int y): base(x,y)
        {
            this.r = r;
        }

        public int getR() { return r; }
        public void setR(int r) { this.r = r; }

        public override double obim()
        {
            return 2 * r * Math.PI;
        }

        public override double povrsina()
        {
            return Math.Pow(r, 2) * Math.PI;
        }

        public override string crtaj()
        {
            return $"Crta se krug r= {r}: " + base.crtaj();
        }

        public int CompareTo(Krug other)
        {
            return obim().CompareTo(other.obim());
        }

        public override string ToString()
        {
            return $"Pravougaonik sa stranicama r = {r}, " + base.crtaj() + ", Obima: " + obim();
        }
    }
}
