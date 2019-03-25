Feature: APIApplication
	

@mytag
Scenario: Get API response using given endpoint
	Given I have a endpoint /endpoint/
	When I call get method of  api
	Then the get API response in JSON format
	
Scenario: New User registration through post Call
	Given I have a endpoint /posts/
	When I call a post method to register a user
	Then i will registred sucessfully 
	