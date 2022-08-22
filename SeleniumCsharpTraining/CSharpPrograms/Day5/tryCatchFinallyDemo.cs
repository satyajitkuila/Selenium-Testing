using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCsharpTraining.CSharpPrograms.Day5
{
    class tryCatchFinallyDemo
    {
        static void Main(string[] args)
        {
             
            int[] marks = new int[10];
            try
            {
                for (int i = 0; i < marks.Length; i++)
                {
                    Console.WriteLine("Enter marks for student " + (i + 1));
                    marks[i] = int.Parse(Console.ReadLine());
                }

                //Find the one who scored highest
                int highest = 0;
                for (int j = 0; j <= marks.Length; j++)
                {
                    if (highest < marks[j])
                    {
                        highest = marks[j];
                    }
                }
                Console.WriteLine("Highest marks are: " + highest);
            }catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Console.WriteLine("I am in the finally block");
            }
            Console.ReadLine();
        }
    }
}
