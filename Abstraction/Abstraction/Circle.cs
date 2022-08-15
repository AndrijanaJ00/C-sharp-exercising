using System;

namespace Abstraction
{
    class Circle : Shape
    {
        int r;

        public Circle(int r)
        {
            this.r = r;
        }

        public int getR() { return r; }
        public void setR(int r) { this.r = r; }

        public override double perimeter()
        {
            return 2 * r * Math.PI;
        }

        public override double area()
        {
            return Math.Pow(r, 2) * Math.PI;
        }
    }
}
