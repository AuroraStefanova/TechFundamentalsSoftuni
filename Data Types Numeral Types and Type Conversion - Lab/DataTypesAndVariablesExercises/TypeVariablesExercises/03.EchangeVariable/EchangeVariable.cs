using System;


namespace _03.EchangeVariable
{
    class EchangeVariable
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = a;
            a = b;
            Console.WriteLine(a);
            Console.WriteLine(c);
        }
    }
}
