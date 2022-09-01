Feature: SwagLabs

A short summary of the feature

@tag1
Scenario: Successful Login with Valid Credentials on swag labs
	Given User is at the swag labs Page
	When User enters the <testusername> and <testPassword>
	When Click on the Login button
	Then Successful LogIN is there
	When User Logs Out from the Application
	Then Successful Logout page
Examples: 
| testusername    | testPassword |
| standard_user   | secret_sauce |
| standard_use2   | secret_sauce |
| locked_out_user | secret_sauce |

