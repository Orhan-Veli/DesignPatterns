using System;

namespace Null
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractCustomer customer1 = CustomerFactory.GetCustomer("Bob");
            AbstractCustomer customer2 = CustomerFactory.GetCustomer("Rob");
            AbstractCustomer customer3 = CustomerFactory.GetCustomer("Julie");
            AbstractCustomer customer4 = CustomerFactory.GetCustomer("Laura");

            Console.WriteLine("Customers");
            Console.WriteLine(customer1.GetName());
            Console.WriteLine(customer2.GetName());
            Console.WriteLine(customer3.GetName());
            Console.WriteLine(customer4.GetName());
        }
    }

    public abstract class AbstractCustomer
    {
        protected string Name;
        public abstract bool IsNull();
        public abstract string GetName();
    }

    public class RealCustomer : AbstractCustomer
    {
        public RealCustomer(string name)
        {
            Name = name; 
        }

        public override string GetName()
        {
            return Name;
        }

        public override bool IsNull()
        {
            return false;
        }
    }

    public class NullCustomer : AbstractCustomer
    {
        public override string GetName()
        {
            return "Not available in Customer Database";
        }

        public override bool IsNull()
        {
            return true;
        }
    }

    public class CustomerFactory
    {
        public static string[] names = {"Rob","Joe","Julie"};

        public static AbstractCustomer GetCustomer(string name)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if(names[i] == name)
                {
                    return new RealCustomer(name);
                }
            }
            return new NullCustomer();
        }
    }
}
