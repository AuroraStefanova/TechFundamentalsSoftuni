using System;
namespace _01.BlankReceipt
{
    class BlankReceipt
    {
        static void Main()
        {
            PrintReceipt();

        }

        static void PrintReceipt()
        {
            PrintHeader();
            PrintBody();
            PrinFooter();
        }

        static void PrinFooter()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("\u00A9 SoftUni");
        }

        static void PrintHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }

        static void PrintBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }

    }
}
