namespace SeleniumCsharpTraining.CSharpPrograms.Day3
{
    internal class SalaryProcessing
    {
        static void Main(string[] args)
        {
            double nsal = 0.0;
            Console.WriteLine("Enter the salary");
            double sal = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Years of employment");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the performance index");
            int pi = int.Parse(Console.ReadLine());

            if (pi > 0 && pi < 3)
            {
                if (year > 0 && year < 2)
                {
                    //0 %
                    Console.WriteLine($"There is 0% appraisal and the salary is {nsal}");
                }
                else if (year > 2 && year < 5)
                {
                    // 0%
                    Console.WriteLine($"There is 0% appraisal and the salary is {nsal}");
                }
                else if (year > 5)
                {
                    Console.WriteLine($"There is 0% appraisal and the salary is {nsal}");
                    Console.WriteLine("We regret to inform that employee to QUIT!");
                }
                else
                {
                    Console.WriteLine("Entered values are out of record");
                }

            }
            else if (pi > 3 && pi < 5)
            {
                if (year > 0 && year < 2)
                {
                    //10%
                    nsal = sal + (10 * sal) / 100;
                    Console.WriteLine($"There is 10% appraisal and the salary is {nsal}");
                }
                else if (year > 2 && year < 5)
                {
                    //20%
                    nsal = sal + (20 * sal) / 100;
                    Console.WriteLine($"There is 20% appraisal and the salary is {nsal}");
                }
                else if (year > 5)
                {
                    //50%
                    nsal = sal + (50 * sal) / 100;
                    Console.WriteLine($"There is 50% appraisal and the salary is {nsal}");

                }
                else
                {
                    Console.WriteLine("Entered values are out of record");
                }

            }
            else
            {
                Console.WriteLine("Entered values are out of record");
            }

        }
    }
}
