Feature: Withdrawal from Account
	In order to play and get winnings
	As a playeraccount_id
	I want to withdraw funds from my account

@withdrawing
Scenario Outline: Customer successfully withdraws money 
	Given An account <balance>
	When I withdraw <cash> and the withdrawall is successful
	Then I get <new_balance> of the account
	Examples: 
	| balance | cash  | new_balance |
	| 100     | 20    | 80          |
	| 100     | 100   | 0           |

@withdrawing
Scenario Outline: Customer fails to withdraw money 
	Given An account <balance>
	When I withdraw <cash> and the withdrawall is unsuccessful
	Then I get <information> on the reason
	Examples: 
	| balance  | cash     | information		 |
	| 10       | 20       | Not enough funds |
	| 0	       | 30       | Not enough funds |
	| -10      | 30       | Not enough funds |
