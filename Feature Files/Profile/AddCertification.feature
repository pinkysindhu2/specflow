Feature: AddCertification
In order to update my profile 
	As a skill trader
	I want to add my Certifications that I have 

Background: Click on Cetrificate tab
	Given I clicked on the Certification tab under Profile page

@Project Mars

Scenario: Check if user could able to add a Certification 	
	When I add a new certification
	Then that certification should be successfully displayed on my listings

Scenario: Check if user could see changes after logout and comeback again
	And my certfication has been added successfully

Scenario: Check if user could reset a Certification
	When I add a new Certification
	And I click on cancel button
	Then that form should successfully reset and hide

Scenario: Check if user did not add a Certification
	When I add a new certification without data
	Then Error message should be displayed to ask to enter the data

Scenario: Check if user add a Certification with invalid data
	When I add a new certification with invalid data
	Then that certification should not be displayed on my listings