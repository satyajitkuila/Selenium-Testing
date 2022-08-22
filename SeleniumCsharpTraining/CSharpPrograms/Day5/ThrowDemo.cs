using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCsharpTraining.CSharpPrograms.Day5
{
    class ThrowDemo
    {
        static int GetValueFromArray(int[] array, int index) 
        {
            try
            {
                return array[index];
            }
            catch (System.IndexOutOfRangeException ex)
            {
                System.ArgumentException argEx = new System.ArgumentException("Index is out of range", "index", ex);
                throw argEx;
                //throw ex;
            }
        }
        static void Main(string[] args)
        {
            int[] numbers = new int[3];
            numbers[0] = 10;
            numbers[1] = 32;
            numbers[2] = 43;
            try
            {
                Console.WriteLine(GetValueFromArray(numbers, 9));
            }catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }
            Console.ReadLine();
        }
    }
}
