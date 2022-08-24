using System;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ProjectSelenium5ElementsLearning.SeleniumPrograms.Day_11
{
    [TestFixture]
    public class getScreenshotNunit
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new ChromeDriver();
            baseURL = "https://5elementslearning.dev/";
            verificationErrors = new StringBuilder();
        }

        [Test]
        public void TheScreenshotLoginLogoutTest()
        {
            driver.Navigate().GoToUrl(baseURL + "/demosite/");
            driver.FindElement(By.LinkText("My Account")).Click();
            driver.FindElement(By.Name("email_address")).Clear();
            driver.FindElement(By.Name("email_address")).SendKeys("user@user.com");
            driver.FindElement(By.Name("password")).Clear();
            driver.FindElement(By.Name("password")).SendKeys("USER@123");
            driver.FindElement(By.Id("tdb5")).SendKeys(Keys.Escape);
            driver.FindElement(By.Id("tdb5")).Click();
            if (driver.PageSource.Contains("My Account Information"))
            {
                Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
                ss.SaveAsFile("D:\\VS Studio Files\\Junk files\\validuser.jpg", ScreenshotImageFormat.Jpeg);
                driver.FindElement(By.LinkText("Log Off")).Click();
                driver.FindElement(By.LinkText("Continue")).Click();
                Assert.True(true, "User login Success");
            }
            else
            {
                Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
                ss.SaveAsFile("D:\\VS Studio Files\\Junk files\\invaliduser.jpg", ScreenshotImageFormat.Jpeg);
                Assert.Fail("Login not successful");
            }
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }


    }
}
