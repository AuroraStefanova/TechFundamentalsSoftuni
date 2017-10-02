namespace WormTest
{
    using System;
    public class WormTest
    {
        public static void Main()
        {
            long lengthInCentimeters = long.Parse(Console.ReadLine()) * 100;
            double widthInCentimeters = double.Parse(Console.ReadLine());

            var remainder = lengthInCentimeters % widthInCentimeters;
            if (widthInCentimeters == 0)
            {
                var result = lengthInCentimeters * widthInCentimeters;
                Console.WriteLine($"{result:F2}");

            }
            else if (remainder <= 0)
            {
                var calculated = lengthInCentimeters * widthInCentimeters;
                Console.WriteLine($"{calculated:f2}");
                return;
            }
            else if (remainder != 0)
            {
                var result = (lengthInCentimeters / widthInCentimeters) * 100;
                Console.WriteLine($"{result:f2}%");
            }
        }
    }
}
