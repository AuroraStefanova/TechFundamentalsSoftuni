using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime radoBDay = new DateTime(1992, 8, 27);
            DateTime BajHuiBday = new DateTime(1997, 6, 8);
            
            Console.WriteLine("{0:dd/MMMM/yyyy}", BajHuiBday.AddDays(3));


            //===========RANDOM ==================================================== 
            Random rnd = new Random(100);

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(rnd.Next(1, 20));

            }


        }
    }
}
