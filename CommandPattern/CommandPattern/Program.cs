using Builder;
using CommandPattern;
using CommandPattern.Commands;

Console.WriteLine("Which ingredients do you want to add to your pizza?");
Console.WriteLine("1. Cheese");
Console.WriteLine("2. Ananas");
Console.WriteLine("3. Backon");
Console.WriteLine("0. Done");
Console.WriteLine("z. Undo");
Console.WriteLine("y. Redo");
Console.WriteLine("Please enter your choice:");

var pizzaBuilder = new PizzaBuilder();
var pizzaBuilderInvoker = new PizzaBuilderInvoker();

while (true)
{
      var input = Console.ReadLine();
    if (input == "0")
    {
        break;
    }

    if (input == "z")
    {
        pizzaBuilderInvoker.Undo();
        continue;
    }

    if (input == "y")
    {
        pizzaBuilderInvoker.Redo();
        continue;
    }

    if (input == "1")
    {
        pizzaBuilderInvoker.Execute(new AddCheeseCommand<Pizza>(pizzaBuilder));
        continue;
    }

    if (input == "2")
    {
        pizzaBuilderInvoker.Execute(new AddAnanasCommand<Pizza>(pizzaBuilder));
        continue;
    }

    if (input == "3")
    {
        pizzaBuilderInvoker.Execute(new AddBackonCommand<Pizza>(pizzaBuilder));
        continue;
    }

    Console.WriteLine("Invalid input");
}

Console.WriteLine("Here is your pizza:");
var pizza = pizzaBuilder.GetFood();
pizza.Introduce();
Console.WriteLine("Press any key to exit...");
Console.ReadKey();