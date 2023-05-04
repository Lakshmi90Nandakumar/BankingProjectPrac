using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProjectPrac.PractiseProjectActitime.Generic
{
    public class WebDriverUtility
    {
        IWebDriver driver;
        public void WindowMaximize(IWebDriver driver)//method to maximize the window
        {
            driver.Manage().Window.Maximize();
        }
        public void Wait(IWebDriver driver) //generic method for implicit wait
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }
        public void ExplicitWait(IWebDriver driver) //generic method for explicit wait for title contains
        {
            WebDriverWait wait = new WebDriverWait(driver,TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.TitleContains("Enter Time-Track"));
        
        }
    }
}
