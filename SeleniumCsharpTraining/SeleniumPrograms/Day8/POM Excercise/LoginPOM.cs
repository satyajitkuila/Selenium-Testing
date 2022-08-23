using OpenQA.Selenium;


namespace SeleniumCsharpTraining.SeleniumPrograms.Day8
{
    internal class LoginPOM:DriverHelper
    {
        
        IWebElement txtusername =>Driver.FindElement(By.Name("email_address"));
        IWebElement txtpassword =>Driver.FindElement(By.Name("password"));
        IWebElement btnlogin => Driver.FindElement(By.Id("tdb5"));

        public void entercredentials(string username,string password)
        {
            txtusername.SendKeys(username);
            txtpassword.SendKeys(password); 

        }
        public void clickLogin()
        {
            btnlogin.Click();
        }


    }
}
