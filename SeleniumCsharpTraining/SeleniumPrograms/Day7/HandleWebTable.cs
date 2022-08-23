using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCsharpTraining.SeleniumPrograms.Day7
{
    internal class HandleWebTable
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://5elementslearning.dev/demosite/";

            IWebElement productTable=driver.FindElement(By.TagName("table"));
            IReadOnlyCollection<IWebElement> rows = productTable.FindElements(By.XPath("//*/tbody/tr"));

            foreach(IWebElement row in rows)
            {
                IReadOnlyCollection<IWebElement> cols = row.FindElements(By.TagName("td"));
                foreach (IWebElement col in cols)
                {
                    Console.WriteLine(col.Text);
                }
            }
            driver.Close();
            Console.ReadLine();
            

        }
    }
}
