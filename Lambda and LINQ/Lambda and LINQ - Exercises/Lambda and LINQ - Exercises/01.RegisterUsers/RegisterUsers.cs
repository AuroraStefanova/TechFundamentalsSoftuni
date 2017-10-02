using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.RegisterUsers
{
    class RegisterUsers
    {
        static void Main(string[] args)
        {
            Dictionary<string, DateTime> registredUser = new Dictionary<string, DateTime>();
            string[] input = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "end")
            {
                var user = input[0];
                var date = input[1];

                var date1 = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                registredUser[user] = date1;

                input = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
            }

            var result = registredUser.Reverse()
                .OrderBy(x => x.Value)
                .Take(5)
                .OrderByDescending(x => x.Value);

            foreach (var kvp in result)
            {
                Console.WriteLine(kvp.Key);
            }
        }
    }
}
