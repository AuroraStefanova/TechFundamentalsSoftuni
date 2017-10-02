using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            var birthday = new { day = 27, month = 11, year = 1685 };
            Console.WriteLine(birthday.day);





            Hero batman = new Hero
            {
                secretName ="Bryse",
                HeroName = "Batman",
                Age= 40
                
            };
            List<Hero> heroes = new List<Hero>();

            Console.WriteLine(batman.secretName);
        }
    }
    class Hero
    {
        public string secretName { get; set; }
        public string HeroName { get; set; }
        public int Age { get; set; }
    }
}
