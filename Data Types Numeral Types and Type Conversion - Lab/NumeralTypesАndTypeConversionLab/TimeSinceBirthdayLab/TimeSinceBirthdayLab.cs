using System;


namespace TimeSinceBirthdayLab
{
    class TimeSinceBirthdayLab
    {
        static void Main()
        {
            int years = int.Parse(Console.ReadLine());
            //Console.Write("years");
            int days = years * 365;
            int hours = days * 24;
            int min = hours * 60;
            Console.WriteLine($"{years} years = {days} days = {hours} hours = {min} minutes.");
        }
    }
}
