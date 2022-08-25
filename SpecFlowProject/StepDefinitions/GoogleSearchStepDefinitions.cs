using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SpecFlowProject.StepDefinitions
{
    [Binding]
    public class GoogleSearchStepDefinitions
    {
        public IWebDriver driver;

        [Given(@"Open the browser")]
        public void GivenOpenTheBrowser()
        {
            Console.WriteLine("Insisde Step: browser is open");
            driver = new ChromeDriver();

        }

        [Given(@"user is on google search page")]
        public void GivenUserIsOnGoogleSearchPage()
        {
            Console.WriteLine("Insisde Step: user in search page");
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.co.in/");
        }

        [When(@"user enters a text in search box")]
        public void WhenUserEntersATextInSearchBox()
        {
            Console.WriteLine("Insisde Step: user enters text in box");
            driver.FindElement(By.XPath("//input[@title='Search']")).SendKeys("Automation step by step");

        }

        [When(@"User clicks on search/hit enter")]
        public void WhenUserClicksOnSearchHitEnter()
        {
            Console.WriteLine("Insisde Step: user clicked on search/hit enter");
            driver.FindElement(By.XPath("//input[@title='Search']")).SendKeys(Keys.Enter);
        }

        [Then(@"user is navigated to search results")]
        public void ThenUserIsNavigatedToSearchResults()
        {
            Console.WriteLine("Insisde Step: Search reslts are visible");
            driver.PageSource.Contains("Online Courses");
            driver.Close();
            driver.Quit();
        }
    }
}
