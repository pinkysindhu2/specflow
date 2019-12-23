using OpenQA.Selenium;
using Project_Mars.Helpers;
using System;
using TechTalk.SpecFlow;

namespace Project_Mars.Hookups
{
    [Binding]
    public class AddDescriptionSteps
    {
       
        [Given(@"I am logged into the Project Mars")]
        public void GivenIAmLoggedIntoTheProjectMars()
        {
            Pages.Home.NavigateToPortal(Helpers.CommonDriver.driver);
            Pages.Home.clickOnLogin(Helpers.CommonDriver.driver);

            Pages.Login.enterLoginInfo(Helpers.CommonDriver.driver);
            Pages.Login.clickOnLoginBtn(Helpers.CommonDriver.driver);
            Pages.Login.loginSuccess(Helpers.CommonDriver.driver);

        }

        [Given(@"I clicked on the Description tab under Profile page")]
        public void GivenIClickedOnTheDescriptionTabUnderProfilePage()
        {
            Pages.Profile_Tab.Description.clickOnDescription(Helpers.CommonDriver.driver);
        }
        
        [When(@"I save a short summary")]
        public void WhenISaveAShortSummary()
        {
            Pages.Profile_Tab.Description.saveDescription(Helpers.CommonDriver.driver);
        }
        

        [When(@"I click on cancel button")]
        public void WhenIClickOnCancelButton()
        {
            
        }
        
        [When(@"I save without a short description")]
        public void WhenISaveWithoutAShortDescription()
        {
            
        }
        
        [When(@"I save a very long description")]
        public void WhenISaveAVeryLongDescription()
        {
            
        }
        
        [When(@"I save a edited description")]
        public void WhenISaveAEditedDescription()
        {
            
        }
        
        [Then(@"that short summary should be displayed on my listings")]
        public void ThenThatShortSummaryShouldBeDisplayedOnMyListings()
        {
            Pages.Profile_Tab.Description.savedSuccess(Helpers.CommonDriver.driver);
            Helpers.CommonDriver.driver.Quit();

        }
        
        [Then(@"that form should successfully reset and hide")]
        public void ThenThatFormShouldSuccessfullyResetAndHide()
        {
            
        }
        
        [Then(@"Error message should be displayed to ask to enter a description")]
        public void ThenErrorMessageShouldBeDisplayedToAskToEnterADescription()
        {
            
        }
        
        [Then(@"that long description should not be accepted")]
        public void ThenThatLongDescriptionShouldNotBeAccepted()
        {
            
        }
        
        [Then(@"that description should be successfully updated")]
        public void ThenThatDescriptionShouldBeSuccessfullyUpdated()
        {
            
        }
    }
}
