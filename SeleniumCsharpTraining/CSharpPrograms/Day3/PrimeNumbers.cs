using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCsharpTraining.CSharpPrograms.Day3
{
    internal class PrimeNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the range for the prime numbers:");
            int s=int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());

            for (int i = s; i <= e; i++)
            {
                int counter = 0;
                for (int j = 2; j <= i/2; j++)
                {
                    
                    if (i % j == 0)
                    {
                        counter++;
                        break;
                    }
                }

                if (counter == 0 && i != 1)
                {
                    Console.Write("{0} ", i);
                }
            }
            

        }
    }
}
