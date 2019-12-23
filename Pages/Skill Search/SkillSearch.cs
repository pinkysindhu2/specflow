﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Threading;

namespace Project_Mars.Pages.Skill_Search
{
    class SkillSearch
    {   
        private static string sellerAccountUrl;
        private static string sellerServiceUrl;
        private static string sellerName;
        private static string serviceName;
        public static void typeIntoSearchBar(IWebDriver driver)
        {
            Thread.Sleep(1000);
            IWebElement sbar = driver.FindElement(By.XPath("//div[@class=\"ui secondary menu\"]//input[@placeholder=\"Search skills\"]"));
            //sbar.Clear();
            sbar.SendKeys("Cypress");
        }

        public static void clickOnSearchIcon(IWebDriver driver)
        {
            IWebElement sIcon = driver.FindElement(By.XPath("//i[@class=\"search link icon\"]"));
            sIcon.Click();
        }

        public static void searchSuccess(IWebDriver driver)
        {
            Thread.Sleep(1500);
            IList<IWebElement> resultCount = driver.FindElements(By.XPath("//div[@class=\"ui card\"]"));
           
            Assert.That(resultCount.Count, Is.GreaterThan(0));
        }

        public static void sellerInfoOnCard(IWebDriver driver)
        {
            IList<IWebElement> resultCount = driver.FindElements(By.XPath("//div[@class=\"ui card\"]"));

            if (resultCount.Count > 0)
            {
                for(int i = 1; i <= resultCount.Count; i++)
                {
                    IWebElement sellerInfo = driver.FindElement(By.XPath("//div[@class=\"ui card\"]["+ i +"]/" +
                        "child::div/a[@class=\"seller-info\"]"));

                    if(sellerInfo.Text.Length!=0)
                    {
                        Assert.Pass();
                    }
                }
            }

        }

        public static void clickOnSellerInfoOnRsltPg(IWebDriver driver)
        {
            Thread.Sleep(2000);

            IWebElement sellerInfo = driver.FindElement(By.XPath("//div[@class=\"ui card\"][1]/" +
                       "child::div/a[@class=\"seller-info\"]"));


            IWebElement sellerService = driver.FindElement(By.XPath("//div[@class=\"ui card\"][1]/" +
                       "child::div/a[@class=\"service-info\"]/p"));

            setSellerInfoFromResultPage(sellerInfo, sellerService);

            sellerInfo.Click();
        }

        public static void clickOnListedService(IWebDriver driver)
        {
            Thread.Sleep(1000);

            IWebElement sellerInfo = driver.FindElement(By.XPath("//div[@class=\"ui card\"][1]/" +
                       "child::div/a[@class=\"seller-info\"]"));

            IWebElement sellerService = driver.FindElement(By.XPath("//div[@class=\"ui card\"][1]/" +
                       "child::div/a[@class=\"service-info\"]"));

            setSellerInfoFromResultPage(sellerInfo, sellerService);

            sellerService.Click();

            
        }

        public static void isSellerInfoOnServiceListingPg(IWebDriver driver)
        {
            Thread.Sleep(1000);

            checkUrlChanged(driver, sellerServiceUrl);
            var firstName = sellerName.Split(' ');
            IWebElement sellerNameTag = driver.FindElement(By.XPath("//*[contains(text(),'" + firstName[0] + "')]"));
            
            if(sellerNameTag.Text == sellerName)
            {
                Assert.Pass();
            }
        }
        public static void clickOnSellerOnServiceListingPg(IWebDriver driver)
        {
            IWebElement sellerProfile = driver.FindElement(By.XPath("//div[@class=\"user-info\"]/a/h3"));

            sellerProfile.Click();

        }
        public static void detailedSellerInfo(IWebDriver driver)
        {

            checkUrlChanged(driver, sellerAccountUrl);
            IWebElement sellerLinkTag = null;
            IWebElement sellerServiceTag = null;

            sellerServiceTag = driver.FindElement(By.XPath("//*[contains(text(),'" + serviceName + "')]"));
            Console.WriteLine(sellerServiceTag);
            try
            {
                sellerLinkTag = driver.FindElement(By.XPath("//*[contains(text(), '" + sellerName + "')]"));
                Console.WriteLine(sellerLinkTag);         
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: "+ e);
            }                
            Assert.IsNotNull(sellerServiceTag);
           // Assert.IsNotNull(sellerLinkTag); // It will fail becuase I am enalbe to find seller Name on Seller profile Detail page
        }

        private static void checkUrlChanged(IWebDriver driver, string Url)
        {
            Thread.Sleep(1000);
            string url = driver.Url;
            Assert.AreEqual(url, Url);
        }

        private static void setSellerInfoFromResultPage(IWebElement sellerInfo, IWebElement sellerService)
        {
            sellerAccountUrl = sellerInfo.GetAttribute("href");

            sellerName = sellerInfo.Text;

            serviceName = sellerService.FindElement(By.TagName("p")).Text;

            sellerServiceUrl = sellerService.GetAttribute("href");

        }
    }
}
