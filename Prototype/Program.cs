using System.Security.AccessControl;
using System;
using System.Collections.Generic;
namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
           CarManager carManager = new CarManager();

           carManager["Toyota"] = (CarPrototype)new Car("Corolla","Red","Toyota m21");
           carManager["Bmw"] = (CarPrototype)new Car("318","Red","Bmw 318i");
           
           Car car1 = carManager["Toyota"].Clone() as Car;
           Car car2 = carManager["Bmw"].Clone() as Car;

           Console.ReadLine();
           
        }
    }

    public class Car : CarPrototype
    {
        public string carModel;
        public string carColor;
        public string carName;

        public Car(string carModel, string carColor, string carName)
        {
            this.carModel = carModel;
            this.carColor = carColor;
            this.carName = carName;
        }

        public override CarPrototype Clone()
        {
            Console.WriteLine("CarName {0}, CarColor {1}, CarModel {2}",this.carName, this.carColor, this.carName);

            return this.MemberwiseClone() as CarPrototype;
        }
    }

    public abstract class CarPrototype
    {
        public abstract CarPrototype Clone();
    }

    public class CarManager
    {
        private Dictionary<string,CarPrototype> cars = new Dictionary<string, CarPrototype>();

        public CarPrototype this[string key]
        {
            get { return cars[key];}
            set { cars.Add(key,value);}
        }
    }
}
