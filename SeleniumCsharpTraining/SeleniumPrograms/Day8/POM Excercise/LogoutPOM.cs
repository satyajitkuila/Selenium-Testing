using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCsharpTraining.SeleniumPrograms.Day8
{
    internal class LogoutPOM:DriverHelper
    {
        IWebElement logoff => Driver.FindElement(By.XPath("//span[contains(text(),'Log Off')]"));
        IWebElement cont => Driver.FindElement(By.XPath("//span[contains(text(),'Continue')]"));
        public void logoffbtn()
        {
            logoff.Click();
        }
        public void contbtn()
        {
            cont.Click();
        }



    }
}
