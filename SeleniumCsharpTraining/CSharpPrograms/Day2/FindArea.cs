namespace SeleniumCsharpTraining.CSharpPrograms.Day2
{
    internal class FindArea
    {
        static void Main(string[] args)
        {
            double l, b, h = 0;

            double area;
            Console.WriteLine("1.Square");
            Console.WriteLine("2.Rectangele");
            Console.WriteLine("3.Triangle");
            Console.WriteLine("Enter your Choice to find area:");
            int chc = int.Parse(Console.ReadLine());


            if (chc == 1)
            {
                Console.WriteLine("enter length");
                l = double.Parse(Console.ReadLine());
                area = l * l;
                Console.WriteLine($"The area is {area}");
            }
            else if (chc == 2)
            {
                Console.WriteLine("enter length");
                l = double.Parse(Console.ReadLine());
                Console.WriteLine("enter breadth");
                b = double.Parse(Console.ReadLine());
                area = l * b;
                Console.WriteLine($"The area is {area}");
            }
            else if (chc == 3)
            {
                Console.WriteLine("enter breadth");
                b = double.Parse(Console.ReadLine());
                Console.WriteLine("enter height");
                h = double.Parse(Console.ReadLine());
                area = (b * h) / 2;
                Console.WriteLine($"The area is {area}");
            }
            else
            {
                Console.WriteLine($"{chc} is a invalid choice Try Again !");
            }


        }
    }
}
