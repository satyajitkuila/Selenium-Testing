using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
/*Q2.Parametrize the login logout scenario
        * read a csv file,which has two entries
        * valid login valid paswword
        * invalid login invlalid password
        * while loop-- read file--split--array
       */



namespace SeleniumCsharpTraining.SeleniumPrograms.Day7
{
    internal class Parametrization
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://5elementslearning.dev/demosite/";
            string line;
            string[] data = new string[5];
            StreamReader sr = new StreamReader("D:\\VS Studio Files\\ReadWriteFiles\\tdata.csv");
            while ((line = sr.ReadLine()) != null)
            {

                data = line.Split(',');
                //Console.WriteLine(line);

                foreach (string s in data)
                {
                    Console.WriteLine(s);
                }
                    //Login
                    driver.FindElement(By.XPath("//span[contains(text(),'My Account')]")).Click();
                    driver.FindElement(By.Name("email_address")).SendKeys(data[0]);
                    driver.FindElement(By.Name("password")).SendKeys(data[1]);
                    driver.FindElement(By.XPath("//span[contains(text(),'Sign In')]")).Click();

                if (driver.PageSource.Contains("My Account Information"))
                {

                    //Logout
                    driver.FindElement(By.XPath("//span[contains(text(),'Log Off')]")).Click();
                    driver.FindElement(By.XPath("//span[contains(text(),'Continue')]")).Click();
                    driver.Close();
                }
                else
                {
                    Console.WriteLine("Invalid Login credentials");
                }
            }
        }

    }
}
