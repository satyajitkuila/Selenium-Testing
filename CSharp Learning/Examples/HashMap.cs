using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*##HashMap.For C# programs,##
 we do not use a HashMap as a collection of key-value pairs. 
 Instead we use a Dictionary. Java programs use HashMap,
 and this functionality can be translated to C#.This image shows a dictionary.
 ##Methods, notes. ##
 The put() method on HashMap can be changed to the Add() method on Dictionary. 
 And we can use TryGetValue instead of getOrElse.*/


namespace CSharp_Learning.Examples
{
    //Example program. To begin,
    //we have a program in C# that adds 3 string keys with 3 int values to a Dictionary.
    //We get one of the values. Then we try to get a value that does not exist.
    internal class HashMap
    {
        public static void Main(string[] args)
        {
            // Create Dictionary.
            Dictionary<string, int> hash = new Dictionary<string, int>();

            // Add some data.
            hash.Add("diamond", 500);
            hash.Add("ruby", 200);
            hash.Add("pearl", 100);

            // Get value that exists.
            int value1 = hash["diamond"];
            Console.WriteLine("get DIAMOND: " + value1);

            // Get value that does not exist.
            hash.TryGetValue("coal", out int value2);
            Console.WriteLine("get COAL: " + value2);

            // Loop over items in collection.
            foreach (KeyValuePair<string, int> pair in hash)
            {
                Console.WriteLine("KEY: " + pair.Key);
                Console.WriteLine("VALUE: " + pair.Value);
            }
        }
    }
}
