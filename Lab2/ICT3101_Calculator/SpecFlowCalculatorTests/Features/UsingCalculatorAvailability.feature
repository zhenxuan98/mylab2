﻿Feature: UsingCalculatorAvailability
In order to calculate MTBF and Availability
As someone who struggles with math
I want to be able to use my calculator to do this
@Availability
Scenario: Calculating MTBF
Given I have a calculator
When I have entered 10 and 20 into the calculator and press MTBF
Then the MTBF result should be 30
@Availability
Scenario: Calculating Availability
Given I have a calculator
When I have entered 20 and 40 into the calculator and press Availability
Then the availability result should be 0.5
