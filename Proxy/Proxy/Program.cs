using Proxy;

//ICalculatorFacade calculator = new CalculatorFacade();
ICalculatorFacade calculator = new CalculatorFacadeCache();
int sum = calculator.Add(4, 5);
int difference = calculator.Subtract(10, 3);
int product = calculator.Multiply(4, 5);
int quotient = calculator.Divide(20, 4);

Console.WriteLine($"Sum: {sum}");

int sum2 = calculator.Add(4, 20);
Console.WriteLine($"Sum: {sum2}"); 

