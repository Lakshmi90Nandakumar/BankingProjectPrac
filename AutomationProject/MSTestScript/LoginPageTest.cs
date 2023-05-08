using AutomationProject.Generic;
using AutomationProject.ObjectRepository;
using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationProject.MSTestScript
{
    [TestClass]
    public class LoginPageTest:BaseClas
    {
        WebDriverUtility webDriverUtility = new WebDriverUtility();

        [TestInitialize]
        public void Init() 
        {
            driver = new ChromeDriver();
            driver.Url = "http://localhost:8888/";
            webDriverUtility.Maximize(driver);
            webDriverUtility.ImplicitWait(driver);
        
        }
        [TestMethod]
        [TestCategory("LoginTestVTiger")]
        public void LoginTest()
        {
            string screenShotName = testContext.TestName;
            LoginPge loginPge= new LoginPge(driver);
            loginPge.Login();
            string eTitle = " Administrator - Home - vtiger";
            string title = driver.Title;
            try
            {

                Assert.IsTrue(title.Contains(eTitle));
                extentTest.Log(Status.Pass, "Title Matched");
            }
            catch(Exception ex) 
            {

                webDriverUtility.TakeScreenShot(driver, screenShotName);
                extentTest.AddScreenCaptureFromPath(ScreenShotPath);
                extentTest.Log(Status.Fail, "Title Not Matched");
            }
        }
        public TestContext testContext { get; set; }
    }
}
