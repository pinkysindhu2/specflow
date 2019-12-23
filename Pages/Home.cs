using OpenQA.Selenium;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_Mars.Helpers;
using Project_Mars.Base_Class;

namespace Project_Mars.Pages
{
    class Home: Browser
    {   
        //
        
        public static void NavigateToPortal(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("http://www.skillswap.pro/");           
        }

        
        public static void AfterEveryTest()
        {   
            //CommonDriver.Quit();
        }

        public static void clickOnLogin(IWebDriver driver)
        {
            IWebElement webElement = driver.FindElement(By.XPath("//a[@class=\"item\"]"));
            webElement.Click();
        }
    }
}
