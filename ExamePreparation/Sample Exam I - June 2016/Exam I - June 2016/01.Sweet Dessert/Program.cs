using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Sweet_Dessert
{
    class Program
    {
        static void Main(string[] args)
        {
            double cashIvancho = double.Parse(Console.ReadLine());
            double gestsnumbers = double.Parse(Console.ReadLine());
            double bananaPrice = double.Parse(Console.ReadLine());//for one 
            double eggsPrise = double.Parse(Console.ReadLine());//for one 
            double berriesPrice = double.Parse(Console.ReadLine());//for one kilo

            double needsforOnePart = (eggsPrise * 4) + (bananaPrice * 2) + (berriesPrice * 0.2);
            double set = Math.Ceiling (gestsnumbers / 6);
            double needMony = (set * needsforOnePart);

            if( cashIvancho >= needMony)
            {
                
                Console.WriteLine($"Ivancho has enough money - it would cost {needMony:F2}lv.");
            }
            else
            {
                double sum = needMony - cashIvancho;
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {sum:F2}lv more.");
            }
        }
    }
}
