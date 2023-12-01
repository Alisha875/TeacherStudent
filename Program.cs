using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherStudent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            List<Teacher> teachers = new List<Teacher>();
            List<Subject> subjects = new List<Subject>();

            // Fill with dummy data
            for (int i = 0; i < 10; i++)
            {
                Student student = new Student();
                student.FillWithDummyData();
                students.Add(student);
            }

            for (int i = 0; i < 5; i++)
            {
                Teacher teacher = new Teacher();
                teacher.FillWithDummyData();
                teachers.Add(teacher);
            }

            for (int i = 0; i < 6; i++)
            {
                Subject subject = new Subject();
                subject.Name = $"Subject {i + 1}";
                subjects.Add(subject);
            }

            // Display students in a class
            foreach (var student in students)
            {
                Console.WriteLine($"Student Name: {student.Name}, Class: {student.Class}, Section: {student.Section}");
            }

            // Display subjects taught by a teacher
            foreach (var teacher in teachers)
            {
                Console.WriteLine($"Teacher Name: {teacher.Name}");
                foreach (var subject in teacher.Subjects)
                {
                    Console.WriteLine($" Subject: {subject.Name}");
                }
            }
            Console.ReadKey();
        }
    }
}
