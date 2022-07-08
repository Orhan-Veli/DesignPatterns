using System.Security.AccessControl;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Linq;
using System;

namespace TransferObject
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentBO studentBusinessObject = new StudentBO();

            foreach (StudentVO s in studentBusinessObject.GetAllStudents()) {
                Console.WriteLine("Student: [RollNo : " + s.RollNo + ", Name : " + s.Name + " ]");
            }

            StudentVO student = studentBusinessObject.GetAllStudents()[0];
            student.Name = "Michael";
            studentBusinessObject.UpdateStudent(student);

            student = studentBusinessObject.GetStudent(0);
            Console.WriteLine("Student: [RollNo : " + student.RollNo + ", Name : " + student.Name + " ]");
        }
    }

    public class StudentVO
    {
        public string Name { get; set; }
        public int RollNo { get; set; }

        public StudentVO(string name, int rollNo)
        {
            Name = name;
            RollNo = rollNo;
        }
    }

    public class StudentBO
    {
        List<StudentVO> students;

        public StudentBO()
        {
            students = new List<StudentVO>();StudentVO student1 = new StudentVO("Robert",0);
            StudentVO student2 = new StudentVO("John",1);
            students.Add(student1);
            students.Add(student2);
        }

        public void DeleteStudent(StudentVO student)
        {
            students.RemoveAll(x=> x.RollNo == student.RollNo);
            Console.WriteLine("Deleted" + student.RollNo);
        }

        public List<StudentVO> GetAllStudents()
        {
            return students;
        }

        public StudentVO GetStudent(int rollNo)
        {
            return students.FirstOrDefault(x=> x.RollNo == rollNo);
        }

        public void UpdateStudent(StudentVO student)
        {
            students.Where(x=> x.RollNo == student.RollNo).Select(x=>x.Name = student.Name);
            Console.WriteLine("Student: Roll No " + student.Name +", updated in the database");
        }
    }
}
