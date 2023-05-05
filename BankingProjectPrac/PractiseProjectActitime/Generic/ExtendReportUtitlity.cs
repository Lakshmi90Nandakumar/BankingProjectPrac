using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace BankingProjectPrac.PractiseProjectActitime.Generic
{
    [TestClass]
    public class ExtendReportUtitlity:BaseClass
    {
        [TestInitialize]
        public void TestInitialize()
        {
                      
            driver = new ChromeDriver();
        }
        [TestMethod]
        [TestCategory("ExtentHtmlReport")]
        public void ActiTime()
        {
            extentTest = extentReports.CreateTest("ActiTime");

            driver.Url = "http://localhost:8888/";

            ITakesScreenshot takesScreenshot = (ITakesScreenshot)driver;
            var screenShot=takesScreenshot.GetScreenshot();
            screenShotPath = "C:\\Users\\LENOVO\\source\\repos\\BankingProjectPrac\\BankingProjectPrac\\PractiseProjectActitime\\Generic\\ScreenShot\\ActiTime.png";
            screenShot.SaveAsFile(screenShotPath, ScreenshotImageFormat.Png);
            extentTest.Log(Status.Info, "Taken screenshot for actitime");
            bool condition = false;
            if(condition==true)
            {
                Assert.IsTrue(true);
                extentTest.Pass("Test Passed");
            }
            else
            {
                try
                {
                    Assert.IsTrue(false);

                }
                catch(Exception ex) 
                {
                    extentTest.Fail("Test failed");
                     
                
                }
            }
            
        }
        [TestCleanup]
        public void Cleanup()
        {
            driver.Close();
            driver.Dispose();
            extentTest.AddScreenCaptureFromPath(screenShotPath);
        }
    }
}
