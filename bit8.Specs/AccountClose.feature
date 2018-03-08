Feature: Close Account
	In order customer could not play on my site
	As a management system
	I want to close existing customer accounts so that the customer will not be able to play

	@account_closing
	Scenario Outline: Account fails to be closed when there is money on it
	Given A customer's account 
	When There is <money> on it	
	Then Closing is <unsuccessful> and I get informed of the <reason>
	Examples: 
	| money | unsuccessful | reason				|
	| 100	| true		   | Money on account   |
	
	@account_closing
	Scenario Outline: Closed account fails to be closed once again
	Given A customer's account 
	When It is already <closed>
	Then Closing is <unsuccessful> and I get informed of the <reason>
	Examples: 
	| closed  | unsuccessful | reason					|
	| true	  | true	     | Account already closed   |
	
	@account_closing
	Scenario Outline: Account successfully closed
	Given A customer's account 
	When It is not already <closed>
	And There is <money> on it
	Then Closing is <successful>
	Examples: 
	| closed  | money | successful |
	| open	  | 0	  | true	   |
