using ICT3101_Calculator;
using NUnit.Framework;

namespace SpecFlowCalculatorTests.Steps;

[Binding]
public class CalculatorDefectDensityStepDefinitions
{
    private Calculator _calculator;
    private double _result;
    
    public CalculatorDefectDensityStepDefinitions(Calculator calculator)
    {
        _calculator = calculator;
    }
    
    [When(@"I entered (.*) for the number of defects and (.*) for the number of lines in the codes")]
    public void WhenIEnteredForTheNumberOfDefectsAndForTheNumberOfLinesInTheCodes(int p0, int p1)
    {
        _result = _calculator.calculateDefectDensity(p0, p1);
    }

    [Then(@"the defect density result should be (.*)")]
    public void ThenTheDefectDensityResultShouldBe(decimal p0)
    {
        Assert.That(_result, Is.EqualTo(p0));
    }
    
    [When(@"I entered (.*) for KSSI, (.*) for KCSI and (.*) for the new lines of codes and (.*) deleted lines of codes")]
    public void WhenIEnteredForKssiForKcsiAndForTheNewLinesOfCodesAndDeletedLinesOfCodes(int p0, int p1, int p2, int p3)
    {
        _result = _calculator.calculateSSI(p0, p1, p2, p3);
    }

    [Then(@"the new Shipped Source Instructions \(SSI\) is (.*)")]
    public void ThenTheNewShippedSourceInstructionsSsiIs(int p0)
    {
        Assert.That(_result, Is.EqualTo(p0));
    }


}