using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCsharpTraining.CSharpPrograms.Day3
{
    internal class Fibonacci
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            int c = 1;
            Console.WriteLine("Enter the range for the fibonacci series");
            int f = int.Parse(Console.ReadLine());
            for (int i = 1; i <= f; i++)
            {
                Console.WriteLine("{0}", a);
                a = b;
                b = c;
                c = a + b;
            }
        }
    }
}
