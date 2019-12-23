using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace Project_Mars.Hookups
{
    [Binding]
    public class SkillSearchSteps
    {
        
        [Given(@"Enter Cypress into Search bar on Home page")]
        public void GivenEnterCypressIntoSearchBarOnHomePage()
        {
            Pages.Skill_Search.SkillSearch.typeIntoSearchBar(Helpers.CommonDriver.driver);
        }
        
        [Given(@"I should successfully seen seller’s profile pic and name")]
        public void GivenIShouldSuccessfullySeenSellerSProfilePicAndName()
        {
            Pages.Skill_Search.SkillSearch.sellerInfoOnCard(Helpers.CommonDriver.driver);
        }
        
        [Given(@"I have clicked on the one of the Listed Services")]
        public void GivenIHaveClickedOnTheOneOfTheListedServices()
        {
            Pages.Skill_Search.SkillSearch.clickOnListedService(Helpers.CommonDriver.driver);
        }
        
        [Given(@"Seller’s profile info is on right hand side of Service Listing Page")]
        public void GivenSellerSProfileInfoIsOnRightHandSideOfServiceListingPage()
        {
            Pages.Skill_Search.SkillSearch.isSellerInfoOnServiceListingPg(Helpers.CommonDriver.driver);
        }
        
        [When(@"I have clicked on Search button")]
        public void WhenIHaveClickedOnSearchButton()
        {
            Pages.Skill_Search.SkillSearch.clickOnSearchIcon(Helpers.CommonDriver.driver);
        }
        
        [When(@"I have clicked on either of seller’s pic or name")]
        public void WhenIHaveClickedOnEitherOfSellerSPicOrName()
        {
            Pages.Skill_Search.SkillSearch.clickOnSellerInfoOnRsltPg(Helpers.CommonDriver.driver);
        }
        
        [When(@"I have clicked on Seller's profile")]
        public void WhenIHaveClickedOnSellerSProfile()
        {
            Pages.Skill_Search.SkillSearch.clickOnSellerOnServiceListingPg(Helpers.CommonDriver.driver);
        }
        
        [Then(@"I should see services regarding my search")]
        public void ThenIShouldSeeServicesRegardingMySearch()
        {
            Pages.Skill_Search.SkillSearch.searchSuccess(Helpers.CommonDriver.driver);
        }
        
        [Then(@"I should successfully see Seller’s profile in more detailed way")]
        public void ThenIShouldSuccessfullySeeSellerSProfileInMoreDetailedWay()
        {
            Pages.Skill_Search.SkillSearch.detailedSellerInfo(Helpers.CommonDriver.driver);
        }
        
    }
}
