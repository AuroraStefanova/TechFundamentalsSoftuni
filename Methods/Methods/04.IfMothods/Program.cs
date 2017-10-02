using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.IfMothods
{
    class Program
    {
        static void Main()
        {
            int age = int.Parse(Console.ReadLine());
            string gender = Console.ReadLine();

            if( age < 16)
            {
                Smaller(gender);
            }
            else
            {
                Upper(gender);
            }
             
        }
        static void Upper(string theGender)// >= 16
        {
            if(theGender == "f")
            {
                Console.WriteLine("Ms.");
            }
            else if( theGender == "m")
            {
                Console.WriteLine("MR");
            }
            else
            {
                Console.WriteLine("The Fuck");
            }
        }
        static void Smaller(string theGender)// < 16
        {
            if (theGender == "f")
            {
                Console.WriteLine("Miss.");
            }
            else if (theGender == "m")
            {
                Console.WriteLine("Master");
            }
            else
            {
                Console.WriteLine("The Fuck");
            }
        }
    }
}
