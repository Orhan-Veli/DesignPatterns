using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape circle = new Circle();
            IShape redCircle = new RedShapeDecorator(new Circle());
            IShape redRectangle = new RedShapeDecorator(new Rectangle());
            Console.WriteLine("Circle With normal border");
            circle.Draw();

            Console.WriteLine("Circle of red border");
            redCircle.Draw();
            Console.WriteLine("Rectangle of red border");
            redRectangle.Draw();
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
            Console.WriteLine("Shape: Rectangle");           
        }
    }

    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Shape: Circle");
        }
    }

    public abstract class ShapeDecorator : IShape
    {
        protected IShape decoratedShape;

        public ShapeDecorator(IShape decoratedShape){
            this.decoratedShape = decoratedShape;
        }

        public void Draw()
        {
            decoratedShape.Draw();
        }
    }

    public class RedShapeDecorator : ShapeDecorator{
        public RedShapeDecorator(IShape decoratedShape) : base(decoratedShape)
        {

        }

        public void Draw()
        {
            decoratedShape.Draw();
            setRedBorder(decoratedShape);
        }

        private void setRedBorder(IShape decoratedShape)
        {
            Console.WriteLine("Border color: Red");
        }
    }
}
