using System;
using System.Collections.Generic;

namespace first_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,string> profile = new Dictionary<string,string>();

            profile.Add("Name", "Henry");
            profile.Add("Language", "C#");
            profile.Add("Location", "Seattle");
            
            System.Console.WriteLine("User Profile:");
            System.Console.WriteLine("Name - " + profile["Name"]);
            System.Console.WriteLine("From - " + profile["Location"]);
            System.Console.WriteLine("Favorite language - " + profile["Language"]);
            
            foreach(KeyValuePair<string,string> entry in profile)
            {
                System.Console.WriteLine(entry.Key + " - " + entry.Value);
            }


        }
    }
}

