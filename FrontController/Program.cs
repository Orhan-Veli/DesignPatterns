using System;

namespace FrontController
{
    class Program
    {
        static void Main(string[] args)
        {
            FrontController frontController = new FrontController();
            frontController.DispatchRequest("HOME");
            frontController.DispatchRequest("STUDENT");
        }
    }

    public class HomeView
    {
        public void Show()
        {
            Console.WriteLine("Displaying HomePage");
        }
    }

    public class StudentView
    {
        public void Show()
        {
            Console.WriteLine("Displaying student page");
        }
    }

    public class Dispatcher
    {
        public StudentView StudentView { get; set; }
        public HomeView HomeView { get; set; }

        public Dispatcher()
        {
            StudentView = new StudentView();
            HomeView = new HomeView();
        }

        public void Dispatch(string request)
        {
            if(request == "STUDENT") StudentView.Show();
            else HomeView.Show();
        }
    }

    public class FrontController
    {
        public Dispatcher Dispatcher { get; set; }

        public FrontController()
        {
            Dispatcher = new Dispatcher();
        }

        private bool IsAuthenticUser()
        {
            Console.WriteLine("User auth");
            return true;
        }

        private void TrackRequest(string request)
        {
            Console.WriteLine("Page request" + request);
        }

        public void DispatchRequest(string request)
        {
            this.TrackRequest(request);

            if(IsAuthenticUser())
            {
                Dispatcher.Dispatch(request);
            }
        }
    }
}
