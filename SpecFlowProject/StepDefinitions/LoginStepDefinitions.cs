using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace SpecFlowProject.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions:DriverHelper
    {
      

        [Given(@"User is at the Home Page")]
        public void GivenUserIsAtTheHomePage()
        {
           // driver = new ChromeDriver();
            Driver.Url = "https://5elementslearning.dev/demosite/";
            Driver.Manage().Window.Maximize();
            
        }

        [Given(@"Navigate to LogIn Page")]
        public void GivenNavigateToLogInPage()
        {
            Driver.FindElement(By.XPath("//span[contains(text(),'My Account')]")).Click();
           

        }

        [When(@"User enter UserName and Password")]
        public void WhenUserEnterUserNameAndPassword()
        {
            Driver.FindElement(By.Name("email_address")).SendKeys("sam123@gmail.com");
            Driver.FindElement(By.Name("password")).SendKeys("user1123");
      
        }

        [When(@"Click on the LogIn button")]
        public void WhenClickOnTheLogInButton()
        {
            Driver.FindElement(By.XPath("//span[contains(text(),'Sign In')]")).Click();
           

        }

        [Then(@"Successful LogIN message should display")]
        public void ThenSuccessfulLogINMessageShouldDisplay()
        {
            IWebElement body = Driver.FindElement(By.LinkText("View the orders I have made."));
            Assert.IsTrue(body.Text.Contains("View the orders I have made."));
            Thread.Sleep(2000);

        }

        [When(@"User LogOut from the Application")]
        public void WhenUserLogOutFromTheApplication()
        {
           Thread.Sleep(2000);  
            Driver.FindElement(By.XPath("//span[contains(text(),'Log Off')]")).Click();
            Driver.FindElement(By.XPath("//span[contains(text(),'Continue')]")).Click();

        }

        [Then(@"Successful LogOut message should display")]
        public void ThenSuccessfulLogOutMessageShouldDisplay()
        {

            Console.WriteLine("Success logout");
        }
    }
}
