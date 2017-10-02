using System;

namespace _01.Hello
{
    class Hello
    {
        static void Main()
        {
            string name = Console.ReadLine();

            HelloYou(name);
            Console.WriteLine($"{name}!");
        }
        static void HelloYou(string Yourname)
        {
            Console.Write("Hello, ");
        }
    }
}
