using Builder;

var pizzaBuilder = new PizzaBuilder();

Console.WriteLine("Hello, Customer!");
Console.WriteLine("Do you want Pizza 4 cheeses? y/n");

if(Console.ReadKey().KeyChar is 'y' or 'Y')
{
    pizzaBuilder.AddCheese().AddCheese().AddCheese().AddCheese().GetFood().Introduce();
}
else
{
    Console.WriteLine("Do you want to add a cheese to the pizza? y/n");
    if(Console.ReadKey().KeyChar is  'y' or 'Y')
    {
        pizzaBuilder.AddCheese();
    }
    Console.WriteLine("Do you want to add a backon to the pizza? y/n");
    if(Console.ReadKey().KeyChar is  'y' or 'Y')
    {
        pizzaBuilder.AddBackon();
    }
    Console.WriteLine("Do you want to add an ananas to the pizza? y/n");
    if(Console.ReadKey().KeyChar is  'y' or 'Y')
    {
        pizzaBuilder.AddAnanas();
    }
    Console.WriteLine("Do you want to add a mushrooms to the pizza? y/n");
    if(Console.ReadKey().KeyChar is  'y' or 'Y')
    {
        pizzaBuilder.AddMushrooms();
    }
    Console.WriteLine("Do you want to add a fish to the pizza? y/n");
    if(Console.ReadKey().KeyChar is  'y' or 'Y')
    {
        pizzaBuilder.AddFish();
    }

    pizzaBuilder.GetFood().Introduce();
}

Console.ReadKey();

