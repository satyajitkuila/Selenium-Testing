namespace SeleniumCsharpTraining.CSharpPrograms.Day3
{
    internal class Factorial
    {
        static void Main(string[] args)
        {
            int sum = 1;

            Console.WriteLine("Enter the number to find factorial");
            int f = int.Parse(Console.ReadLine());

            for (int i = 1; i <= f; i++)
            {
                sum = sum * i;

            }
            Console.WriteLine(sum);

        }
    }
}
