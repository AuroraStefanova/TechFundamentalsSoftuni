using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.RobbitHole
{
    class RobbitHole
    {
        static void Main()
        {
            var portalTravel = Console.ReadLine()
                .Split(' ')
                .ToList();

            int energy = int.Parse(Console.ReadLine());
            int index = 0;
            int position = 0;
            while (energy > 0)
            {

                string[] token = portalTravel[index].Split('|');
                string currentComand = token[0];

                if (currentComand == "RabbitHole")
                {
                    Console.WriteLine("You have 5 years to save Kennedy!");
                    return;
                }

                int shouldJump = int.Parse(token[1]);

                if (energy < shouldJump)
                {
                    Console.WriteLine("You are tired. You can't continue the mission.");
                    return;
                }

                if (currentComand == "Right")
                {
                    position = Math.Abs(index + int.Parse(token[1])) % portalTravel.Count;
                    energy -= shouldJump;
                    if (energy <= 0)
                    {
                        Console.WriteLine("You are tired. You can't continue the mission.");
                        return;
                    }
                }

                else if (currentComand == "Left")
                {
                    position = (index - int.Parse(token[1])) % portalTravel.Count;
                    energy -= shouldJump;
                    if (energy <= 0)
                    {
                        Console.WriteLine("You are tired. You can't continue the mission.");
                        return;
                    }

                    if (index == portalTravel.Count)
                    {
                        portalTravel[0] += shouldJump;
                    }
                        
                }
                else if (currentComand == "Bomb")
                {
                    
                    energy -= shouldJump;
                    portalTravel.RemoveAt(index);
                    if (energy <= 0)
                    {
                        Console.WriteLine("You are dead due to bomb explosion!");
                        return;
                    }
                    index = 0;
                }
            }

            if( portalTravel[portalTravel.Count - 1 ] != "RabbitHole")
            {
                portalTravel.RemoveAt(portalTravel.Count -1 );

            }
            portalTravel.Add("Bomb|" + energy);
        }
    }
}
