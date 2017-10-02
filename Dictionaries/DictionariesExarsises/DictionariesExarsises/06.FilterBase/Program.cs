using System;
using System.Collections.Generic;
using System.Linq;
namespace _06.FilterBase
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, int> ageName = new Dictionary<string, int>();
            Dictionary<string, double> nameSalary = new Dictionary<string, double>();
            Dictionary<string, string> positionName = new Dictionary<string, string>();

            var input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            while (input[0] != "filter")
            {
                string name = input[0];
                var secondInput = input[2];
                int age = 0;
                double salary = 0.0;

                if(int.TryParse(secondInput, out age))
                {
                    ageName.Add(name, age);
                }
                else if(double.TryParse(secondInput, out salary))
                {
                    nameSalary.Add(name, salary);
                }
                else
                {
                    positionName.Add(name, secondInput);
                }

                input = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
            }

            input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();


            if (input[0] == "Position")
            {
                foreach (var kvp in positionName)
                {
                    string name = kvp.Key;
                    string secondInput = kvp.Value;
                    Console.WriteLine($"Name: {name}");
                    Console.WriteLine($"Position: {secondInput}");
                    Console.WriteLine(new string('=', 20));
                }

            }
            else if (input[0] == "Salary")
            {
                foreach (var kvp in nameSalary)
                {
                    string name = kvp.Key;
                    double salary = kvp.Value;
                    Console.WriteLine($"Name: {name}");
                    Console.WriteLine($"Salary: {salary:F2}");
                    Console.WriteLine(new string('=', 20));
                }

            }
            else if (input[0] == "Age")
            {
                foreach (var kvp in ageName)
                {
                    string name = kvp.Key;
                    int age = kvp.Value;
                    Console.WriteLine($"Name: {name}");
                    Console.WriteLine($"Age: {age}");
                    Console.WriteLine(new string('=', 20));
                }
            }
        }
    }
}
