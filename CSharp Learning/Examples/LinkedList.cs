namespace CSharp_Learning.Examples
{
    internal class LinkedList
    {
        static void Main(string[] args)
        {
            LinkedList li=new LinkedList();
            //li.frequency("w3resource");
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
            string s1 = "this is is my test my";
            string[] words = s1.Split("[, '?.@]+");
            var freq = from x in words  into y select y;
            Console.WriteLine("Count of the chars are");
            foreach (var ArrEle in freq)
            {
                Console.WriteLine("Character " + ArrEle.Key + ": " + ArrEle.Count() + " times");
            }

        }
    }
}
