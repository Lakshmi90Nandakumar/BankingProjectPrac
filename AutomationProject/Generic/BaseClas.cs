using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationProject.Generic
{
    [TestClass]
    public class BaseClas
    {
        public static ExtentReports extentReports;
        public static ExtentHtmlReporter htmlReporter;
        public static string htmlReportPath="C://Users//LENOVO//source//repos//BankingProjectPrac//AutomationProject//Generic//Reports//";
        public ExtentTest extentTest;
        public string ScreenShotPath;
        public IWebDriver driver;

        [AssemblyInitialize]
        public static void AssemblyIntitial(TestContext context)
        {
            extentReports=new ExtentReports();
            htmlReporter = new ExtentHtmlReporter(htmlReportPath);
            htmlReporter.Start();
            extentReports.AttachReporter(htmlReporter);
            Console.WriteLine("Assembly started");
        }
        [AssemblyCleanup]
        public static void AssemblyCleanup(TestContext context) 
        {
            extentReports.Flush();
            htmlReporter.Stop();
            Console.WriteLine("Assembly clean up done");
        
        }

    }
}
