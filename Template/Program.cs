using System;

namespace Template
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Cricket();
            game.Play();
            game = new Football();
            game.Play();
        }
    }

    public abstract class Game
    {
        public abstract void Initialize();
        public abstract void StartPlay();
        public abstract void EndPlay();

        public void Play()
        {
            Initialize();
            StartPlay();
            EndPlay();
        }
    }

    public class Cricket : Game
    {
        public override void EndPlay()
        {
            Console.WriteLine("Cricket Game Finished");
        }

        public override void Initialize()
        {
            Console.WriteLine("Cricket Game Initialized");
        }

        public override void StartPlay()
        {
            Console.WriteLine("Cricket Game Started");
        }
    }

    public class Football : Game
    {
        public override void EndPlay()
        {
            Console.WriteLine("Football Game Finished");
        }

        public override void Initialize()
        {
            Console.WriteLine("Football Game Initialized");
        }

        public override void StartPlay()
        {
            Console.WriteLine("Football Game Started");
        }
    }
}
