using System;
using System.Collections.Generic;
using System.Linq;

namespace тест_3
{
    class Program
    {
        static void Main()
        {
            var name = new List<string>();
            name.Add("Pesho");//0
            name.Add("kiro");//1
            name.Add("Maria");//2
            name.Add("Ivan");//3
            name.Add("Nakov");//4
            
            name.Insert(2, "bash selqnin");//5
            //name.RemoveAt(2);
            name[4] = "chance people";// dostyp po indeks

            //name.Remove("Pesho");
            Console.WriteLine(string.Join(",", name));
            
        }
    }
}
