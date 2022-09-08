using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Learning.Examples
{
    internal class RandomFileNameGenerator
    {
        public static void Main(string[] args)
        {
            RandomFileNameGenerator generator = new RandomFileNameGenerator();
            string f=generator.getfilename();
            Console.WriteLine(f);   

        }
        public string getfilename()
        {
            DateTime dt = DateTime.Now;
            string str2 = dt.ToString().Replace(" ", "-").Replace(":", "-");

            string str1 = "File-";
            string fileName = str1 + str2;
            return fileName;
        }
       
    }
}
