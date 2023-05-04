using BankingProjectPrac.PractiseProjectActitime.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProjectPrac.PractiseProjectActitime.ObjectRepo
{
    public class LoginPage
    {
        WebDriverUtility webDriverUtility = new WebDriverUtility();


        [FindsBy(How = How.Name, Using = "username")]
        private IWebElement userNameTxt { get; set; }

        [FindsBy(How=How.Name, Using = "pwd")]
        private IWebElement passwordTxt { get; set; }

        [FindsBy(How=How.Id,Using = "loginButton")]
        private IWebElement loginBtn { get; set; }

        public LoginPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver,this);
        }
        public string Login(string userName,string passWord,IWebDriver driver)
        {
            userNameTxt.SendKeys(userName);
            passwordTxt.SendKeys(passWord);
            loginBtn.Click();
            webDriverUtility.WindowMaximize(driver);
            webDriverUtility.Wait(driver);
            webDriverUtility.ExplicitWait(driver);
            string acTitle = driver.Title;
            Console.WriteLine("From login page after login:   "+driver.Title);
            return acTitle;

        }

    }
}
