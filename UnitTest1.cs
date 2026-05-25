using Xunit;
using MzansiPayrollApp;

public class PayrollCalculatorTests
{
[Fact]
public void CalculateGrossPay_40Hours_Returns400()
{
var result = PayrollCalculator.CalculateGrossPay(40, 10);
Assert.Equal(400, result);
}

[Fact]
public void CalculateNetPay_AfterTax_ReturnsCorrectAmount()
{
var result = PayrollCalculator.CalculateNetPay(1000, 0.1);
Assert.Equal(900, result);
}
}