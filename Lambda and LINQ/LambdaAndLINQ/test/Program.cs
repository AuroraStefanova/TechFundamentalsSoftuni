using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {//
         //  List<int> numbers = new List<int>
         //  {
         //      6, 21, 1, -90, 1000
         //  };
         //
         //  Console.WriteLine(string.Join( numbers.OrderBy(c=> )

            Dictionary<string, int> student = new Dictionary<string, int>
            {
                ["Pesho"] = 3,
                ["Mimi"] = 6,
                ["Gosho"] = 3,
            };

            student = student.OrderBy(s => s.Value).ToDictionary(key => key.Key, val => val.Value);
        }
    }
}
