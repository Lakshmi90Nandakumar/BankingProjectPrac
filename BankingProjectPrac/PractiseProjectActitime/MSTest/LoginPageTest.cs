using BankingProjectPrac.PractiseProjectActitime.Generic;
using BankingProjectPrac.PractiseProjectActitime.ObjectRepo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Security.Policy;

namespace BankingProjectPrac.PractiseProjectActitime.MSTest
{
    [TestClass]
    public class LoginPageTest
    {
        IWebDriver driver;
        ExcelUtility excelUtility = new ExcelUtility();

        [TestMethod]
        public void TestMethod1()
        {
            
            string url = excelUtility.FetchSingleDataExcel("Sheet1", 0, 1);
            string userName= excelUtility.FetchSingleDataExcel("Sheet1", 1, 1);
            string password= excelUtility.FetchSingleDataExcel("Sheet1", 2, 1);
            LoginPage loginPage = new LoginPage(driver);
            string acTitle=loginPage.Login(userName, password,driver);
            string eTitle = "actiTIME - Login";
            Console.WriteLine(driver.Title);
            Assert.AreEqual(acTitle, eTitle);
        }
        [TestInitialize]
        public void Init()
        {

            driver = new ChromeDriver();
            string url=excelUtility.FetchSingleDataExcel("Sheet1", 0, 1);
            driver.Navigate().GoToUrl(url);

        }
        [TestCleanup]
        public void Cleanup() 
        {
            driver.Close();
        
        }
    }
}
