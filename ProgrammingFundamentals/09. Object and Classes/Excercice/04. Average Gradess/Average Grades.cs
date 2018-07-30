using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Average_Gradess
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List <Student> students = new List<Student>();
            for (int i = 0; i < n; i++)
            {
                Student student = new Student();
                string[] inputArgs = Console.ReadLine().Split(' ');
                student.Name = inputArgs[0];
                student.Grade = inputArgs.Skip(1).Select(double.Parse).ToList();
                students.Add(student);
            }

            students.Where(s => s.Average >= 5.00)
                .OrderBy(s => s.Name)
                .ThenByDescending(s => s.Average)
                .ToList()
                .ForEach(s => Console.WriteLine($"{s.Name} -> {s.Average:F2}"));
        }
    }

    public class Student
    {
        public string Name { get; set; }
        public List<double> Grade { get; set; }
        public double Average => Grade.Average();
    }
}