using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCsharpTraining.CSharpPrograms.Day5
{
    internal class ReadFile
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("D:\\VS Studio Files\\ReadWriteFiles\\names.txt"))
            {
                string line;

                // Read and display lines from the file until 
                // the end of the file is reached. 
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }


            }
        }
        
    }
}
