using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            new ShapeFactory().GetShape(ShapeType.Rectangle);
            new ShapeFactory().GetShape(ShapeType.Circle);
            new ShapeFactory().GetShape(ShapeType.Square);
            Console.ReadLine();
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
            Console.WriteLine("Rectangle class talking");
        }
    }

    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Circle class talking");
        }
    }

    public class Square : IShape 
    {
        public void Draw()
        {
            Console.WriteLine("Square class talking");
        }
    }

    public class ShapeFactory
    {
        public void GetShape(ShapeType shapeType)
        {
            switch(shapeType)
            {
                case ShapeType.Rectangle:
                new Rectangle().Draw();  
                break;
                case ShapeType.Circle:
                new Circle().Draw();
                break;
                case ShapeType.Square:
                new Square().Draw();
                break;
            }
        }
    }

    public enum ShapeType
    {
        Rectangle, Circle, Square
    }
}
