using System.Security.AccessControl;
using System.Collections.Generic;
using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Originator originator = new Originator();
            CareTaker careTaker = new CareTaker();
            
            originator.State = "State #1";
            originator.State = "State #2";
            careTaker.AddMemento(originator.SaveStateToMemento());
            
            originator.State = "State #3";
            careTaker.AddMemento(originator.SaveStateToMemento());
            
            originator.State = "State #4";
            Console.WriteLine("Current State: " + originator.State);		
            
            originator.GetStateFromMemento(careTaker.Get(0));
            Console.WriteLine("First saved State: " + originator.State);
            originator.GetStateFromMemento(careTaker.Get(1));
            Console.WriteLine("Second saved State: " + originator.State);
        }
    }

    public class Memento
    {
        public string State { get; set; }

        public Memento(string state)
        {
            State = state;
        }
    }

    public class Originator
    {
        public string State { get; set; }

        public Memento SaveStateToMemento()
        {
            return new Memento(State);
        }

        public void GetStateFromMemento(Memento memento){
            State = memento.State;
        }
    }

    public class CareTaker
    {
        private List<Memento> memento = new List<Memento>();

        public void AddMemento(Memento state)
        {
            memento.Add(state);
        } 

        public Memento Get(int index)
        {
            return memento[index];
        }
    }
}
