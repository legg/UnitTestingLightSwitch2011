Feature: OrderValidation
	In order to create an order
	as a user
	we need a valid customer

Scenario: Create an order
	Given a valid customer
	And an available product
	And an order created from customer and product
	When the order is validated
	Then the order is valid
