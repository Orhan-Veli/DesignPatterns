using System.Security.AccessControl;
using System;
using System.Collections.Generic;
namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Stock abcStock = new Stock();

            BuyStock buyStockOrder = new BuyStock(abcStock);
            SellStock sellStockOrder = new SellStock(abcStock);

            Broker broker = new Broker();
            broker.TakeOrder(buyStockOrder);
            broker.TakeOrder(sellStockOrder);

            broker.PlaceOrders();
        }
    }
    
    public interface IOrder
    {
        void Execute();
    }

    public class Stock
    {
        private string name = "ABC";
        private int quantity = 10;

        public void Buy()
        {
            Console.WriteLine($"Stock name {name} quantity {quantity} bought");
        }

        public void Sell()
        {
            Console.WriteLine($"Stock name {name} quantity {quantity} sold");
        }
    }

    public class BuyStock : IOrder
    {
        private Stock abcStock;

        public BuyStock(Stock abcStock)
        {
            this.abcStock = abcStock;
        }

        public void Execute()
        {
            abcStock.Buy();
        }
    }

    public class SellStock : IOrder
    {
        private Stock abcStock;

        public SellStock(Stock abcStock)
        {
            this.abcStock = abcStock;
        }

        public void Execute()
        {
            abcStock.Sell();
        }
    }

    public class Broker
    {
        private List<IOrder> orderList = new List<IOrder>();

        public void TakeOrder(IOrder order)
        {
            orderList.Add(order);
        }

        public void PlaceOrders()
        {
            foreach (var order in orderList)
            {
                order.Execute();
            }
            orderList.Clear();
        }
    }
}
