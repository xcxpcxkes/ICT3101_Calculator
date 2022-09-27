using ICT3101_Calculator;
using NUnit.Framework;

namespace SpecFlowCalculatorTests.Steps;

[Binding]
public class CalculatorFailureIntensityStepDefinitions
{
    private Calculator _calculator;
    private double _result;
    
    public CalculatorFailureIntensityStepDefinitions(Calculator calculator)
    {
        _calculator = calculator;
    }
    
    [When(@"I enter (.*) for the failure intensity decay, (.*) for the initial failure intensity and (.*) for the average number of failures")]
    public void WhenIEnterForTheFailureIntensityDecayForTheInitialFailureIntensityAndForTheAverageNumberOfFailures(double p0, int p1, int p2)
    {
        _result = _calculator.CalculateCurrentFailureIntensity(p0, p1, p2);
    }

    [Then(@"the failure intensity result is (.*)")]
    public void ThenTheFailureIntensityResultIs(double p0)
    {
        Assert.That(_result, Is.EqualTo(p0));
    }

    [When(@"I enter (.*) for the failure intensity decay, (.*) for the initial failure intensity and (.*) for the CPU hours")]
    public void WhenIEnterForTheFailureIntensityDecayForTheInitialFailureIntensityAndForTheCpuHours(double p0, int p1, int p2)
    {
        _result = _calculator.CalculateNumberOfExpectedFailure(p0, p1, p2);
    }

    [Then(@"the number of expected failure is (.*)")]
    public void ThenTheNumberOfExpectedFailureIs(int p0)
    {
        Assert.That(_result, Is.EqualTo(p0));
    }
}