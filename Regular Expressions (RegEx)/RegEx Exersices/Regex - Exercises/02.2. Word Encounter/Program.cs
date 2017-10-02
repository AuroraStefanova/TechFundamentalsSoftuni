using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _02.Word_Encounter
{
    class Program
    {
        static void Main(string[] args)
        {
            string pat = @"^[A-Z].*([\.|!|\?])$";
            string pattern = @"\w+";
            Regex regex = new Regex(pat);
            Regex reg = new Regex(pattern);

            var firstInput = Console.ReadLine();
            var inputline = Console.ReadLine();
            var listKolection = new List<string>();

            while (inputline != "end")
            {
                
                var needChar = firstInput[0];
                int num = int.Parse(firstInput[1].ToString());
                 
              
                bool isMatch = regex.IsMatch(inputline);

                if(isMatch)
                {

                    MatchCollection maches = reg.Matches(inputline);
               
                    foreach (Match item in maches)
                    {
                        var current = item.Value;
                        int count = 0;

                        for (int i = 0; i < current.Length; i++)
                        {
                            
                            if (current[i] == needChar)
                            {
                                count++;
                            }
                        }

                        if(count >= num)
                        {
                            listKolection.Add(current);
                        }

                    }
                }

                inputline = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", listKolection));
        }
    }
}
