using System.Net.Mime;
using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
           IImage image = new ProxyImage("text_10mb.jpg");

           image.Display();

           Console.WriteLine("--");

           //Image will not be loaded 
           image.Display();
        }
    }

    public interface IImage
    {
        void Display();
    }

    public class RealImage : IImage
    {
        private string fileName;

        public RealImage(string fileName)
        {
            this.fileName = fileName;
            LoadFromDisk(fileName);
        }

        public void Display()
        {
            Console.WriteLine("Displaying"+this.fileName);
        }

        private void LoadFromDisk(string fileName)
        {
            Console.WriteLine("Loading "+fileName);
        }
    }

    public class ProxyImage : IImage
    {
        private RealImage realImage;
        private string fileName;

        public ProxyImage(string fileName)
        {
            this.fileName = fileName;
        }

        public void Display()
        {
            if(realImage == null)
            {
                realImage = new RealImage(fileName);
            }
            realImage.Display();
        }
    }
}
