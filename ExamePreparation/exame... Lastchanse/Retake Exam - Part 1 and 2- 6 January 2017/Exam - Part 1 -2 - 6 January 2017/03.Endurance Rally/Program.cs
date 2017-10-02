using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Endurance_Rally
{
    class Program
    {
        static void Main(string[] args)
        {
            var driversNames = Console.ReadLine().Split(' ').ToList();
            var trackZone = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            var checkpoint = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            double fuelNum = 0;

            for (int i = 0; i < driversNames.Count; i++)
            {
                char firstLetter = driversNames[i][0];// взимам първата буква на шофьора 
                fuelNum = (int)firstLetter;//превръщам я в цифра за горивото

                for (int j = 0; j < trackZone.Count; j++)
                {
                    if (checkpoint.Contains(j))
                    {
                        fuelNum += trackZone[j];
                    }
                    else
                    {
                        fuelNum -= trackZone[j];

                        if(fuelNum <= 0)
                        {
                            Console.WriteLine($"{driversNames[i]} - reached {j}");
                            break;
                        }
                    }
                }
                if(fuelNum > 0)
                {
                    Console.WriteLine($"{driversNames[i]} - fuel left {fuelNum:F2}");
                }
            }
        }
    }
}
