using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MirrorImage
{
    class Program
    {
        static void Main()
        {
            var elementsColection = Console.ReadLine()
                .Split(' ')
                .ToList();

            var nThIndex = Console.ReadLine();

            var firstElement = new List<string>();
            var secondElements = new List<string>();
            var result = new List<string>();
            while (nThIndex != "Print")
            {
                int index = int.Parse(nThIndex);

                for (int i = 0; i < int.Parse(nThIndex); i++)
                {
                    firstElement.Add(elementsColection[i]);
                    
                }
                firstElement.Reverse();

                for (int i = int.Parse(nThIndex) + 1; i < elementsColection.Count; i++)// 10 20 30 40 50 
                {
                    secondElements.Add(elementsColection[i]);
                    
                }
                secondElements.Reverse();

                result.AddRange(firstElement);
                var numIndex = elementsColection.IndexOf(nThIndex);
                result.Add(elementsColection[index]);
                result.AddRange(secondElements);


                
                elementsColection.Clear();
                elementsColection.AddRange(result);
                firstElement.Clear();
                secondElements.Clear();
                result.Clear();

                nThIndex = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", elementsColection));
        }
    }
}
