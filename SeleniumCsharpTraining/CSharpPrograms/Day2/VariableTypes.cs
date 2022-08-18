namespace SeleniumCsharpTraining.CSharpPrograms.Day2
{
    internal class VariableTypes
    {
        static void Main(string[] args)
        {
            String s = " ";
            int i;
            double d;
            bool b;

            Console.WriteLine("Enter the data to know the type");
            String s2 = Console.ReadLine();

            if (int.TryParse(s2, out i))
            {
                Console.WriteLine($"{s2} is a Integer Data Type");
            }
            else if (double.TryParse(s2, out d))
            {
                Console.WriteLine($"{s2} is a Double Data Type");
            }
            else if (bool.TryParse(s2, out b))
            {
                Console.WriteLine($"{s2} is a Boolean Data Type");
            }
            else
            {
                Console.WriteLine($"{s2} is a String Data Type");
            }
        }
    }
}
