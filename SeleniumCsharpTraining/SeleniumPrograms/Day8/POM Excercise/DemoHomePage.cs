using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCsharpTraining.SeleniumPrograms.Day8
{
    internal class DemoHomePage : DriverHelper
    {
        IWebElement loginlink => Driver.FindElement(By.XPath("//span[contains(text(),'My Account')]"));

        public void ClickMyaccount()
        {
            loginlink.Click();
        }
        public void closebrws()
        {
            Driver.Close();
        }
    }
}
