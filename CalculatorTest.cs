using Xunit;
namespace Calculator;

public class CalculatorTest
{
    [Fact]
    public void Add()
    {
        // Arrange
        var calculator = new Calculator();
        var num1 = 5;
        var num2 = 5;

        // Act
        int result = calculator.Add(num1, num2);

        // Assert
        Assert.Equal(10, result);
    }
}