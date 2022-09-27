#As a system quality engineer,
#I want to be able to use the Musa Logarithmic model 
#So that I can calculate the failure intensity

#As a system quality engineers, 
#I want to be able to use the Musa Logarithmic model 
#so that I can calculate the number of failures.

Feature: UsingCalculatorFailureIntensity
	Calculator to calculate the failure intensity and the number of expected failures using the Musa Logarithmic Model

@FailureIntensity
Scenario: Calculate failure intensity using the Musa Logarithmic Model
	Given I have a calculator
	When I enter 0.02 for the failure intensity decay, 10 for the initial failure intensity and 50 for the average number of failures
	Then the failure intensity result is 3.68
	
Scenario: Calculate the number of expected failures using the Musa Logarithmic Model
	Given I have a calculator
	When I enter 0.02 for the failure intensity decay, 10 for the initial failure intensity and 10 for the CPU hours
	Then the number of expected failure is 55
