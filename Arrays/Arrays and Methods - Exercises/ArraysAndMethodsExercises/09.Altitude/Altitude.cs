using System;
using System.Linq;
namespace _09.Altitude
{
    class Altitude
    {
        static void Main()
        {
            string[] commands = Console.ReadLine().Split(' ');
            long startAltitude = long.Parse(commands[0]);
            for (int i = 1; i < commands.Length; i += 2)
            {
                string direction = commands[i];
                long altitudeOffset = long.Parse(commands[i + 1]);

                if(direction == "down")
                {
                    startAltitude -= altitudeOffset;
                }

                if( direction == "up")
                {
                    startAltitude += altitudeOffset;
                }

                if (startAltitude <= 0)
                {
                    Console.WriteLine("crashed");
                    return;
                }
            }
            Console.WriteLine($"got through safely. current altitude: {startAltitude}m");
        }
    }
}
