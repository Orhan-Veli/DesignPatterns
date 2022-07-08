using System;

namespace Mvc
{
    class Program
    {
        static void Main(string[] args)
        {
            Student model = RetrieveStudentFromDatabase();

            StudentView view = new StudentView();
            StudentController controller = new StudentController(model,view);

            controller.UpdateView();
            controller.Model.Name = "John";
            controller.UpdateView();
            
        }
        private static Student RetrieveStudentFromDatabase()
        {
            Student student = new Student();
            student.Name = "Robert";
            student.RollNo = "10";
            return student;
        }
    }

    public class Student
    {
        public string RollNo { get; set; }
        public string Name { get; set; }
    }

    public class StudentView
    {
        public void PrintStudentDetails(string studentName, string studentRollName)
        {
            Console.WriteLine("Student: ");
            Console.WriteLine("Name: " + studentName);
            Console.WriteLine("Roll No: " + studentRollName);
        }
    }
    
    public class StudentController
    {
        public Student Model { get; set; }
        public StudentView View { get; set; }

        public StudentController(Student model, StudentView view)
        {
            Model = model;
            View = view;
        }

        public void UpdateView()
        {
            View.PrintStudentDetails(Model.Name, Model.RollNo);
        }
    }
}
