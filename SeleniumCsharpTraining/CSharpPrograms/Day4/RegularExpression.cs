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

            
            String pattern1 = @"[a-zA-Z]+[0-9]\d+[a-zA-z]";
            Regex regex = new Regex(pattern1);
            MatchCollection mt= regex.Matches("DEF432G,GTH987M,VCD923$");
            //MatchCollection mt =Regex.Matches("DEF432G,GTH987M,VCD923$", pattern);
            Console.WriteLine("{0} matches", mt.Count);

            String pattern2 = @"^ca*t$";
            //Regex regex2 = new Regex(pattern1);
            //MatchCollection mt2 = regex.Matches("ct,caat,cat,caaaat,caaaaaaaaat");
            MatchCollection mt2 =Regex.Matches("ct,caat,cat,caaaat,caaaaaaaaat", pattern2);
            Console.WriteLine("{0} matches", mt2.Count);


        }
    }
}
