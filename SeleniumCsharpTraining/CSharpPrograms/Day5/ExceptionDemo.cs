using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCsharpTraining.CSharpPrograms.Day5
{
    internal class ExceptionDemo
    {
        int result;
        ExceptionDemo()
        {
            result = 0;
        }

        public void division(int num1, int num2)
        {
            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Exception caught: {0}", e);
            }
            finally
            {
                Console.WriteLine("Result: {0}", result);
            }
        }

        static void Main(string[] args)
        {
            ExceptionDemo d = new ExceptionDemo();
            d.division(25, 0);
            Console.ReadKey();
        }
    }
}
