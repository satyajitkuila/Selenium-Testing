using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCsharpTraining.CSharpPrograms.Day5
{
    internal class WriteFileDemo
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "JohnSnow", "Cersei", "Arya", "Jamie", "Tyrion" };

            using (StreamWriter sw = new StreamWriter("D:\\VS Studio Files\\ReadWriteFiles\\names.txt"))
            {

                foreach (string s in names)
                {
                    sw.WriteLine(s);
                }
            }

            Console.ReadKey();
        }
    }
}
