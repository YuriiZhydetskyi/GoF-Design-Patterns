namespace Facade;

public class CalculatorFacade
{
    private CalculatorSoapClient _client;

    public CalculatorFacade()
    {
        _client = new CalculatorSoapClient();
    }

    public int Add(int num1, int num2)
    {
        return _client.Add(num1, num2);
    }

    public int Subtract(int num1, int num2)
    {
        return _client.Subtract(num1, num2);
    }

    public int Multiply(int num1, int num2)
    {
        return _client.Multiply(num1, num2);
    }

    public int Divide(int num1, int num2)
    {
        if (num2 == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero");
        }
        return _client.Divide(num1, num2);
    }
}
