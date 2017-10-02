using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.AvarageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> StudentGrades = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string[] token = Console.ReadLine().Split(' ');
                string namesStudent = token[0];
                var grades = double.Parse(token[1]);

                if (!StudentGrades.ContainsKey(namesStudent))
                {
                    StudentGrades[namesStudent] = new List<double>();

                }
                StudentGrades[namesStudent].Add(grades);
            }

            foreach (var namesStudent in StudentGrades)
            {
                string name = namesStudent.Key;
                var studentGrades = namesStudent.Value;


                 var average = studentGrades.Average();

                Console.Write($"{name} -> ");
                foreach (var grades in namesStudent.Value)
                {
                    
               
                    Console.Write($"{grades:F2} ");
                }
                Console.WriteLine($"(avg: {average:F2}) ");
            }
        }
    }
}
