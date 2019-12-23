Feature: AddLanguage
In order to update my profile 
	As a skill trader 
	I want to add the languages that I know

Background: Click on the Language tab
	Given I clicked on the Language tab under Profile page

@Project Mars

Scenario: Check if user could able to add a Language 
	When I add a new language 
	Then that language should be displayed on my listings

Scenario: Check if user could reset a Language
	When I add a new language
	And I click on cancel button
	Then that form should successfully reset and hide

Scenario: Check if user did not add a Language
	When I add a new language without data
	Then Error message should be displayed to ask to enter the data

Scenario: Check if user add a Language with invalid data
	When I add a new language with invalid data
	Then that language should not be displayed on my listings