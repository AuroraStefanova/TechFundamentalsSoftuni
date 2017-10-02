using System;
namespace _03.EmployeeData
{
    class EmployeeData
    {
        static void Main()
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int employee = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Employee ID: {employee:00000000}");
            Console.WriteLine($"Salary: {salary:F2}");
        }
    }
}
