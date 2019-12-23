using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace Project_Mars.Base_Class
{   
    class Browser
    {
        // Get the Chrome Browser
        private static IWebDriver GetChromeWebDriver()
        {
            IWebDriver driver = new ChromeDriver();
            return driver;
        }

        
        public void InitWebDriver()
        {
            Helpers.CommonDriver.driver = GetChromeWebDriver();
        }

        //Should Quit the Driver 
        
        public static void QuitDriver()
        {
            Helpers.CommonDriver.driver.Quit();
        }
    }
}
