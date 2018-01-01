using System;
using System.Collections.Generic;

namespace first_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> bikes = new List<string>();

            bikes.Add("Kawasaki");
            bikes.Add("Triumph");
            bikes.Add("BMW");
            bikes.Add("Moto Guzzi");
            bikes.Add("Harley Davidson");
            bikes.Add("Suzuki");

            bikes.Insert(2, "Yamaha");

            System.Console.WriteLine("the current manufacturers we have seen are:");
            for (var i = 0; i < bikes.Count; i++)
            {
                System.Console.WriteLine("-" + bikes[i]);
            }

            bikes.Remove("Suzuki");
            bikes.Remove("Yamaha");
            bikes.RemoveAt(0);

            System.Console.WriteLine("List on non japanese manufacturers:");
            foreach(string manu in bikes)
            {
                System.Console.WriteLine("-" + manu);
            }

        }
    }
}

