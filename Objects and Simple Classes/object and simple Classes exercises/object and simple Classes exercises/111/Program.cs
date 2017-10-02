using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._1.Exercises
{
    class Exercises
    {
        public string Topic { get; set; }
        public string CourseName { get; set; }
        public string JudgeContestLink { get; set; }
        public List<string> Problem { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();

            List<Exercises> result = new List<Exercises>();

            while (inputLine != "go go go")
            {
                string[] token = inputLine.Split(new char[] { ' ', '-', '>', ',' }, StringSplitOptions.RemoveEmptyEntries);

                string topic = token[0];
                string corseNsme = token[1];
                string judgeContest = token[2];
                var problems = token.Skip(3).ToList();
                Exercises newExercises = new Exercises();

                newExercises.Topic = topic;
                newExercises.CourseName = corseNsme;
                newExercises.JudgeContestLink = judgeContest;
                newExercises.Problem = problems;

                result.Add(newExercises);

                inputLine = Console.ReadLine();
            }
            foreach (var item in result)
            {
                Console.WriteLine($"Exercises: {item.Topic}");
                Console.WriteLine($"Problems for exercises and homework for the \"{ item.CourseName}\" course @ SoftUni.");
                Console.WriteLine($"Check your solutions here: {item.JudgeContestLink}");

                int count = 1;
                foreach (var problem in item.Problem)
                {
                    Console.WriteLine($"{count}. {problem}");
                    count++;
                }
            }
        }
    }
}
