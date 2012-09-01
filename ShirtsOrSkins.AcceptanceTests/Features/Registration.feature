Feature: Registration
	In order to use the website
	As a unregistered user
	I want to be able to register on the site


Scenario: Navigate to Registration Page
	When I enter http://localhost:1539/Account/Register in the address bar
	Then I should be on the registration page

Scenario: Register New User
	Given I am on the registration page
	And I enter the following details into the registration form
	| Field           | Value                |
	| Usename         | Sean                 |
	| Email           | sean@taskfirst.co.uk |
	| Password        | password             |
	| ConfirmPassword | password             |
	And I press the register button
	Then I should registered
	And on the home page
	And logged in