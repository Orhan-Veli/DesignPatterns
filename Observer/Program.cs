using System.Collections.Generic;
using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();

            product.Attach(new CustomerObserver());

            product.ChangeStock();
        }
    }

    public class Product
    {
        private List<Observer> observers = new List<Observer>();

        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            observers.Remove(observer);
        }

        private void Notify()
        {
            observers.ForEach(x=>{x.Update();});
        }

        public void ChangeStock()
        {
            this.Notify();
        }
    }

    public abstract class Observer
    {
        public abstract void Update();
    }

    public class CustomerObserver : Observer
    {
        public override void Update()
        {
            Console.WriteLine("Product to follow");
            Console.ReadLine();
        }
    }
}
