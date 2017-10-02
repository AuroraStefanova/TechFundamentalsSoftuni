using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.RotateArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrToString = Console.ReadLine().Split(' ').ToList();
            var lastElementh = arrToString.Last();
            var newElement = new string[arrToString.Count];
            newElement[0] = arrToString[arrToString.Count - 1];
            for (int i = 0; i < arrToString.Count-1; i++)
            {
                newElement[i + 1] = arrToString[i];
            }
            Console.WriteLine(string.Join(" ",newElement));
        }
    }
}
