@Scenarios
Feature: e-Commerce website Test

To be able to login and use the coupon for shopping, also to be able to check if 
the order number is carried to the account page.

Background:
	Given I am logged in


@TC1
Scenario Outline: Applying Coupon
	When I have a product in the cart
	And I click on the cart menu item
	And I enter the coupon '<discountcode>'
	Then I can check coupon is '<discountpercent>'% off
Examples: 
 | ExampleDescription | discountcode | discountpercent |
 | Correct_discount   | edgewords    | 15              |

@TC2
Scenario Outline: After placing an order, I want to check if the order is in the Orders List
	When I view the cart to see the added item
	And I proceed to checkout to fill in the following information
	| First Name   | Last Name   | Street Address   | Town   | Postcode   | Phone   | Email   |
	| <First_Name> | <Last_Name> | <Street_Address> | <Town> | <Postcode> | <Phone> | <Email> |
	And I complete the order to get the order number
	Then I click on MyOrders to check the order number
Examples: 
 | ExampleDescription | First_Name | Last_Name | Street_Address | Town      | Postcode | Phone      | Email                       |
 | User_1             | Matt       | Rikcetts  | 22 Jump Street | Oxford    | SE21 2AB | 0124573976 | ryetike3@gmail.com          |
 | User_2             | Kai        | Havertz   | 29 Jump Street | Cambridge | CD25 2SF | 0176452392 | acw_data_traveler@gmail.com |
