using System;

namespace BusinessDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessDelegate businessDelegate = new BusinessDelegate();
            businessDelegate.ServiceType = "EJB";

            Client client = new Client(businessDelegate);
            client.DoTask();

            businessDelegate.ServiceType = "JMS";
            client.DoTask();
        }
    }

    public interface IBusinessService
    {
        void DoProcessing();
    }

    public class EJBService : IBusinessService
    {
        public void DoProcessing()
        {
            Console.WriteLine("Processing task EJBService");
        }
    }

    public class JMSService : IBusinessService
    {
        public void DoProcessing()
        {
            Console.WriteLine("Processing task JMSServices");
        }
    }

    public class BusinessLookUp
    {
        public IBusinessService GetBusinessService(string serviceType)
        {
            return serviceType == "EJB" ? new EJBService() : new JMSService();
        }
    }

    public class BusinessDelegate
    {
        private BusinessLookUp lookupService = new BusinessLookUp();
        private IBusinessService businessService;
        public string ServiceType { get; set; }

        public void DoTask()
        {
            businessService = lookupService.GetBusinessService(ServiceType);
            businessService.DoProcessing();
        }
    }

    public class Client
    {
        BusinessDelegate businessService;

        public Client(BusinessDelegate businessService)
        {
            this.businessService = businessService;
        }

        public void DoTask()
        {
            businessService.DoTask();
        }
    }
}
