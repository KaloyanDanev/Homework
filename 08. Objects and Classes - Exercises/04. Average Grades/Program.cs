using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Average_Grades
{
    class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double Avarage => Grades.Average();
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                Student student = new Student();
                string[] inputArg = Console.ReadLine().Split();
                student.Name = inputArg[0];
                student.Grades = inputArg.Skip(1)
                    .Select(double.Parse)
                    .ToList();
                students.Add(student);
            }
            students
                .Where(s => s.Avarage >= 5.00)
                .OrderBy(s => s.Name)
                .ThenByDescending(s => s.Avarage)
                .ToList()
                .ForEach(s => Console.WriteLine($"{s.Name} -> {s.Avarage:f2}"));
        }
    }
}
