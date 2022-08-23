using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCsharpTraining.SeleniumPrograms.Day7
{
    internal class HandleDropdownElement
    {
        static void Main(String[] args)
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://www.5elementslearning.com/demosite";
            driver.FindElement(By.CssSelector("#tdb3 > span.ui-button-text")).Click();
            driver.FindElement(By.CssSelector("#tdb4 > span.ui-button-text")).Click();
            SelectElement country = new SelectElement(driver.FindElement(By.Name("country")));
            country.SelectByText("India");
            Console.WriteLine(country.SelectedOption.Text);
            Thread.Sleep(5000);
            country.SelectByValue("3");
            Console.WriteLine(country.SelectedOption.Text);
            Thread.Sleep(5000);
            country.SelectByIndex(5);
            Console.WriteLine(country.SelectedOption.Text);
            Thread.Sleep(5000);
            Console.Read();

            driver.Close();
        }
    }
}
