using System.Security.AccessControl;
using System.Linq;
using System.Collections.Generic;
using System;

namespace DataAccessObject
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentDao studentDao = new StudentDao();

            foreach (Student s in studentDao.GetAllStudent()) {
                Console.WriteLine("Student: [RollNo : " + s.RollNo + ", Name : " + s.Name + " ]");
            }

            Student student = studentDao.GetAllStudent()[0];
            student.Name = "Michael";
            studentDao.UpdateStudent(student);

            studentDao.GetStudent(0);
            Console.WriteLine("Student: [RollNo : " + student.RollNo + ", Name : " + student.Name + " ]");	
        }
    }

    public class Student
    {
        public string Name { get; set; }
        public int RollNo { get; set; }

        public Student(string name, int rollNo)
        {
            Name = name;
            RollNo = rollNo;
        }
    }

    public interface IStudentDao
    {
        List<Student> GetAllStudent();
        Student GetStudent(int RollNo);
        void UpdateStudent(Student student);
        void DeleteStudent(Student student);
    }

    public class StudentDao : IStudentDao
    {
        List<Student> students;

        public StudentDao()
        {
            students = new List<Student>();
            Student student1 = new Student("Robert",0);
            Student student2 = new Student("John",1);
            students.Add(student1);
            students.Add(student2);
        }

        public void DeleteStudent(Student student)
        {
            students.RemoveAt(student.RollNo);
            Console.WriteLine("Student Roll No " + student.RollNo);
        }

        public List<Student> GetAllStudent()
        {
            return students;
        }

        public Student GetStudent(int rollNo)
        {
            return students[rollNo];
        }

        public void UpdateStudent(Student student)
        {
            students.Where(x=>x.RollNo == student.RollNo).Select(x=> x.Name = student.Name);
            Console.WriteLine("Updated" + students.FirstOrDefault(x=>x.RollNo == student.RollNo).Name);
        }
    }
}
