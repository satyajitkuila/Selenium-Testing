internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter the Value");
        string s1=Console.ReadLine();
        
        s1 = s1.Replace("@123##sed**", "");
        Console.Write(s1);
        Console.ReadLine(); 
        
    }
}