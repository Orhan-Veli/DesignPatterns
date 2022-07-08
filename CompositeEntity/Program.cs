using System;

namespace CompositeEntity
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            client.SetData("Test","Data");
            client.PrintData();
            client.SetData("Second Test","Data1");
            client.PrintData();
        }
    }

    public class DependentObject1
    {
        public string Data { get; set; }
    }

    public class DependentObject2
    {
        public string Data { get; set; }
    }

    public class CoarseGrainedObject
    {
        DependentObject1 do1 = new DependentObject1();
        DependentObject2 do2 = new DependentObject2();

        public void SetData(string data1, string data2)
        {
            do1.Data = data1;
            do2.Data = data2;
        }

        public string[] GetData()
        {
            return new string[] {do1.Data,do2.Data};
        }
    }

    public class CompositeEntity
    {
        private CoarseGrainedObject cgo = new CoarseGrainedObject();

        public void SetData(string data1,string data2)
        {
            cgo.SetData(data1,data2);
        }

        public string[] GetData()
        {
            return cgo.GetData();
        }
    }

    public class Client
    {
        private CompositeEntity compositeEntity = new CompositeEntity();

        public void PrintData()
        {
            for (int i = 0; i < compositeEntity.GetData().Length; i++)
            {
                Console.WriteLine("Data: " + compositeEntity.GetData()[i]);
            }
        }

        public void SetData(string data1, string data2)
        {
            compositeEntity.SetData(data1,data2);
        }
    }
}
