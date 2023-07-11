namespace Proxy;

internal class CalculatorFacadeCache : ICalculatorFacade
{
    private CalculatorFacade _calculator;

    int? AddResult { get; set; }
    int? SubtractResult { get; set; }
    int? MultiplyResult { get; set; }
    int? DivideResult { get; set; }

    public CalculatorFacadeCache()
    {
        _calculator = new CalculatorFacade();
    }

    public int Add(int num1, int num2)
    {
        if (AddResult == null)
        {
            AddResult = _calculator.Add(num1, num2);
        }
        
        return AddResult.Value;
    }

    public int Divide(int num1, int num2)
    {
        if (DivideResult == null)
        {
            DivideResult = _calculator.Divide(num1, num2);
        }
        
        return DivideResult.Value;
    }

    public int Multiply(int num1, int num2)
    {
        if (MultiplyResult == null)
        {
            MultiplyResult = _calculator.Multiply(num1, num2);
        }
        
        return MultiplyResult.Value;
    }

    public int Subtract(int num1, int num2)
    {
        if (SubtractResult == null)
        {
            SubtractResult = _calculator.Subtract(num1, num2);
        }
        
        return SubtractResult.Value;
    }
}
