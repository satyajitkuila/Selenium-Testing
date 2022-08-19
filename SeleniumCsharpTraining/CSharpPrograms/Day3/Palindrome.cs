namespace SeleniumCsharpTraining.CSharpPrograms.Day3
{
    internal class Palindrome
    {
        static void Main(string[] args)
        {
            String rev = "";
            Console.WriteLine("Enter the string to be reversed");
            String str = Console.ReadLine();
            int l = str.Length;
            char[] ch = new char[l];
            for (int i = 0; i < l; i++)
            {
                ch[i] = str[i];

            }
            for (int j = l - 1; j >= 0; j--)
            {
                rev = rev + ch[j];

            }
            Console.WriteLine(rev);
            
            if (str.Equals(rev))
            {
                Console.WriteLine("String is a Palindrome");
            }
            else
            {
                Console.WriteLine("String is Not a Palindrome");
            }


        }
    }
}
