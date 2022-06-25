using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var toyACreator = new ToyCreator(new ToyABuilder());
            toyACreator.CreateToy();
            var toy = toyACreator.GetToy();
            Console.WriteLine(toy.Legs);
        }
    }
}
