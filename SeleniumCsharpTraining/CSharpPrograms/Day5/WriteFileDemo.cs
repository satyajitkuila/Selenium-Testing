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
            string[] names = new string[] { "sam1123@gmail.com,user123", "sam123@gmail.com,user123" };

            using (StreamWriter sw = new StreamWriter("D:\\VS Studio Files\\ReadWriteFiles\\tdata.csv"))
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
