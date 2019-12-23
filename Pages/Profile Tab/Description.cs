﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Threading;

namespace Project_Mars.Pages.Profile_Tab
{
    class Description
    {
        public static void clickOnDescription(IWebDriver driver)
        {
            Thread.Sleep(3000);
            string id = "account-profile-section";
            IWebElement description = driver.FindElement(By.XPath("//div[@id='"+id+"']/div/section[2]" +
            "/div/div/div/div[3]/div/div/div/h3/span"));
            description.Click();
            IWebElement textarea = driver.FindElement(By.TagName("textarea"));

            // Access the SellerData.xlxs file
            Helpers.ExcelReaderHelper.PopulateInCollection("C:/Users/Pinky Sindhu/Desktop/Industry Connect/Industry Connect" +
                "/Internship/Project Mars/Test Data/SellerData.xlsx", "Description");
            
            textarea.Clear();
            textarea.SendKeys(Helpers.ExcelReaderHelper.ReadData(2, "A short Description"));
        }

        public static void saveDescription(IWebDriver driver)
        {
            IWebElement save = driver.FindElement(By.XPath("//button[@class=\"ui teal button\" and @type=\"button\"]"));
            save.Click();
        }

        public static void savedSuccess(IWebDriver driver)
        {
            Thread.Sleep(4000);
            IWebElement shtDescription = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]" +
                "/div/section[2]/div/div/div/div[3]/div/div/div/span"));
            Assert.That(Helpers.ExcelReaderHelper.ReadData(2, "A short Description"),Is.EqualTo(shtDescription.Text));
            driver.Close();
        }
    }
}
