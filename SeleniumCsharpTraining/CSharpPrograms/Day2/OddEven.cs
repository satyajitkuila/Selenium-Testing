namespace SeleniumCsharpTraining.CSharpPrograms.Day2
{
    internal class OddEven
    {
        static void Main(string[] args)
        {
            int k;
            Console.WriteLine("Enter the integer to check:");

            while (true)
            {

                int n = int.Parse(Console.ReadLine());
                if (n > 0)
                {
                    k = n % 2;
                    if (k == 0)
                    {
                        Console.WriteLine($"{n} is an odd number");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"{n} is an even number");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("try again with a valid input !");
                }


            }
        }
    }
}
