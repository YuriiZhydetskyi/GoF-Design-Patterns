using FactoryMethod;

Console.WriteLine("Lets cook");

var oven = new Oven();
var ingredients = new List<string>();
Dish dish;

while (true)
{
    Console.WriteLine("Add ingredient");
    var ingredient = Console.ReadLine();
    if (ingredient == "stop")
    {
        dish = oven.CookDish(ingredients);
        break;
    }
    ingredients.Add(ingredient);
}

Console.WriteLine($"Your {dish.GetType().Name} is ready");
dish.Eat();