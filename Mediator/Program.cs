using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            User robert = new User("Robert");
            User john = new User("John");

            robert.SendMessage("Hi! John!");
            john.SendMessage("Hello! Robert!");
        }
    }

    public class ChatRoom
    {
        public static void SendMessage(User user, string message)
        {
            Console.WriteLine(" [" + user.Name + "] : " + message);
        }
    }

    public class User
    {
        public string Name { get; set; }
        
        public User(string name)
        {
            Name = name;
        }

        public void SendMessage(string message)
        {
            ChatRoom.SendMessage(this,message);
        }
    }
}
