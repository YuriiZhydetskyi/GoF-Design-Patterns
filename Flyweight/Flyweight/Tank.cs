namespace Flyweight;

internal class Tank : Unit
{
    public Tank(int id, UnitSharedFields sharedState) : base(id, sharedState)
    {
    }

    public override void Draw()
    {
        Console.WriteLine($"Drawing a tank at ({X}, {Y})");
    }
}
