using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Notifications
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {

                string operationMessage = Console.ReadLine();

                if (operationMessage == "success")
                {
                    string operations = Console.ReadLine();
                    string massages = Console.ReadLine();
                    string result = ShowSuccess(operations, massages);
                    Console.WriteLine($"Message: {result}.");
                }
                else if (operationMessage == "error")
                {
                    string operations = Console.ReadLine();
                    int code = int.Parse(Console.ReadLine());
                    string result = ShowErr(operations, code);
                    Console.WriteLine($"Reason: {result}");
                }

            }
        }
        static string ShowSuccess( string operation, string message)
        {
            Console.WriteLine($"Successfully executed {operation}.");
            Console.WriteLine("==============================");

            return message;
        }
        static string ShowErr(string operation, int code)
        {
            Console.WriteLine($"Error: Failed to execute {operation}.");
            Console.WriteLine("==============================");
            Console.WriteLine($"Error Code: {code}.");
            string result = "";
            if(code < 0)
            {
                result = "Reason: Internal System Failure.";
            }
            else
            {
                result ="Reason: Invalid Client Data.";
            }

            return result;
        }
    }
}
