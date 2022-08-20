namespace SeleniumCsharpTraining.CSharpPrograms.Day4
{
    internal class DictionaryDemo
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> myDict = new Dictionary<int, string>();
            myDict.Add(1, "Tom:CEO:54");
            myDict.Add(2, "Rads:HR Head:65");
            myDict.Add(3, "Fiona:CTO:43");
            myDict.Add(4, "Daniel:CFO:59");

            Console.WriteLine(myDict[3]);

            for (int i = 1; i <= myDict.Count; i++)
            {
                String emp = myDict[i];
                String[] arrOfStr = emp.Split(':');
                Console.WriteLine($"Employee id: {i}");
                for (int j = 0; j < arrOfStr.Length; j++)
                {

                    Console.WriteLine($"Name: {arrOfStr[j++]}");
                    Console.WriteLine($"Designation: {arrOfStr[j++]}");
                    Console.WriteLine($"age: {arrOfStr[j]}");
                }



            }
        }
    }
}
