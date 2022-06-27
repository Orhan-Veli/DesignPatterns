using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape circle = new Circle();
            Shape redCircle = new RedShapeDecorator(new Circle());
            Shape redRectangle = new RedShapeDecorator(new Rectangle());
            Console.WriteLine("Circle With normal border");
            circle.Draw();

            Console.WriteLine("Circle of red border");
            redCircle.Draw();
            Console.WriteLine("Rectangle of red border");
            redRectangle.Draw();
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
            Console.WriteLine("Shape: Rectangle");           
        }
    }

    public class Circle : Shape
    {
        public void Draw()
        {
            Console.WriteLine("Shape: Circle");
        }
    }

    public abstract class ShapeDecorator : Shape
    {
        protected Shape decoratedShape;

        public ShapeDecorator(Shape decoratedShape){
            this.decoratedShape = decoratedShape;
        }

        public void Draw()
        {
            decoratedShape.Draw();
        }
    }

    public class RedShapeDecorator : ShapeDecorator{
        public RedShapeDecorator(Shape decoratedShape) : base(decoratedShape)
        {

        }

        public void Draw()
        {
            decoratedShape.Draw();
            setRedBorder(decoratedShape);
        }

        private void setRedBorder(Shape decoratedShape)
        {
            Console.WriteLine("Border color: Red");
        }
    }
}
