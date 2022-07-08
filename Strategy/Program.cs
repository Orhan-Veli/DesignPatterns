using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context1 = new Context(new OperationAdd());

            Context context2 = new Context(new OperationSubstract());

            Context context3 = new Context(new OperationMultiply());
            Console.WriteLine(context1.ExecuteStrategy(10,5));
            Console.WriteLine(context2.ExecuteStrategy(10,5));
            Console.WriteLine(context3.ExecuteStrategy(10,5));
        }
    }

    public interface IStrategy
    {
        int DoOperation(int num1,int num2);
    }

    public class OperationAdd : IStrategy
    {
        public int DoOperation(int num1, int num2)
        {
            return num1 + num2;
        }
    }

    public class OperationSubstract : IStrategy
    {
        public int DoOperation(int num1, int num2)
        {
            return num1 + num2;
        }
    }

    public class OperationMultiply : IStrategy
    {
        public int DoOperation(int num1, int num2)
        {
            return num1 * num2;
        }
    }

    public class Context
    {
        private IStrategy strategy;

        public Context(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public int ExecuteStrategy(int num1,int num2)
        {
            return strategy.DoOperation(num1,num2);
        }

    }
}
