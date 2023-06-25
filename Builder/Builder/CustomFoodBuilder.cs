namespace Builder;

internal abstract class CustomFoodBuilder<T> where T : IFood, new()
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

    public abstract CustomFoodBuilder<T> AddCheese();
    public abstract CustomFoodBuilder<T> AddBackon();
    public abstract CustomFoodBuilder<T> AddAnanas();
    public abstract CustomFoodBuilder<T> AddMushrooms();
    public abstract CustomFoodBuilder<T> AddFish();
}
