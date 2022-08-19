using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCsharpTraining.CSharpPrograms.Day1
{
    internal class Palindrome
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Word:");
            String str = Console.ReadLine();
            int length = str.Length;
            Console.WriteLine(length);
            String reverse = String.Empty;
            for (int i = length - 1; i >= 0; i--)
            {
                reverse += str[i];
            }
            Console.WriteLine(reverse);
            if (str.Equals(reverse))
            {
                Console.WriteLine($"{str} is a Palindrome");
            }
            else
            {
                Console.WriteLine($"{str} is  not a palindrome");
            }
        }
    }
}
