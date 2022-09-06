using NUnit.Framework;
using OpenQA.Selenium;
using SpecFlowProject.Support;

namespace SpecFlowProject.StepDefinitions
{
    [Binding]
    public class SwagLabsStepDefinitions : DriverHelper
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
            IWebElement user = Driver.FindElement(By.XPath("//input[@id='user-name']"));
            
            if (user.Displayed == true)
            {
                user.SendKeys(testusername);
                Driver.FindElement(By.XPath("//input[@id='password']")).SendKeys(testPassword);

            }
            else
            {
                Driver.FindElement(By.XPath("//button[@id='react-burger-menu-btn']")).Click();
                Thread.Sleep(2000);
                Driver.FindElement(By.XPath("//a[@id='logout_sidebar_link']")).Click();
            }

        }




        [When(@"Click on the Login button")]
        public void WhenClickOnTheLoginButton()
        {
            Driver.FindElement(By.XPath("//input[@id='login-button']")).Click();
        }

        [Then(@"Successful LogIN is there")]
        public void ThenSuccessfulLogINIsThere()
        {
            try
            {
                IWebElement prodlink = Driver.FindElement(By.XPath("//div[normalize-space()='Sauce Labs Backpack']"));
                prodlink.Displayed.Should().BeTrue();
                Console.WriteLine("Login Succeessfull");
            }
            catch (Exception ex)
            {
                IWebElement errormsg = Driver.FindElement(By.XPath("//h3[@data-test='error']"));
                string erm = errormsg.Text;
                Assert.IsTrue(false, erm);
            }

        }

        [When(@"User Logs Out from the Application")]
        public void WhenUserLogsOutFromTheApplication()
        {
            Driver.FindElement(By.XPath("//button[@id='react-burger-menu-btn']")).Click();
            Thread.Sleep(2000);
            Driver.FindElement(By.XPath("//a[@id='logout_sidebar_link']")).Click();
        }

        [Then(@"Successful Logout page")]
        public void ThenSuccessfulLogoutPage()
        {
            IWebElement logout = Driver.FindElement(By.XPath("//div[@class='login_logo']"));
            logout.Displayed.Should().BeTrue();
        }
    }
}
