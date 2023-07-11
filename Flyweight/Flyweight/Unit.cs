namespace Flyweight;

internal abstract class Unit
{
    public int Id { get; }
    public int Health { get; set; }
    public int Armor { get; set; }
    public int Damage { get; set; }
    public int Speed { get; set; }
    public int X { get; set; }
    public int Y { get; set; }

    protected UnitSharedFields _sharedState { get; }

    public Unit(int id, UnitSharedFields sharedState)
    {
        Id = id;
        _sharedState = sharedState;
    }

    public abstract void Draw();

    public void MoveTo(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void MoveBy(int x, int y)
    {
        X += x;
        Y += y;
    }
}
