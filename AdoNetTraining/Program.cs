using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Name :");
            //string name = Console.ReadLine();

            //Console.Write("RegisterNumber :");
            //string regno = Console.ReadLine();

            //Student student = new Student();
            //student.Name            = name;
            //student.RegisterNumber = regno;

            //student.Save();

            //if (student.Id > 0)
            //{
            //    Console.WriteLine($"Student successfully created with id: {student.Id}");
            //}
            //else
            //    Console.WriteLine("Failed to create the student");

            var students = Student.GetStudents();
            foreach(Student s in students)
            {
                Console.WriteLine($"Id : {s.Id} / Name : {s.Name} /RegisterNumber : {s.RegisterNumber}");
            }
            int Total = Student.GetTotalStudentCount();
            Console.WriteLine("============================");
            Console.WriteLine($"Total number of student : {Total}");
            
        }
    }
}
