using OpenQA.Selenium;
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
        public void WindowMaximize(IWebDriver driver)
        {
            driver.Manage().Window.Maximize();
        }
        public void Wait(IWebDriver driver) 
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }
    }
}
