using System;
using System;
using System.Collections.Generic;
namespace InterceptingFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            FilterManager filterManager = new FilterManager(new Target());
            filterManager.SetFilter(new AuthenticationFilter());
            filterManager.SetFilter(new DebugFilter());

            Client client = new Client();
            client.SetFilterManager(filterManager);
            client.SendRequest("HOME");
        }
    }

    public interface IFilter
    {
        void Execute(string request);
    }

    public class AuthenticationFilter : IFilter
    {
        public void Execute(string request)
        {
            Console.WriteLine("Authentication req" + request);
        }
    }

    public class DebugFilter : IFilter
    {
        public void Execute(string request)
        {
            Console.WriteLine("request log: " + request);
        }
    } 

    public class Target
    {
        public void Execute(string request)
        {
            Console.WriteLine("exeuting request: " + request );
        }
    }

    public class FilterChain
    {
        private List<IFilter> filters = new List<IFilter>();

        private Target target;

        public void AddFilter(IFilter filter)
        {
            filters.Add(filter);
        }

        public void Execute(string request)
        {
            foreach (var item in filters)
            {
                item.Execute(request);
            }
            target.Execute(request);
        }

        public void SetTarget(Target target)
        {
            this.target = target;
        }
    }

    public class FilterManager
    {
        FilterChain filterChain;

        public FilterManager(Target target)
        {
            filterChain = new FilterChain();
            filterChain.SetTarget(target);
        }

        public void SetFilter(IFilter filter)
        {
            filterChain.AddFilter(filter);
        }

        public void FilterRequest(string request)
        {
            filterChain.Execute(request);
        }
    }

    public class Client
    {
        FilterManager filterManager;

        public void SetFilterManager(FilterManager filterManager){
            this.filterManager = filterManager;
        }

        public void SendRequest(string request)
        {
            filterManager.FilterRequest(request);
        }
    }
}
