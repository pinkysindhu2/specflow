using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;

namespace Project_Mars.Pages.Profile_Tab
{
    class Language
    {
        public static void clickOnLangTab(IWebDriver driver)
        {
            Thread.Sleep(1000);
            IWebElement lang = driver.FindElement(By.XPath("//a[@data-tab=\"first\"]"));
            lang.Click();
        }

        public static void addNewLang(IWebDriver driver)
        {
            Thread.Sleep(2000);
            // click on add new button
            IWebElement addNew = driver.FindElement(By.XPath("//div[@data-tab=\"first\"]//table/thead/tr/th[3]/div"));
            addNew.Click();

            // Access the SellerData.xlxs file
            Helpers.ExcelReaderHelper.PopulateInCollection("C:/Users/Pinky Sindhu/Desktop/Industry Connect/Industry Connect" +
                "/Internship/Project Mars/Test Data/SellerData.xlsx", "Language");
            
            // Send a Language and level to add
            IWebElement lang = driver.FindElement(By.XPath("//input[@name=\"name\"]"));
            lang.SendKeys(Helpers.ExcelReaderHelper.ReadData(2,"Language"));

            // Select from drop down list
            selectLangLevel(driver);

            //click on Add button to Save the lanaguage
            IWebElement add = driver.FindElement(By.XPath("//input[@value=\"Add\"]"));
            add.Click();
        }

        // Select from drop down list
        private static void selectLangLevel(IWebDriver driver)
        {
            Thread.Sleep(1000);
            IWebElement level = driver.FindElement(By.TagName("select"));
            var selectLevel = new SelectElement(level); 
            selectLevel.SelectByText(Helpers.ExcelReaderHelper.ReadData(2,"Level"));
                
        }

        private static void clickOnAdd(IWebDriver driver)
        {
            IWebElement addLang = driver.FindElement(By.XPath("//input[@value=\"Add\"]"));
            addLang.Click();
        }

        public static void langSuccess(IWebDriver driver)
        {
            Thread.Sleep(3000);
        
            for (int i = 1; i <= 4; i++)
            {
                var lang = driver.FindElement(By.XPath("//div[@data-tab=\"first\"]//table/tbody/tr[" + i + "]/td[1]"));
                var level = driver.FindElement(By.XPath("//div[@data-tab=\"first\"]//table/tbody/tr[" + i + "]/td[2]"));

                if (lang.Text == "C#" && level.Text == "Basic")
                {
                    Assert.Pass();
                    Console.WriteLine("Test Success");
                }
            }
          

        }
    }
}
