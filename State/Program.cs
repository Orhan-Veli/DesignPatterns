using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();

            StartState startState = new StartState();
            startState.DoAction(context);

            Console.WriteLine(context.state.ToString());

            StopState stopState = new StopState();
            stopState.DoAction(context);

            Console.WriteLine(context.state.ToString());
        }
    }

    public interface IState
    {
        void DoAction(Context context);
    }

    public class StartState : IState
    {
        public void DoAction(Context context)
        {
            Console.WriteLine("Player is in start state");
            context.state = this;
        }

        public string ToString()
        {
            return "Start State";
        }
    }

    public class StopState : IState
    {
        public void DoAction(Context context)
        {
            Console.WriteLine("Player is in stop state");
        }

        public string ToString()
        {
            return "Stop State";
        }
    }

    public class Context
    {
        public IState state { get; set; }
    }
}
