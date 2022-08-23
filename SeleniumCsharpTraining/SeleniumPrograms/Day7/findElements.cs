using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCsharpTraining.SeleniumPrograms.Day7
{
    internal class findElements
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://5elementslearning.dev/demosite/";

            IReadOnlyCollection< IWebElement > links = driver.FindElements(By.TagName("a"));
            List<WebElement> list = new List<WebElement>();


            foreach (IWebElement link in links)
            {
                Console.WriteLine(link.Text);   
                Console.WriteLine("-"+link.GetAttribute("href"));
            }


        }
    }
}
