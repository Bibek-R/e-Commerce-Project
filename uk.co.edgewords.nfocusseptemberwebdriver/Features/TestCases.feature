@Scenarios
Feature: Feature1

A short summary of the feature

Background:
	Given I am logged in


@TC1
Scenario: Applying Coupon
	When I have a product in the cart
	And I click on the cart menu item
	And I enter the coupon
	Then I can check coupon is 15% off

@TC2
Scenario: Check if order #3406 is shown in the Account Page
	When I am in the MyAccount page     
	And I click the 'Orders' menu item
	Then I should be able to see the order
