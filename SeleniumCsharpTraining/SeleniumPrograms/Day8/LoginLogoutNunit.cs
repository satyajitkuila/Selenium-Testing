using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumCsharpTraining.SeleniumPrograms.Day8
{
    [TestFixture]
    internal class LoginLogoutNunit
    {

        private IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void test01() 
        {
            driver.Navigate().GoToUrl("https://5elementslearning.dev/demosite/");
            driver.Manage().Window.Size = new System.Drawing.Size(1382, 754);
            driver.FindElement(By.CssSelector("#tdb3 > .ui-button-text")).Click();
            driver.FindElement(By.Name("email_address")).Click();
            driver.FindElement(By.Name("email_address")).SendKeys("sam123@gmail.com");
            driver.FindElement(By.CssSelector("tr:nth-child(2) > .fieldKey")).Click();
            driver.FindElement(By.Name("password")).Click();
            driver.FindElement(By.Name("password")).SendKeys("user123");
            driver.FindElement(By.CssSelector(".ui-icon-key")).Click();
            driver.FindElement(By.CssSelector(".ui-button-text:nth-child(1)")).Click();
            driver.FindElement(By.CssSelector("#tdb4 > .ui-button-text")).Click();
            driver.FindElement(By.Id("bodyWrapper")).Click();

        }
        [TearDown]
        protected void TearDown()
        {
            driver.Quit();
        }
    }
}


