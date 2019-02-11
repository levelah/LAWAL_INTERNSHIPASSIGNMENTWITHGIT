Feature: Registration
	In order to Login to Giftrete website
	I need to register as a user to have access

@mytag
Scenario: Valid registration
	Given I open the Giftrete website
	And I click on register
	And I input firstname
	And I input lastname
	And I enter email "email address"
	And I enter mobile number
	And I enter password
	And I enter confirm password
	When I click on signup
	Then I should be registered
