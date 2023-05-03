using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace BankingProjectPrac.Practise
{
    [TestClass]//define class as test class
    public class DataDrivenTestingEx
    {


        [DataTestMethod]//used to define method using multiple data to test 
                        //providing data to test the test method 
        [DataRow("https://www.google.co.in/", "Google")]
        [DataRow("https://www.facebook.com/", "Facebook – log in or sign up")]
        [DataRow("https://www.amazon.in/", "Amazon.in : -amazon")]

        [TestMethod]//used to define method as test method
        [TestCategory("DataDrivenTest")]//used to categorize method
        [Priority(1)]
        public void DataDrivenTest(string url, string exptitle)
        {
            Console.WriteLine("URL is: " + url + "  Expected Title is:  " + exptitle);
            IWebDriver driver = new ChromeDriver();//lauch the browser
            driver.Navigate().GoToUrl(url);//entering the url throught test data
            String acTitle = driver.Title;//getting title of the web page
            try
            {
                Assert.Equals(acTitle, exptitle);//vaidating the data
            }
            catch (Exception ex)
            {
                Console.WriteLine("Title is not matched ");
                Console.WriteLine(ex.StackTrace);

            }
            finally
            {
                Assert.IsTrue(acTitle.Equals(exptitle));
            }



        }
        [TestInitialize]
        public void Initialize()
        {
            Console.WriteLine("Before Test method");
            //MessageBox.Show("Test started");

        }
        [TestCleanup]
        public void CleanUp()
        {
            Console.WriteLine("Test Method Executed");
        }
    }
}
