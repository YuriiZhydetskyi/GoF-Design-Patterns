using Bridge.Cuisines;

namespace Bridge.Foods;

internal abstract class AbstractFood
{
    protected readonly AbstractCuisine Cuisine;

    protected AbstractFood(AbstractCuisine cuisine)
    {
        Cuisine = cuisine;
    }
}
