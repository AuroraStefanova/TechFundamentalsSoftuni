using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._1.Exercises
{
    class Exercise
    {
        public string Topic { get; set; }
        public string CourseName { get; set; }
        public string JudgeContestLink { get; set; }
        public List<string> Problems { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Exercise ex = new Exercise();
            string commandLine = Console.ReadLine();
            while (commandLine != "go go go")
            {
                string[] tokens = commandLine.Split(new string[]
                { " -> " }, StringSplitOptions.None);
                string[] problems = tokens[3].Split(new string[]
                { ", " }, StringSplitOptions.None);

                ex.Topic = tokens[0];
                ex.CourseName = tokens[1];
                ex.JudgeContestLink = tokens[2];
                ex.Problems = problems.ToList();
                Console.WriteLine($"Exercises: {ex.Topic}");
                Console.WriteLine($"Problems for exercises and homework for the \"{ex.CourseName}\" course @ SoftUni.");
                Console.WriteLine($"Check your solutions here: {ex.JudgeContestLink}");
                for (int i = 1; i <= ex.Problems.Count; i++)
                {
                    Console.WriteLine($"{i}. {ex.Problems[i - 1]}");
                }
                commandLine = Console.ReadLine();
            }
        }
    }
}
