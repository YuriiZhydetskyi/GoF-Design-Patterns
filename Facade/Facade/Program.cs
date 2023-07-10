// See https://aka.ms/new-console-template for more information
using Facade;

Console.WriteLine("Hello, World!");

CalculatorFacade calculator = new CalculatorFacade();
int sum = calculator.Add(4, 5);
int difference = calculator.Subtract(10, 3);
int product = calculator.Multiply(4, 5);
int quotient = calculator.Divide(20, 4);

Console.WriteLine($"Sum: {sum}");