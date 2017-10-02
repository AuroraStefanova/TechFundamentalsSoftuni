using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SweetDessert
{
    class Program
    {
        static void Main(string[] args)
        {
            double monyHave = double.Parse(Console.ReadLine());
            double gestNum = double.Parse(Console.ReadLine());
            double bananaPrice = double.Parse(Console.ReadLine());
            double egsPrice = double.Parse(Console.ReadLine());
            double beryPrice = double.Parse(Console.ReadLine());
            //for a set
            double needMonyBananas = bananaPrice * 2;
            double MonyForEgs = egsPrice * 4;
            double monyForBerry = beryPrice * 0.20;
            // how many sets 
            double set = Math.Ceiling(gestNum / 6);
            double allSpendMony = (needMonyBananas + monyForBerry + MonyForEgs) * set;

            if(monyHave >= allSpendMony)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {allSpendMony:F2}lv.");
            }
            else
            {
                double neededMoney = allSpendMony - monyHave;
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {neededMoney:F2}lv more.");
            }
        }
    }
}
