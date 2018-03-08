Feature: AccountDeposit
	In order to play games
	As a player
	I want to deposit money on my account

@deposit_money
Scenario Outline: Customer successfully deposits money
	Given An account <balance>
	When I deposit <cash> and the deposit is successful
	Then I get <new_balance> of the account
	Examples: 
	| balance | cash  | new_balance |
	| 0       | 20    | 20          |
	| 100     | 50    | 150         |

@deposit_money
Scenario Outline: Customer fails to deposit money 
	Given An account <balance>
	When I deposit <cash> and the deposit is unsuccessful
	Then I get <info> on the reason
	Examples: 
	| balance  | cash | info		     |
	| 10       | 20   | Not enough funds |
	| 0	       | 30   | Not enough funds |