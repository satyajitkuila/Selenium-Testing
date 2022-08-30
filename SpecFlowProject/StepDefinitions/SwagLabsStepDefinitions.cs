using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject.StepDefinitions
{
    [Binding]
    public class SwagLabsStepDefinitions:DriverHelper
    {

        


        [Given(@"User is at the swag labs Page")]
        public void GivenUserIsAtTheSwagLabsPage()
        {
            
            Driver.Url = "https://www.saucedemo.com/";
            Driver.Manage().Window.Maximize();
        }

        [When(@"User enters the (.*) and (.*)")]
        public void WhenUserEntersTheTestusernameAndSecret_Sauce(string testusername, string testPassword)
        {
            Driver.FindElement(By.XPath("//input[@id='user-name']")).SendKeys(testusername);
            Driver.FindElement(By.XPath("//input[@id='password']")).SendKeys(testPassword);
        }




        [When(@"Click on the Login button")]
        public void WhenClickOnTheLoginButton()
        {
            Driver.FindElement(By.XPath("//input[@id='login-button']")).Click();
        }

        [Then(@"Successful LogIN is there")]
        public void ThenSuccessfulLogINIsThere()
        {

            // Assert.IsTrue(ele.Text.Contains("Products"));
            string htmlpage = Driver.PageSource;
            Console.WriteLine(htmlpage);
            Assert.IsTrue(Driver.FindElement(By.XPath("//span[@class='title']")).Text.Contains(htmlpage));

        }

        [When(@"User Logs Out from the Application")]
        public void WhenUserLogsOutFromTheApplication()
        {
            Driver.FindElement(By.XPath("//button[@id='react-burger-menu-btn']")).Click();
            Driver.FindElement(By.XPath("//a[@id='logout_sidebar_link']")).Click();
        }

        [Then(@"Successful Logout page")]
        public void ThenSuccessfulLogoutPage()
        {
            IWebElement logout = Driver.FindElement(By.XPath("//div[@class='login_logo']"));
            Assert.IsTrue(logout.Text.Contains("login_logo"));
        }
    }
}
