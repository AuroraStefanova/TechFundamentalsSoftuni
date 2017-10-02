using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectPESHO
{
    class Program
    {
        static void Main(string[] args)
        {
            String ssdd = "2";
           

            try
            {
                int.Parse(ssdd);
                Console.WriteLine("try: yeeeeeeeeeeey");
            }
            catch
            {
                Console.WriteLine("catch: noooooooo");
            }

           //if (ssdd  == "2.5")
           //{
           //    Console.WriteLine("yeeeeeeeeeeeeeey");
           //}
           //else
           //{
           //    Console.WriteLine("noooooooo");
           //}
        }
    }
}
