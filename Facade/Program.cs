using System.Drawing;
using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeMaker shapeMaker = new ShapeMaker();

            shapeMaker.DrawCircle();
            shapeMaker.DrawRectangle();
            shapeMaker.DrawSquare();
        }
    }

    public interface Shape
    {
        void Draw();
    }

    public class Rectangle : Shape
    {
        public void Draw()
        {
            Console.WriteLine("Rectangle Draw");
        }
    }

    public class Square : Shape
    {
        public void Draw()
        {
            Console.WriteLine("Square Draw");
        }
    }

    public class Circle : Shape
    {
        public void Draw()
        {
            Console.WriteLine("Circle Draw");
        }
    }

    public class ShapeMaker
    {
        private Shape circle;
        private Shape rectangle;
        private Shape square;

        public ShapeMaker()
        {
            circle = new Circle();
            rectangle = new Rectangle();
            square = new Square();
        }

        public void DrawCircle()
        {
            circle.Draw();
        }

        public void DrawRectangle()
        {
            rectangle.Draw();
        }

        public void DrawSquare()
        {
            square.Draw();
        }
    }
}
