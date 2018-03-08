Feature: Open Account
	In order customers can start playing on my site
	As a registration system
	I want to open accounts for them (new customers) so that they can start playing on my site

@account_opening
Scenario Outline: Customer successfully opens an account
	Given An account registration service 
	When I have entered a valid <username> and valid <password>
	Then I get an <account_id> back
	Examples: 
	| username | password | account_id |
	| test123  | test1234 | 99999999   |

@account_opening
Scenario Outline: Customer fails to open an account - empty username or password
	Given An account registration service 
	When I have entered an empty <username> or <password>
	Then I do not get an <account_id> back	
	Examples: 
	| username | password | account_id |
	| test123  |          |            |
	|          | test123  |            |

@account_opening
Scenario Outline: Customer fails to open an account - too long username or password
	Given An account registration service 
	When I have entered too long <username> or <password>
	Then I do not get an <account_id> back
	Examples:
	| username                           | password                           | account_id |
	| aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa | test                               |            |
	| test                               | aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa |            |

@account_opening
Scenario Outline: Customer fails to open an account - restricted characters in username
	Given An account registration service 
	When I have entered a <username> containing restricted characters
	Then I do not get an <account_id> back
	Examples:
	| username | account_id |
	| @sd!=1)  |			|
	| test$^   |			|