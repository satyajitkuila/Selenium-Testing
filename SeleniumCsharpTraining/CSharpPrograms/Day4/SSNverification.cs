using System.Text.RegularExpressions;

namespace SeleniumCsharpTraining.CSharpPrograms.Day4
{
    internal class SSNverification
    {
        static void Main(string[] args)
        {
            String Pattern = "^(?!666|000|9\\d{2})\\d{3}-(?!00)\\d{2}-(?!0{4})\\d{4}$";
            Regex rg = new Regex(Pattern);
            MatchCollection mt;

            String str1 = "856-45-6789";
            mt = rg.Matches(str1);
            


            Console.WriteLine("{0} matches", mt.Count);
        }
    }
}
