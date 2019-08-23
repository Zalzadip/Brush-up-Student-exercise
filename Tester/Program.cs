using System;
using Brush_up__Student;

namespace Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            CreateStudent();

            //Console.WriteLine(student.Name);
            //Console.WriteLine(student.Address);
        }

        static void CreateStudent()
        {
            Student student = new Student();
            student.Name = "Morten";
            student.Address = "Knud";
            student.Semester = 3;
            student.Gender = GenderType.Male;

            Console.WriteLine(student.ToString());
        }
    }
}
