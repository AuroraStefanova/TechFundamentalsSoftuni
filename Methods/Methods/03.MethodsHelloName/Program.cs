using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MethodsHelloName
{
    class Program
    {
        static void Main()
        {
            string name = Console.ReadLine();
            Name(name);
            Console.WriteLine(name);
        }
        static void Name(string theName)
        {
            Console.WriteLine("Hello, {0}!", theName);
            theName = theName + "DFG$H$";
            Console.WriteLine(theName);
        }
    }
}
