using System;

namespace CS322_DZ06_AndrijanaJovanovic3918
{
    abstract class Oblik : IOblik{
        protected int x;
        protected int y;

        public Oblik(int x, int y)
        {
            this.x = x;
            this.y = y; 
        }

        public int getX() { return x; }
        public void setX(int x) { this.x = x; }
        public int getY() { return y; }
        public void setY(int y) { this.y = y; }

        public abstract double povrsina();
        public abstract double obim();
        public virtual string crtaj()
        {
          return $"kordinate: x,y({x},{y})";
        }
    }
}
