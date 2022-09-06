using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecFlowProject.Support;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject.StepDefinitions
{
    [Binding]
    public class ZohoLoginStepDefinitions:DriverHelper

    {
        [Given(@"Zoho user on login page")]
        public void GivenZohoUserOnLoginPage()
        {
            Driver.Url = "https://www.zoho.com/";
            Driver.Manage().Window.Maximize();

        }

        [When(@"the user on zoho enters (.*) and (.*)")]
        public void WhenTheUserOnZohoEntersRaghavAnd(string p0, string p1)
        {
            Driver.FindElement(By.XPath("//a[normalize-space()='Sign in']")).Click();
            Driver.FindElement(By.XPath("//input[@id='login_id']")).SendKeys(p0);
            Driver.FindElement(By.XPath("//form[@id='login']//button[@id='nextbtn']")).Click();

            Thread.Sleep(2000);
            Driver.FindElement(By.XPath("//input[@id='password']")).SendKeys(p1);
        }

        [When(@"he clicks on login button on zoho")]
        public void WhenHeClicksOnLoginButtonOnZoho()
        {
            Driver.FindElement(By.XPath("//form[@id='login']//button[@id='nextbtn']")).Click();
        }

        [When(@"Zoho user is navigated to the home page")]
        public void WhenZohoUserIsNavigatedToTheHomePage()
        {
            String title = Driver.Title;
            Assert.AreEqual( "Zoho Accounts",title, "User not on Home Page");

        }

        [Then(@"Close the browser on ZOHO")]
        public void ThenCloseTheBrowserOnZOHO()
        {
            Thread.Sleep(2000);
            Driver.FindElement(By.XPath("//img[@id='ztb-profile-image-pre']")).Click();
            Thread.Sleep(2000);
            Driver.FindElement(By.XPath("//div[@id='ztb-profile']")).Click();
        }
    }
}
