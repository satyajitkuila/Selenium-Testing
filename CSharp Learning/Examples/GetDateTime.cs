using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Learning.Examples
{
    internal class GetDateTime
    {
        public static void Main(string[] args)
        {
            DateTime start = DateTime.Now;
            Console.WriteLine(start.ToString());    
        }
    }
}
