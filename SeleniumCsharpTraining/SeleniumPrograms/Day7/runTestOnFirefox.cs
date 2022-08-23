using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace SeleniumCsharpTraining.SeleniumPrograms.Day7
{
    class runTestOnFirefox
    {
        static void Main(String[] args)
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://www.5elementslearning.com/demosite";
            driver.FindElement(By.LinkText("My Account")).Click();
            driver.FindElement(By.Name("email_address")).SendKeys("user@user.com");
            driver.FindElement(By.Name("password")).SendKeys("USER123");
            driver.FindElement(By.Id("tdb5")).SendKeys(Keys.Escape);
            driver.FindElement(By.Id("tdb5")).Click();
            driver.FindElement(By.LinkText("Log Off")).Click();
            driver.FindElement(By.LinkText("Continue")).Click();
            driver.Close();
        }
    }
}
