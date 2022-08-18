using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCsharpTraining.CSharpPrograms.Day1
{
    internal class SimpleInterest
    {
        static void Main(string[] args)
        {
            double si = 0.0;
            double amt = 0.0;
            double p=0.0;  
            double r=0.0;
            double t=0.0;
            
            Console.WriteLine("Enter the Loan amount:");
            p=double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Rate of interest:");
            r = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the period of loan:");
            t = double.Parse(Console.ReadLine());

            si = (p * r * t) / 100;
            amt = si + p;

            Console.WriteLine($"The final amount to be paid to bank is {amt} for {t} years");
        }
    }
}
