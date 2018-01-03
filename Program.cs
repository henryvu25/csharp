using System;
using System.Collections.Generic;

namespace first_csharp
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numberArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            System.Console.WriteLine(numberArray[0]);

            string[] names = { "Tim", "Martin", "Nikki", "Sara" };

            bool[] boolArr = new bool[10];
            for (var i = 0; i < boolArr.Length; i++)
            {
                if (i % 2 == 0)
                {
                    boolArr[i] = true;
                }
                else
                {
                    boolArr[i] = false;
                }
            }
            System.Console.WriteLine(boolArr[3]);

            List<string> icecream = new List<string>();

            icecream.Add("chocolate");
            icecream.Add("vanilla");
            icecream.Add("rockyroad");
            icecream.Add("straberry");
            icecream.Add("greentea");

            System.Console.WriteLine(icecream.Count);
            System.Console.WriteLine(icecream[2]);
            icecream.Remove(icecream[2]);
            System.Console.WriteLine(icecream.Count);

            Dictionary<string, string> faveicecream = new Dictionary<string, string>();

            for (int x = 0; x < names.Length; x++)
            {
                faveicecream.Add(names[x], null);
            }
            Random randoAF = new Random();

            for (int z = 0; z < names.Length; z++)
            {
                faveicecream[names[z]] = icecream[randoAF.Next(0, names.Length)];
            }

            foreach (var m in faveicecream)
            {
                System.Console.WriteLine(m.Key + "+" + m.Value);
            }
            // Random randoAF = new Random();
            // for(int y = 0; y < names.Length; y++)
            // {
            //     foreach(KeyValuePair<string,string> m in faveicecream)
            //     {
            //         m.Key = icecream[randoAF.Next(0,names.Length)];
            //     }
            // }

        }
    }
}

