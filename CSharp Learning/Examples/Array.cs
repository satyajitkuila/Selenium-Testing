using System.Collections.Generic;

namespace CSharp_Learning.Examples
{
    internal class Array
    {
        static void Main(string[] args)
        {
            Array li=new Array();
            li.frequency("w3resource");
            li.wordCount();

        }

        public void frequency(string data)
        {
            string s = data;
            var freq = from x in s group x by x into y select y;
            Console.WriteLine("Count of the chars are");
            foreach (var ArrEle in freq)
            {
                Console.WriteLine("Character " + ArrEle.Key + ": " + ArrEle.Count() + " times");
            }

        }
        public void wordCount()
        {
            //---------------------- One way of calculating the word occurence---------------------------//
            Console.WriteLine("//---------------------- One way of calculating the word occurence---------------------------//\r\n");
            string input = "this is is my test my";
            char[] separators = new char[] { ' ', ',', ':', ';', '?', '!', '\n', '\r', '\t' };

            var query = from s in input.Split(separators)
                        where s.Length > 0
                        group s by s into g
                        let count = g.Count()
                        orderby count descending
                        select new
                        {
                            Word = g.Key,
                            Count = count
                        };
            foreach (var s in query)
            {
                Console.WriteLine("Value: " + s.Word + " Count: " + s.Count);
            }

            //---------------------- 2nd way of calculating the word occurence---------------------------//
            Console.WriteLine("//---------------------- 2nd way of calculating the word occurence---------------------------//\r\n");

            string s1 = "this is is my test my";
            char[] separators2 = new char[] { ' ', ',', ':', ';', '?', '!', '\n', '\r', '\t' };
            string[] words = s1.Split(separators2);
            var query2 = from s in words
                         where s.Length > 0
                         group words by s into g
                         let count = g.Count()
                         orderby count descending
                         select new
                         {
                             Word = g.Key,
                             Count = count
                         };
            foreach (var s in query2)
            {
                Console.WriteLine("Value: " + s.Word + " Count: " + s.Count);
            }

        }
    }
}
