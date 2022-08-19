using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCsharpTraining.CSharpPrograms.Day3
{
    internal class StringReverse
    {
        static void Main(string[] args)
        {
            String rev = "";
            Console.WriteLine("Enter the string to be reversed");
            String str = Console.ReadLine();
            int l = str.Length;
            char[] ch = new char[l];
            for (int i = 0; i < l; i++)
            {
                ch[i] = str[i];

            }
            for (int i = l - 1; i >= 0; i--)
            {
                rev = rev + ch[i];

            }
            Console.WriteLine(rev);

        }
    }
}
