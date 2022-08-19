namespace SeleniumCsharpTraining.CSharpPrograms.Day3
{
    internal class StringOperation
    {
        static void Main(string[] args)
        {
            String[] str = new String[5];
            Console.WriteLine("Enter 5 string");
            for (int i = 0; i < 5; i++)
            {

                str[i] = Console.ReadLine();

            }
            int count = 0;
            int[] l = new int[5];
            int big=0;
            for (int i = 0; i < 5; i++)
            {
                String s = str[i];
                l[i] = s.Length;
                while(s[0].Equals('s'))
                {
                    count++;
                }
                
                
            }

            Console.WriteLine($"{count} strings have 's' as the first letter ");
            



        }
    }
}
