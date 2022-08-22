using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCsharpTraining.CSharpPrograms.Day6
{
    internal class IE:Browser
    {
        public static void Main(string[] args)
        {
            IE ie = new IE();
            Console.WriteLine(ie.browserName("IE"));
            Console.WriteLine(ie.zoomSettings(100));
            Console.Read();
        }
    }
}
