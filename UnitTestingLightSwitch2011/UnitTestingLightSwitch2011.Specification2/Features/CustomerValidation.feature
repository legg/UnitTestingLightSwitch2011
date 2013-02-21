Feature: Customer Validation
	As a customer 
	I require validation for my existance
	So that I don't kill mysefl - AS

Scenario: Create customer with a valid name
	Given a name is 3 or more chars with no numbers
	When we go to create a customer
	Then customer is created