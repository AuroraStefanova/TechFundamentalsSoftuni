using System;

namespace secondTest
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintStudent("Pesho", 32, 5.78);
        }
        static double Fibonacci(int number)
        {
            return Fibonacci(number - 1) + Fibonacci(number - 2);
        }
        static void PrintStudent(string name, int age, double grade)
        {
            Console.WriteLine("Student: {0}; Age: {1}, Grade: {2}", name, age, grade);
        }
    }
}
