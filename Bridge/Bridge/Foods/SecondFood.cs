using Bridge.Cuisines;

namespace Bridge.Foods;

internal class SecondFood : AbstractFood
{
    public SecondFood(AbstractCuisine cuisine) : base(cuisine)
    {
    }

    public void Cook()
    {
        Cuisine.Cook();
        Console.WriteLine("Second food");
    }
}
