using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Single instance = Single.GetInstance();
            Console.WriteLine(instance.Hello());
            Console.ReadLine();
        }
    }

    public class Single
    {
        private Single(){}

        private static Single Instance = null;

        public static Single GetInstance ()
        {
            if(Instance == null){
                Instance= new Single();
            }
            return Instance;
        }

        public string Hello()
        {
            return "Hello World";
        }
    }
}
