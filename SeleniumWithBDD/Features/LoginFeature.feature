Feature: LoginFeature

A short summary of the feature

@tag1
Scenario: logging into site
	Given I'm on a loging page
	When user enter valid username and password
	And user clicks on login
	Then login should be successful
