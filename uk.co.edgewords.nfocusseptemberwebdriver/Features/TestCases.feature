@Scenarios
Feature: Feature1

A short summary of the feature


Scenario: Correct Login Credentials
	Given I am on the login page
	When I login with 'ryetike3' and 'nFocusAug22'
	Then I am logged in

@TC1
Scenario Outline: Applying Coupon	
	Given I have a product in the cart	
	When I click on the cart menu item
	And I enter the coupon
	Then I can enter the coupon code

@TC2
Scenario Outline: Look if order is placed
         Given I am logged in
		 When I select the 'Orders' menu item
		 Then I should be able to see the orders
