using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Karaoke
{
    class Program
    {
        static void Main(string[] args)
        {
            var peopleToSing = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            var songToSing = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            var inputLine = Console.ReadLine();

            var DicREsult = new Dictionary<string, List<string>>();

            while (inputLine != "dawn")
            {
                string[] token = inputLine.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                string name = token[0];
                string song = token[1];
                string awards = token[2];

                if(!peopleToSing.Contains(name) || !songToSing.Contains(song))
                {
                    inputLine = Console.ReadLine();
                    continue;
                }

                else if(peopleToSing.Contains(name) && songToSing.Contains(song))
                {
                    if (!DicREsult.ContainsKey(name))
                    {
                        DicREsult[name] = new List<string>();
                    }
                    if (!DicREsult[name].Contains(awards))
                    {
                        DicREsult[name].Add(awards);
                    }
                }

                inputLine = Console.ReadLine();
            }
            int count = 0;

            foreach (var namePeople in DicREsult.OrderByDescending(x => x.Value.Count))// key name i value - rewords
            {
                Console.WriteLine($"{namePeople.Key}: {namePeople.Value.Count} awards");


                foreach (var item in namePeople.Value.OrderBy(x => x))
                {
                    count++;
                    Console.WriteLine($"--{item}");
                }
               // for (int i = 0; i < namePeople.Value.Count; i++)
                //{
                //    count++;

                //    Console.WriteLine($"--{namePeople.Value.OrderBy(x=>x)[i]}");
                //}

            }
            if (count == 0)
            {
                Console.WriteLine("No awards");
            }
        }
    }
}
