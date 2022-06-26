using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape redCircle = new Circle(100,100,10,new RedCircle());
            Shape greenCircle = new Circle(100,100,10,new GreenCircle());

            redCircle.draw();
            greenCircle.draw();

        }
    }

    public interface DrawApi
    {
        void DrawCircle(int r, int y, int z);
    }

    public class RedCircle : DrawApi
    {
        public void DrawCircle(int r, int y, int z)
        {
            Console.WriteLine("RedCircle Radius " + r + " y " + y + " z " + z);
        }
    }

    public class GreenCircle : DrawApi 
    {
        public void DrawCircle(int r, int y, int z) 
        {
            Console.WriteLine("RedCircle Radius " + r + " y " + y + " z " + z);
        }
    }

    public abstract class Shape
    {
        protected DrawApi drawApi;

        protected Shape(DrawApi drawApi)
        {
            this.drawApi = drawApi;
        }

        public abstract void draw();
    }

    public class Circle : Shape
    {
        private int r,y,z;

        public Circle(int r, int y, int z, DrawApi drawApi) : base(drawApi)
        {
            this.z = z;
            this.y = y;
            this.r = r;
        }

        public override void draw()
        {
            drawApi.DrawCircle(r,y,z);
        }
    }
}
