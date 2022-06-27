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

    public interface IShape
    {
        void Draw();
    }

    public class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Rectangle Draw");
        }
    }

    public class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Square Draw");
        }
    }

    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Circle Draw");
        }
    }

    public class ShapeMaker
    {
        private IShape circle;
        private IShape rectangle;
        private IShape square;

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
