using System.Collections.Generic;
using System;

namespace ServiceLocator
{
    class Program
    {
        static void Main(string[] args)
        {
            IService service = ServiceLocator.GetService("SERVICE1");
            service.Execute();
            service = ServiceLocator.GetService("SERVICE2");
            service.Execute();
            service = ServiceLocator.GetService("SERVICE1");
            service.Execute();
            service = ServiceLocator.GetService("SERVICE2");
            service.Execute();
        }
    }

    public interface IService
    {
        string GetName();
        void Execute();
    }

    public class Service1 : IService
    {
        public void Execute()
        {
            Console.WriteLine("Exec service1");
        }

        public string GetName()
        {
            return "Service1";
        }
    }

    public class Service2 : IService
    {
        public void Execute()
        {
            Console.WriteLine("Exec service2");
        }

        public string GetName()
        {
            return "Service2";
        }
    }

    public class InitialContext
    {
        public object Lookup(string jndiName)
        {
            if(jndiName == "SERVICE1")
            {
                Console.WriteLine("Looking up and creating a new service1 object");
                return new Service1();
            }
            else if(jndiName == "SERVICE2")
            {
                Console.WriteLine("Looking up and creating a new service2 object");
                return new Service2();
            }
            return null;
        }
    }

    public class Cache
    {
        private List<IService> services;

        public Cache()
        {
            services = new List<IService>();
        }

        public IService GetService(string serviceName)
        {
            foreach (var item in services)
            {
                if(item.GetName() == serviceName)
                {
                    Console.WriteLine("Returning cached  " + serviceName + " object");
                    return item;
                }
            }
            return null;
        }

        public void AddService(IService newService)
        {
            bool exists = false;
            foreach (var item in services)
            {
                if(item.GetName() == newService.GetName())
                {
                    exists = true;
                }
            }

            if(!exists)
            {
                services.Add(newService);
            }
        }
    }

    public class ServiceLocator
    {
        private static Cache cache;
        static ServiceLocator()
        {
            cache = new Cache();
        }

        public static IService GetService(string jndiName)
        {
            IService service = cache.GetService(jndiName);

            if(service != null)
            {
                return service;
            }

            InitialContext context = new InitialContext();
            IService service1 = (IService)context.Lookup(jndiName);
            cache.AddService(service1);
            return service1;
        }
    }
}
