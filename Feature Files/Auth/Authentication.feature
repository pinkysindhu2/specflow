Feature: Authentication
In order to utilise Project Mars 
	as a user or trader
	I should need to signup and signin

Background: Naviagate to Project Mars
	Given I have navigated to Project Mars portal

@Project Mars

Scenario: Sign Up
	Given I have clicked on Join button
	And I have entered the valid firstname, lastname, email and password.
	When I have clicked on Join Button
	Then I should successfully Signup.

Scenario: Login
	Given I have clicked on Signup 
	And I have entered valid email and password
	When I have clicked on login button
	Then I should successfully logged into the Project Mars

Scenario: Logout
	Given I am logged into Project Mars 
	When I clicked on Signout
	Then I should successfully logged out from the Project Mars Dashboard