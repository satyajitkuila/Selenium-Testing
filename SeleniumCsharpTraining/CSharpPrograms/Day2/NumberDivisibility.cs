using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCsharpTraining.CSharpPrograms.Day2
{
    internal class NumberDivisibility
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int n = int.Parse(Console.ReadLine());

            int k =n % 2;
            int j=n % 3;

            if(k == 0)
            {
                if (j != 0)
                {
                    Console.WriteLine($"{n} is divisible by 2");
                }
                else
                {
                    Console.WriteLine($"{n} is divisible by 2 and 3");
                }

            }
            else
            {
                Console.WriteLine($"{n} is not divisible by 2 ");
            }

        }
    }
}
