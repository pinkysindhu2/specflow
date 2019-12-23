using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Project_Mars
{
    [Binding]
    public class AddLanguageSteps
    {

        [Given(@"I clicked on the Language tab under Profile page")]
        public void GivenIClickedOnTheLanguageTabUnderProfilePage()
        {
            // Login 
            Pages.Home.NavigateToPortal(Helpers.CommonDriver.driver);
            Pages.Home.clickOnLogin(Helpers.CommonDriver.driver);

            Pages.Login.enterLoginInfo(Helpers.CommonDriver.driver);
            Pages.Login.clickOnLoginBtn(Helpers.CommonDriver.driver);
            Pages.Login.loginSuccess(Helpers.CommonDriver.driver);

            // Click on Language tab
            Pages.Profile_Tab.Language.clickOnLangTab(Helpers.CommonDriver.driver);


        }

        [When(@"I add a new language")]
        public void WhenIAddANewLanguage()
        {
            Pages.Profile_Tab.Language.addNewLang(Helpers.CommonDriver.driver);
        }

        [When(@"I add a new language without data")]
        public void WhenIAddANewLanguageWithoutData()
        {
            
        }
        
        [When(@"I add a new language with invalid data")]
        public void WhenIAddANewLanguageWithInvalidData()
        {
            
        }
        
        [Then(@"that language should be displayed on my listings")]
        public void ThenThatLanguageShouldBeDisplayedOnMyListings()
        {
            Pages.Profile_Tab.Language.langSuccess(Helpers.CommonDriver.driver);
            Helpers.CommonDriver.driver.Quit();
        }
        
        [Then(@"Error message should be displayed to ask to enter the data")]
        public void ThenErrorMessageShouldBeDisplayedToAskToEnterTheData()
        {
            
        }
        
        [Then(@"that language should not be displayed on my listings")]
        public void ThenThatLanguageShouldNotBeDisplayedOnMyListings()
        {
            
        }
    }
}
