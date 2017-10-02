using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.TravelCompany
{
    class TravelCompany
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, int>> result = new Dictionary<string, Dictionary<string, int>>();
            string[] input = Console.ReadLine().Split(new string[] { ":", "-", "," }, StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "ready")
            {
                

                string city = input[0];

                if (!result.ContainsKey(city))
                {
                    result[city] = new Dictionary<string, int>();
                }
                for (int i = 1; i < input.Length; i += 2)
                {
                    var string1 = input[i].Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);

                    var typesOfVehicles = input[i];
                    int capacity = int.Parse(input[i + 1]);
                    result[city][typesOfVehicles] = capacity;
                }
                input = Console.ReadLine().Split(new string[] { ":", "-", "," }, StringSplitOptions.RemoveEmptyEntries);
            }
            var SecondInput = Console.ReadLine().Split(' ');
            Dictionary<string, int> passengersDatabase = new Dictionary<string, int>();
            while (SecondInput[0] == "travel" && SecondInput[1]== "time!")
            {
                string city = SecondInput[0];

                int passanger = int.Parse(SecondInput[1]);


                if (!passengersDatabase.ContainsKey(city))
                {
                    passengersDatabase[city] = passanger;
                }

                SecondInput = Console.ReadLine().Split(' ');
            }
            

            //oreach (var databaseKvp in result)
            //
            //   foreach (var passengersDatabaseKvp in passengersDatabase)
            //   {
            //       if (databaseKvp.Key == passengersDatabaseKvp.Key)
            //       {
            //           totalPassenger = 0;
            //           for (int i = 0; i < 1; i++)
            //           {
            //               foreach (var component in databaseKvp.Value)
            //               {
            //                   int num = component.Value;
            //                   totalPassenger += num;
            //               }
            //               if (totalPassenger >= passengersDatabaseKvp.Value)
            //               {
            //                   Console.WriteLine($"{passengersDatabaseKvp.Key} " +
            //                                     $"-> all {passengersDatabaseKvp.Value} accommodated");
            //               }
            //               else
            //               {
            //                   int passengersShort = Math.Abs(totalPassenger - passengersDatabaseKvp.Value);
            //                   Console.WriteLine($"{passengersDatabaseKvp.Key} " +
            //                                     $"-> all except {passengersShort} accommodated");
            //               }
            //           }
            //       }
            //   }
            //
        }
    }
}
