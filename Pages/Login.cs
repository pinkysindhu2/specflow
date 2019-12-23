﻿using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Project_Mars.Pages
{
    class Login : Home
    {  
        
        public static void enterLoginInfo(IWebDriver driver)
        {
            // find the email field
            IWebElement email = driver.FindElement(By.Name("email"));
            email.SendKeys("sd@gmail.com");

            //find the password field
            IWebElement password = driver.FindElement(By.Name("password"));
            password.SendKeys("abcd123");
        }

        public static void clickOnLoginBtn(IWebDriver driver)
        {
            IWebElement login = driver.FindElement(By.XPath("//button[@class=\"fluid ui teal button\"]"));
            login.Click();
        }

        public static void loginSuccess(IWebDriver driver)
        {
            Thread.Sleep(3000);
            string url = driver.Url;
            Assert.AreEqual(url, "http://www.skillswap.pro/Account/Profile");
            
        }
    }
}
