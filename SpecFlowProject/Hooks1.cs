using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium.Chrome;


namespace SpecFlowProject
{
    [Binding]
    public sealed class Hooks : DriverHelper
    {
        private static ExtentTest featureName;
        private static ExtentTest scenario;
        private static ExtentReports extent;
        public static string ReportPath;
        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            //Page.Initialize();
            //string path1 = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "");


            string path = @"D:\\VS Studio Files\\Selenium Testing\\Report\\index10.html";
            var htmlReporter = new ExtentHtmlReporter(path);
            htmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
            extent = new AventStack.ExtentReports.ExtentReports();
            extent.AttachReporter(htmlReporter);
            Driver = new ChromeDriver();

        }
        [BeforeFeature]
        public static void BeforeFeature()
        {
            //Create dynamic feature name
            featureName = extent.CreateTest<Feature>(FeatureContext.Current.FeatureInfo.Title);
            Console.WriteLine("BeforeFeature");
        }
        [BeforeScenario]
        public void BeforeScenario()
        {
            Console.WriteLine("BeforeScenario");
            scenario = featureName.CreateNode<Scenario>(ScenarioContext.Current.ScenarioInfo.Title);

        }
        [AfterStep]
        public void InsertReportingSteps()
        {
            var stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();
            if (ScenarioContext.Current.TestError == null)
            {
                if (stepType == "Given")
                {
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);
                    string path = DriverHelper.TakeScreenshot();
                    scenario.AddScreenCaptureFromPath(path);
                    
                }
                else if (stepType == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "Then")
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "And")
                    scenario.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text);
            }
            else if (ScenarioContext.Current.TestError != null)
            {
                if (stepType == "Given")
                {
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
                    //Call method will return a path as string.
                   /* string path = DriverHelper.TakeScreenshot();
                    scenario.AddScreenCaptureFromPath(path);*/

                }
                else if (stepType == "When")
                {
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
                }
                else if (stepType == "Then")
                {
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
                }
                else if (stepType == "And")
                {
                    scenario.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
                }
            }
        }
        [AfterScenario]
        public void AfterScenario()
        {
            Console.WriteLine("AfterScenario");
            //implement logic that has to run after executing each scenario
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            Driver.Close();
            Driver.Dispose();
            //kill the browser
            //Flush report once test completes
            extent.Flush();
            //kill the browser
        }



    }
}


