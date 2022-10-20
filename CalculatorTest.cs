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

    [Fact]
    public void Minus()
    {
        // Arrange
        var calculator = new Calculator();
        var num1 = 50;
        var num2 = 30;

        // Act
        var result = calculator.Minus(num1, num2);

        // Assert
        Assert.Equal(20, result);
    }

    [Fact]
    public void Divide()
    {
        // Arrange
        var calculator = new Calculator();
        var num1 = 24;
        var num2 = 6;

        // Act
        var result = calculator.Divide(num1, num2);

        // Assert
        Assert.Equal(4, result);
    }

    [Fact]
    public void Multiply()
    {
        // Arrange
        var calculator = new Calculator();
        var num1 = 5;
        var num2 = 5;

        // Act
        var result = calculator.Multiply(num1, num2);

        // Assert
        Assert.Equal(25, result);
    }
}