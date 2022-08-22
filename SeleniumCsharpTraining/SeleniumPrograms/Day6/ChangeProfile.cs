using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCsharpTraining.SeleniumPrograms.Day6
{
    internal class ChangeProfile
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


            //Logout
            driver.FindElement(By.XPath("//span[contains(text(),'Log Off')]")).Click();
            driver.FindElement(By.XPath("//span[contains(text(),'Continue')]")).Click();
            driver.Close();





        }
    }
}

