namespace Flyweight;

internal class Solder : Unit
{
    public Solder(int id, UnitSharedFields sharedState) : base(id, sharedState)
    {
    }

    public override void Draw()
    {
        Console.WriteLine($"Drawing a solder at ({X}, {Y})");
    }
}
