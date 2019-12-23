using OpenQA.Selenium;
using Project_Mars.Helpers;
using Project_Mars.Pages;
using Project_Mars.Base_Class;
using System;
using TechTalk.SpecFlow;


namespace Project_Mars.Hookups
{
    [Binding]
    public class AuthenticationSteps
    {
     

        [Given(@"I have navigated to Project Mars portal")]
        public void GivenIHaveNavigatedToProjectMarsPortal()
        {
            Base_Class.Browser browser = new Browser();
            browser.InitWebDriver();
            Home.NavigateToPortal(Helpers.CommonDriver.driver);
        }
        
        [Given(@"I have clicked on Signup")]
        public void GivenIHaveClickedOnSignup()
        {
            Home.clickOnLogin(Helpers.CommonDriver.driver);
        }
        
        [Given(@"I have entered valid email and password")]
        public void GivenIHaveEnteredValidEmailAndPassword()
        {
            Login.enterLoginInfo(Helpers.CommonDriver.driver);
        }
        
        [Given(@"I am logged into Project Mars")]
        public void GivenIAmLoggedIntoProjectMars()
        {
            Base_Class.Browser browser = new Browser();
            browser.InitWebDriver();
            Pages.Home.NavigateToPortal(Helpers.CommonDriver.driver);
            Pages.Home.clickOnLogin(Helpers.CommonDriver.driver);

            Pages.Login.enterLoginInfo(Helpers.CommonDriver.driver);
            Pages.Login.clickOnLoginBtn(Helpers.CommonDriver.driver);
            Pages.Login.loginSuccess(Helpers.CommonDriver.driver);
        }
        
        [When(@"I have clicked on login button")]
        public void WhenIHaveClickedOnLoginButton()
        {
            Login.clickOnLoginBtn(Helpers.CommonDriver.driver);
        }
        
        [When(@"I clicked on Signout")]
        public void WhenIClickedOnSignout()
        {
            
        }
        
        [Then(@"I should successfully logged into the Project Mars")]
        public void ThenIShouldSuccessfullyLoggedIntoTheProjectMars()
        {
            
        }
        
        [Then(@"I should successfully logged out from the Project Mars Dashboard")]
        public void ThenIShouldSuccessfullyLoggedOutFromTheProjectMarsDashboard()
        {
            
        }
    }
}
