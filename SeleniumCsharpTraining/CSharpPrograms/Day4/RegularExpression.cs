using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SeleniumCsharpTraining.CSharpPrograms.Day4
{
    internal class RegularExpression
    {
        static void Main(string[] args)
        {
            //Q1.caat,cat,caaaat,caaaaaaaaat...## pattern = "^ca*t$";
            //Q2.gold,told,bold,sold... ## pattern ="^[a-z]old$"
            //Q3.mobile no of 10 digits starts with 98 ## pattern = @"^98\d{8}";
           //Q4.DEF432G,GTH987M,VCD923$

            RegularExpression rg =new RegularExpression();
            String pattern = @"[a-zA-Z]+[0-9]\d+[a-zA-z]";
            
            MatchCollection mt =Regex.Matches("DEF432G,GTH987M,VCD923$", pattern);
            Console.WriteLine("{0} matches", mt.Count);

        }
    }
}
