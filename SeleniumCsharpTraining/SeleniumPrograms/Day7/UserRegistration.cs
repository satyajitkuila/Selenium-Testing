using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCsharpTraining.SeleniumPrograms.Day7
{
    internal class UserRegistration
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://www.5elementslearning.com/demosite";
            driver.FindElement(By.CssSelector("#tdb3 > span.ui-button-text")).Click();
            driver.FindElement(By.CssSelector("#tdb4 > span.ui-button-text")).Click();
            // ERROR: Caught exception [Error: Dom locators are not implemented yet!]
            driver.FindElement(By.Name("gender")).Click();
            driver.FindElement(By.Name("firstname")).Clear();
            driver.FindElement(By.Name("firstname")).SendKeys("Pallavi");
            driver.FindElement(By.Name("lastname")).Clear();
            driver.FindElement(By.Name("lastname")).SendKeys("Sharma");
            driver.FindElement(By.Id("dob")).Clear();
            driver.FindElement(By.Id("dob")).SendKeys("01/01/1983");
            driver.FindElement(By.Name("email_address")).Clear();
            driver.FindElement(By.Name("email_address")).SendKeys("pallavi3@info.com");
            driver.FindElement(By.Name("street_address")).Clear();
            driver.FindElement(By.Name("street_address")).SendKeys("gulmohar");
            driver.FindElement(By.Name("postcode")).Clear();
            driver.FindElement(By.Name("postcode")).SendKeys("201009");
            driver.FindElement(By.Name("city")).Clear();
            driver.FindElement(By.Name("city")).SendKeys("goa");
            driver.FindElement(By.Name("state")).Clear();
            driver.FindElement(By.Name("state")).SendKeys("goa");
            new SelectElement(driver.FindElement(By.Name("country"))).SelectByText("India");
            driver.FindElement(By.Name("country")).SendKeys("India");
            driver.FindElement(By.Name("telephone")).Clear();
            driver.FindElement(By.Name("telephone")).SendKeys("984433221");
            driver.FindElement(By.Name("newsletter")).Click();
            driver.FindElement(By.Name("password")).Clear();
            driver.FindElement(By.Name("password")).SendKeys("123456");
            driver.FindElement(By.Name("confirmation")).Clear();
            driver.FindElement(By.Name("confirmation")).SendKeys("123456");
            driver.FindElement(By.Id("tdb4")).Click();
            driver.FindElement(By.CssSelector("#tdb5 > span.ui-button-text")).Click();
            driver.FindElement(By.CssSelector("#tdb4 > span.ui-button-text")).Click();
            driver.FindElement(By.CssSelector("#tdb4 > span.ui-button-text")).Click();
        }
    }
}
