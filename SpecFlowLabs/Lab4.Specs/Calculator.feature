Feature: Calculator
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mydemotag
Scenario: Add two numbers
	Given I have entered 50 into the calculator
	And I have also entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen
	But the result should not be -20

Scenario Outline: Add numbers table
	Given I have entered <number1> into the calculator
	And I have also entered <number2> into the calculator
	When I press add
	Then the result should be <expectedResult> on the screen

	Examples: 
	| number1 | number2 | expectedResult |
	| 0       | 0       | 0              |
	| 0       | 1       | 1              |
	| 1       | 0       | 1              |
	| 1       | 1       | 2              |
	| -10     | -20     | -30            |
	| -20     | 20      | 0              |

Scenario Template: Table with named examples
	Given I have entered <number1> into the calculator
	And I have also entered <number2> into the calculator
	When I press add
	Then the result should be <expectedResult> on the screen

	Scenarios: 
	| test-id   | number1 | number2 | expectedResult |
	| zeroes    | 0       | 0       | 0              |
	| 0_1_1     | 0       | 1       | 1              |
	| 1_0_1     | 1       | 0       | 1              |
	| 1_1_2     | 1       | 1       | 2              |
	| negatives | -10     | -20     | -30            |