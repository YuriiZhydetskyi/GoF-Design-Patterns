using Bridge.Cuisines;

namespace Bridge.Foods;

internal class FirstFood : AbstractFood
{
    public FirstFood(AbstractCuisine cuisine) : base(cuisine)
    {
    }

    public void Cook()
    {
        Cuisine.Cook();
        Console.WriteLine("First food");
    }
}
