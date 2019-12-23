Feature: AddSkill
In order to update my profile 
	As a skill trader 
	I want to add the skills that I have

Background: Click on the Skill tab
	Given I clicked on the Skill tab under Profile page

@Project Mars

Scenario: Check if user could able to add a Skill 
	When I add a new skill 
	Then that skill should be displayed on my listings

Scenario: Check if user could reset a Skill
	When I add a new skill
	And I click on cancel button
	Then that form should successfully reset and hide

Scenario: Check if user did not add a skill
	When I add a new skill without data
	Then Error message should be displayed to ask to enter the data

Scenario: Check if user add a Skill with invalid data
	When I add a new skill with invalid data
	Then that skill should not be displayed on my listings