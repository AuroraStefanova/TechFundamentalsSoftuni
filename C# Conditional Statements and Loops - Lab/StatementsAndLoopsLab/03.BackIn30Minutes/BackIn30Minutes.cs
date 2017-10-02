using System;


namespace _03.BackIn30Minutes
{
    class BackIn30Minutes
    {
        static void Main()
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int after30Min = minutes + 30;
            int allHours = hours * 60;
            int sum = allHours + after30Min;

            if(sum/60 > 23)
            {
                Console.WriteLine($"0:{sum % 60:D2}");//D2
            }
            if( sum / 60 <= 23)
            {
                Console.WriteLine($"{sum / 60}:{sum % 60:D2}");
            }

        }
    }
}
