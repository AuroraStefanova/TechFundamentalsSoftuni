using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());

            double howfN = (N * 50) / 100.0;
            int count = 0;
            //int result = 0;
            while (N >= M)
            {
                
                if (N != howfN)
                {
                    N -= M;
                    count++;
                }
                else
                {
                    N /= Y;
                    
                }
                
            }
            Console.WriteLine(N);
            Console.WriteLine(count);
        }
    }
}
