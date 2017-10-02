using System;

namespace _05.ForeignLanguages
{
    class Program
    {
        static void Main()
        {
            string language = Console.ReadLine().ToLower();

            if((language == "england"||language == "usa"))
            {
                Console.WriteLine("English");
            }
            else if(language == "spain" || language == "argentina" || language == "mexico")
            {
                Console.WriteLine("Spanish");
            }
            else
            {
                Console.WriteLine("unknown");
            }
            
        }
    }
}
