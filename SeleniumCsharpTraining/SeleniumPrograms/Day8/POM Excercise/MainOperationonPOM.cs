using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCsharpTraining.SeleniumPrograms.Day8
{
    internal class MainOperationonPOM :DriverHelper
    {
        public static void Main(string[] args)
        {

            Driver =new ChromeDriver();
            Driver.Url = "https://5elementslearning.dev/demosite/";
            Thread.Sleep(1000);


            DemoHomePage demoHomePage = new DemoHomePage();
            LoginPOM loginPOM = new LoginPOM();
            LogoutPOM logoutPOM = new LogoutPOM();

            demoHomePage.ClickMyaccount();
            loginPOM.entercredentials("sam123@gmail.com", "user123");
            loginPOM.clickLogin();
            logoutPOM.logoffbtn();
            logoutPOM.contbtn();
            demoHomePage.closebrws();
        }
    }
}
