using System;

namespace _10.DataOverflow
{
    class DataOverflow
    {
        static void Main()
        {
            decimal first = decimal.Parse(Console.ReadLine());
            decimal second = decimal.Parse(Console.ReadLine());
            decimal overflow = 0;
            string type = string.Empty;
            
            decimal fuck = Math.Min(first, second);
            decimal againFuck = Math.Max(first, second);

            if(fuck <= byte.MaxValue)
            {

                overflow = byte.MaxValue;
                type = "byte";

            }

            else if( fuck <= ushort.MaxValue)
            {
                overflow = ushort.MaxValue;
                type = "ushort";

            }

            else if(fuck <= uint.MaxValue)
            {
                overflow = uint.MaxValue;
                type = "uint";
            }

            else if(fuck <= ulong.MaxValue)
            {
                overflow = ulong.MaxValue;
                type = "ulong";
            }

            string type1 = string.Empty;

            if (againFuck <= byte.MaxValue)
            {
                
                type1 = "byte";
            }

            else if (againFuck <= ushort.MaxValue)
            {
                
                type1 = "ushort";
            }
            else if (againFuck <= uint.MaxValue)
            {
                
                type1 = "uint";
            }

            else if (againFuck <= ulong.MaxValue)
            {
                
                type1 = "ulong";
            }

            decimal allGnqs = againFuck / overflow;

            Console.WriteLine($"bigger type: {type1}");
            Console.WriteLine($"smaller type: {type}");
            Console.WriteLine($"{againFuck} can overflow {type} {Math.Round( allGnqs)} times");
        }
    }
}
