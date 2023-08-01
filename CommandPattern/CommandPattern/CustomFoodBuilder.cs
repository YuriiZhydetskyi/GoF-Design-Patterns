namespace Builder;

internal abstract class CustomFoodBuilder<T> where T : Food, new()
{
    protected T _food;

    public CustomFoodBuilder()
    {
        Reset();
    }
    public void Reset()
    {
        _food = new T();
    }
    public T GetFood()
    {
        var result = _food;
        Reset();
        return result;
    }

    public void PrintCurrentIngredients()
    {
        Console.WriteLine($"Ingredients: {string.Join(", ", _food.Ingredients)}");
    }

    public abstract CustomFoodBuilder<T> AddCheese();
    public abstract CustomFoodBuilder<T> AddBackon();
    public abstract CustomFoodBuilder<T> AddAnanas();
    public abstract CustomFoodBuilder<T> AddMushrooms();
    public abstract CustomFoodBuilder<T> AddFish();

    public abstract CustomFoodBuilder<T> RemoveCheese();
    public abstract CustomFoodBuilder<T> RemoveBackon();
    public abstract CustomFoodBuilder<T> RemoveAnanas();
    public abstract CustomFoodBuilder<T> RemoveMushrooms();
    public abstract CustomFoodBuilder<T> RemoveFish();
}
