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
    public class LoginPageTest//automate the login page of demo actitime
    {
        IWebDriver driver;
        ExcelUtility excelUtility = new ExcelUtility();//creating object for excelutility

        [TestMethod]
        public void TestMethod1()//test method to automate login page
        {
            
            string url = excelUtility.FetchSingleDataExcel("Sheet1", 0, 1);//getting data of url from excel
            string userName= excelUtility.FetchSingleDataExcel("Sheet1", 1, 1);//getting data of username from excel
            string password= excelUtility.FetchSingleDataExcel("Sheet1", 2, 1);//getting data of password from excel
            LoginPage loginPage = new LoginPage(driver);//creating object for loginPage pom class
            string acTitle =loginPage.Login(userName, password,driver);//executing business logic from loginpage
            string eTitle = "actiTIME - Enter Time-Track";
            Console.WriteLine("From login page test"+driver.Title);
            Assert.AreEqual(acTitle, eTitle);//validating whether we have logged in successfully
        }
        [TestInitialize]
        public void Init()//test iinitializer used to launch the browser and open to url
        {

            driver = new ChromeDriver();
            string url=excelUtility.FetchSingleDataExcel("Sheet1", 0, 1);
            driver.Navigate().GoToUrl(url);

        }
        [TestCleanup]
        public void Cleanup() //method is used to close the browser
        {
            driver.Close();
        
        }
    }
}
