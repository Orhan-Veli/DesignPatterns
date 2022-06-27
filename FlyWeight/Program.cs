using System.Security.AccessControl;
using System;
using System.Collections.Generic;
namespace FlyWeight
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeObjectFactory sof = new ShapeObjectFactory();

            IShape shape = sof.GetShape("Rectangle");
            shape.Print();
            shape = sof.GetShape("Rectangle");
            shape.Print();
            shape = sof.GetShape("Rectangle");
            shape.Print();
 
            shape = sof.GetShape("Circle");
            shape.Print();
            shape = sof.GetShape("Circle");
            shape.Print();
            shape = sof.GetShape("Circle");
            shape.Print();
 
            int NumObjs = sof.TotalObjectsCreated;
            Console.WriteLine("\nTotal No of Objects created = {0}", NumObjs);
            Console.ReadKey();
        }
    }

    public interface IShape 
    {
        void Print();
    }

    public class Rectangle : IShape
    {
        public void Print()
        {
            Console.WriteLine("Print Rectangle");
        }
    }

    public class Circle : IShape
    {
        public void Print()
        {
            Console.WriteLine("Print Circle");
        }
    }

    public class ShapeObjectFactory
    {
        Dictionary<string, IShape> shapes = new Dictionary<string, IShape>();

        public int TotalObjectsCreated
        {
            get { return shapes.Count;}
        }

        public IShape GetShape(string ShapeName)
        {
            IShape shape = null;

            if(shapes.ContainsKey(ShapeName))
            {
                shape = shapes[ShapeName];
            }
            else
            {
                switch (ShapeName)
                {
                    case "Rectangle":
                    shape = new Rectangle();
                    shapes.Add("Rectangle",shape);
                    break;
                    case "Circle":
                    shape = new Circle();
                    shapes.Add("Circle",shape);
                    break;
                    default:
                    throw new Exception("Factory cannot created");
                }
                }
                return shape;
            }
        }
}
