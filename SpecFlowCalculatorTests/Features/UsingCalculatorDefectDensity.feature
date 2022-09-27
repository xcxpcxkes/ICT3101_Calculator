# EPIC: #Customised command line calculator to perform quality metric calculations.

#As a system quality engineers, 
#I want to be able to calculate the defect density 
#So that I know the number of confirmed defects in the system

#As a system quality engineers, 
#I want to be have a custom calculation
#So that I can calculate the total number of Shipped Source Instructions (SSI)

Feature: UsingCalculatorDefectDensity
	To calculate the total number of Shipped Source Instructions (SSI) by calculating defect density
	
@DefectDensity
Scenario: Calculate Defect Density
	Given I have a calculator
	When I entered 100 for the number of defects and 50 for the number of lines in the codes
	Then the defect density result should be 2.0
	
#@DefectDensity
#Scenario: Calculate Defect Density with invalid inputs
#	Given I have a calculator
#	When I entered 100 as the number of defects and <value2> as the number of lines in the codes
#	Then the defect density result should be <value3>
#	
@DefectDensity
Scenario: Calculate the new total number of Shipped Source Instructions (SSI)
	Given I have a calculator
	When I entered 50 for KSSI, 20 for KCSI and 4 for the new lines of codes and 0 deleted lines of codes
	Then the new Shipped Source Instructions (SSI) is 66