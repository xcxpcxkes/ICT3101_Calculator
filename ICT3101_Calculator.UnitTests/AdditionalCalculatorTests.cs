using Moq;

namespace ICT3101_Calculator;

public class AdditionalCalculatorTests
{
    private Calculator _calculator;
    private Mock<IFileReader> _mockFileReader;
    
    [SetUp]
    public void Setup()
    {
        _mockFileReader = new Mock<IFileReader>();
        _mockFileReader.Setup(fr =>
            fr.Read("/Users/sinjie/Projects/ICT3101_Calculator/ICT3101_Calculator/MagicNumbers.txt")).Returns(new string[3]{"-1", "0", "1"});
        _calculator = new Calculator();
    }
    
    [Test]
    [TestCase(0)]
    public void GenMagicNum_WhenGivenInput0_ResultsEqual2(double input)
    {
        Assert.That(() => _calculator.GenMagicNum(input, _mockFileReader.Object), Is.EqualTo(2));
    }
        
    [Test]
    [TestCase(1)]
    public void GenMagicNum_WhenGivenInput1_ResultsEqual0(double input)
    {
        Assert.That(() => _calculator.GenMagicNum(input, _mockFileReader.Object), Is.EqualTo(0));
    }
        
    [Test]
    [TestCase(2)]
    public void GenMagicNum_WhenGivenInput2_ResultsEqual2(double input)
    {
        Assert.That(() => _calculator.GenMagicNum(input, _mockFileReader.Object), Is.EqualTo(2));
    }
    
}