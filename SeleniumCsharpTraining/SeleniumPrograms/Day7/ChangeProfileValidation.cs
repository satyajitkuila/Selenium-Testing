using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumCsharpTraining.SeleniumPrograms.Day7
{
    internal class ChangeProfileValidation
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://5elementslearning.dev/demosite/";


            //Login
            driver.FindElement(By.XPath("//span[contains(text(),'My Account')]")).Click();
            driver.FindElement(By.Name("email_address")).SendKeys("sam123@gmail.com");
            driver.FindElement(By.Name("password")).SendKeys("user123");
            driver.FindElement(By.XPath("//span[contains(text(),'Sign In')]")).Click();

            //Change Profile
            string val1 = "jackson";

            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//a[normalize-space()='View or change my account information.']")).Click();
            driver.FindElement(By.XPath("//input[@name='lastname']")).Clear();
            driver.FindElement(By.XPath("//input[@name='lastname']")).SendKeys(val1);
            driver.FindElement(By.XPath("//span[contains(text(),'Continue')]")).Click();

            //Change Profile Validation
            if (driver.FindElement(By.XPath("//td[@class='messageStackSuccess']")) != null)
            {
                driver.FindElement(By.XPath("//a[normalize-space()='View or change my account information.']")).Click();
                string val2 = driver.FindElement(By.XPath("//input[@name='lastname']")).GetAttribute("value");

                if (val1 == val2)
                {
                    Console.WriteLine("Value is changed successfully in lastname field");
                }

            }
            //Logout
            driver.FindElement(By.XPath("//span[contains(text(),'Log Off')]")).Click();
            driver.FindElement(By.XPath("//span[contains(text(),'Continue')]")).Click();
            driver.Close();
        }
    }
}
