using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BankingProjectPrac.PractiseProjectActitime.Generic
{
    [TestClass]
    public class BaseClass
    {
        public IWebDriver driver;
        public static ExtentReports extentReports;
        public string screenShotPath;
        public ExtentTest extentTest;
        public static ExtentHtmlReporter htmlReporter;
        public static string testResultPath = "C:\\Users\\LENOVO\\source\\repos\\BankingProjectPrac\\BankingProjectPrac\\PractiseProjectActitime\\Generic\\Report\\";

        [AssemblyInitialize]
        public static void AssemblyInitialize(TestContext testContext) 
        {
            extentReports = new ExtentReports();
            htmlReporter = new ExtentHtmlReporter(testResultPath);
            htmlReporter.Start();
            extentReports.AttachReporter(htmlReporter);
            Console.WriteLine("Assembly Initialized");

        
        }
        [AssemblyCleanup]
        public static void AssemblyCleanup() 
        {
            Console.WriteLine("Assembly clean up");
            extentReports.Flush();
            htmlReporter.Stop();
            
        }
    }
}
