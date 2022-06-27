using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory shapeFactory = FactoryProcuder.GetFactory(Factory.Shape);
            shapeFactory.GetShape(ShapeType.Rectangle);
            shapeFactory.GetShape(ShapeType.Square);
            shapeFactory.GetShape(ShapeType.Circle);

            AbstractFactory modernShapeFactory = FactoryProcuder.GetFactory(Factory.ModernShape);
            modernShapeFactory.GetShape(ShapeType.Circle);
            modernShapeFactory.GetShape(ShapeType.Square);

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
            Console.WriteLine("Rectagle class talking");
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

    public class ModernSquare : IShape 
    {
        public void Draw()
        {
            Console.WriteLine("ModernSquare class talking");
        }
    }

    public class ModernCircle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("ModernCircle class talking");
        }
    }

    public abstract class AbstractFactory
    {
        public abstract void GetShape(ShapeType shapeType);
    }
    public class ModernFactory : AbstractFactory
    {
        public override void GetShape(ShapeType shapeType)
        {
            switch(shapeType)
            {
                case ShapeType.Square: 
                new ModernSquare().Draw();
                break;
                case ShapeType.Circle: 
                new ModernCircle().Draw();
                break;
            }
        }
    } 
    public class ShapeFactory : AbstractFactory
    {
        public override void GetShape(ShapeType shapeType)
        {
            switch(shapeType)
            {
                case ShapeType.Circle:
                new Circle().Draw();
                break;
                case ShapeType.Rectangle:
                new Rectangle().Draw();
                break;
                case ShapeType.Square:
                new Square().Draw();
                break;
            }
        }
    }
    public class FactoryProcuder
    {
        public static AbstractFactory GetFactory(Factory factory)
        {
            return factory == Factory.ModernShape ? 
            new ModernFactory() :
            new ShapeFactory();
        }
    }

    public enum Factory
    {
        ModernShape, Shape
    }
    public enum ShapeType
    {
        Rectangle, Square, Circle
    }

}
