using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Net;
using System.Diagnostics;

namespace DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime inputData = DateTime.ParseExact(Console.ReadLine(), "d-M-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(inputData.DayOfWeek);
           //
           // WebClient WebClient = new WebClient();
           // WebClient.DownloadFile("http://www.introprogramming.info/wp-content/uploads/2015/10/Intro-CSharp-Book-v2015.pdf", "book.pdf");
           // Process.Start("book.pdf");
           //

        }
    }
}
