using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject
{
    public class DriverHelper
    {
        public static IWebDriver Driver { get; set; }
        public static string GetRandomString()
        {
            string path = Path.GetRandomFileName();
            path = path.Replace(".", ""); // Remove period.
            return path;
        }
        public static string TakeScreenshot()
        {
            //DateTime current_date1 = DateTime.Now;
            //string custom = current_date1.ToString("dddd, dd MMMM yyyy HH:mm:ss");
            string path1 = @"D:/VS Studio Files/Selenium Testing/Report/";
            string path = path1 + "Screenshot/" + GetRandomString() + ".png";
            Screenshot screenshot = ((ITakesScreenshot)Driver).GetScreenshot();
            screenshot.SaveAsFile(path, ScreenshotImageFormat.Png);
            return path;
        }
    }
}
