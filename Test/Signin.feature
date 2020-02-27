Feature: Sign-in
	In order to Sign-in
	As a user
	I want to add my details successfully

@AmazonSignin
Scenario: Sign-In Amazon
	Given I navigate to Amazon
	When I Click SignIn with valid username and password
	Then I Sign-In successfully
