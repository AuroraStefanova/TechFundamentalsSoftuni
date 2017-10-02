using System;


namespace _05.WordInPlural
{
    class WordInPlural
    {
        static void Main()
        {
            string words = Console.ReadLine();

            if (words.EndsWith("y"))
            {
                words = words.TrimEnd('y');
                words += "ies";
            }
            else if(words.EndsWith("o")|| words.EndsWith("ch")|| words.EndsWith("s")|| words.EndsWith("sh")|| words.EndsWith("x") || words.EndsWith("z"))
            {
                words += "es"; 
            }
            else
            {
                words += "s";
            }
            Console.WriteLine(words);
        }
    }
}
