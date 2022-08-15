using System;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------RECTANGLE-----------------");
            Rectangle r1 = new Rectangle(2, 3);
            Console.WriteLine("Povrsina: " + r1.area());
            Console.WriteLine("Obim: " + r1.perimeter());
            Console.WriteLine("----------------CIRCLE-----------------");
            Circle c = new Circle(8);
            Console.WriteLine("Povrsina: " + c.area());
            Console.WriteLine("Obim: " + c.perimeter());
        }
    }
}
