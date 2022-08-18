using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCsharpTraining.CSharpPrograms.Day1
{
     class AreaOfCircle
    {
        static void Main(String[] args)
        {
            int rad = 0;
            double area = 0.0;
            Console.WriteLine("Enter the radius");
            String r= Console.ReadLine();
            rad = Convert.ToInt32(r);
            area =3.141*rad*rad;
            Console.WriteLine($"Area of circle is {area}");


        }
    }
}
