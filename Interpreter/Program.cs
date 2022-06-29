using System;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            IExpression isMale = GetMaleExpression();
            IExpression isMarriedWoman = GetMarriedWomanExpression();

            Console.WriteLine("John is male? " + isMale.Interpret("John"));
            Console.WriteLine("Julie is a married women? " + isMarriedWoman.Interpret("Married Julie"));
        }

        public static IExpression GetMaleExpression()
        {
            IExpression robert = new TerminalExpression("Robert");
            IExpression john = new TerminalExpression("John");
            return new OrExpression(robert,john);
        }

        public static IExpression GetMarriedWomanExpression()
        {
            IExpression julie = new TerminalExpression("Julie");
            IExpression married = new TerminalExpression("Married");
            return new AndExpression(julie, married);		
        }
    }

    public interface IExpression
    {
        bool Interpret(string context);
    }

    public class TerminalExpression : IExpression
    {
        private string data;

        public TerminalExpression(string data)
        {
            this.data = data;
        }

        public bool Interpret(string context)
        {
            return context.Contains(data) ? true : false;
        }
    }

    public class OrExpression : IExpression
    {
        private IExpression exp1 = null;
        private IExpression exp2 = null;

        public OrExpression(IExpression exp1, IExpression exp2)
        {
            this.exp1 = exp1;
            this.exp2 = exp2;
        } 

        public bool Interpret(string context)
        {
            return exp1.Interpret(context) || exp2.Interpret(context);
        }
    }

    public class AndExpression : IExpression
    {
        private IExpression exp1 = null;
        private IExpression exp2 = null;

        public AndExpression(IExpression exp1, IExpression exp2)
        {
            this.exp1 = exp1;
            this.exp2 = exp2;
        } 

        public bool Interpret(string context)
        {
            return exp1.Interpret(context) || exp2.Interpret(context);
        }
    }
}
