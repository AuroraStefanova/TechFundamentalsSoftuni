using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.NoteStatistics
{
    class NoteStatistics
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToList();
            
            //var numbers = new List<double> { 293.66, 311.13, 293.66, 311.13, 349.23, 349.23 };

            var note = new List<string> { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };
            var frequency = new List<double> { 261.63, 277.18, 293.66, 311.13, 329.63, 349.23, 369.99, 392.00, 415.30, 440.00, 466.16, 493.88 };

            var result = new List<string>();
            double sumSharp = 0;
            double sumNature = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                int index = frequency.IndexOf(numbers[i]);
                result.Add(note[index]);
            }
            var sharp = new List<string>();
            var naturals = new List<string>();

            for (int i = 0; i < result.Count; i++)
            {
                if (result[i].Contains("#"))
                {
                    sharp.Add(result[i]);

                }
                else
                {
                    naturals.Add(result[i]);

                }
            }
            for (int i = 0; i < sharp.Count; i++)
            {
                int indexSharp = note.IndexOf(sharp[i]);
                double shaprIndex = frequency[indexSharp];
                sumSharp +=shaprIndex;
            }
            for (int i = 0; i < naturals.Count; i++)
            {
                int indexNaturals = note.IndexOf(naturals[i]);
                double naturalIndex = frequency[indexNaturals];
                sumNature += naturalIndex;
            }

            Console.WriteLine("Notes: {0}", string.Join(" ", result));
            Console.WriteLine("Naturals: {0}", string.Join(", ", naturals));
            Console.WriteLine("Sharps: {0}", string.Join(", ", sharp));
            Console.WriteLine($"Naturals sum: {sumNature}");
            Console.WriteLine($"Sharps sum: {sumSharp}");


        }
    }
}
