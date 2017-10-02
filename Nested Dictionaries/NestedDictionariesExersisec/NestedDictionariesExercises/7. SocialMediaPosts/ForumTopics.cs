using System;
using System.Collections.Generic;
using System.Linq;
namespace _7.SocialMediaPosts
{
    class ForumTopics
    {
        static void Main()
        {

            Dictionary<string, Dictionary<string, string>> postComment = new Dictionary<string, Dictionary<string, string>>();

            Dictionary<string, int> postLikes = new Dictionary<string, int>();

            Dictionary<string, int> postDislikes = new Dictionary<string, int>();

            string[] input = Console.ReadLine().Split(' ');

            while (input[0] != "drop")
            {
                if(input[0] == "post")
                {
                    if (!postComment.ContainsKey(input[1]))
                    {
                        postComment.Add(input[1], new Dictionary<string, string>());
                    }

                    postLikes.Add(input[1], 0);
                    postDislikes.Add(input[1], 0);
                }
                else if(input[0] == "like")
                {
                    postLikes[input[1]]++;
                }
                else if(input[0] == "dislike")
                {
                    postDislikes[input[1]]++;
                }
                else if(input[0] == "comment")
                {
                    string comment = string.Empty;//

                    for (int i = 0; i < input.Length; i++)
                    {
                        comment += input[i] + " ";
                    }
                    postComment[input[1]].Add(input[2], comment);
                }

                input = Console.ReadLine().Split(' ');
            }

            foreach (var kvp in postComment)
            {
                Console.WriteLine($"Post: {kvp.Key} | Likes: {postLikes[kvp.Key]} | Dislikes: {postDislikes[kvp.Key]}");
                Console.WriteLine("Comments:");
                bool hasComments = false;

                foreach (var comment in kvp.Value)
                {
                    hasComments = true;
                    Console.WriteLine($"*  {comment.Key}: {comment.Value}");
                }
                if (!hasComments)
                {
                    Console.WriteLine("None");
                }
            }
        }
    }
}
