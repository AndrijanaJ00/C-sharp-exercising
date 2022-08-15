namespace Abstraction
{
    class Rectangle : Shape
    {
        int a, b;

        public Rectangle(int a, int b) 
        {
            this.a = a;
            this.b = b;
        }
        public int getA() { return a; }
        public void setA(int a) { this.a = a; }
        public int getB() { return b; }
        public void setB(int b) { this.b = b; }

        public override double perimeter()
        {
            return 2 * (a + b);
        }

        public override double area()
        {
            return a * b;
        }
       
    }
}
