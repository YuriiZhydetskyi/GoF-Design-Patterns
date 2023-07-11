namespace Flyweight;

internal class UnitSharedFields
{
    public string Texture { get; }
    public string Sound { get; }

    public UnitSharedFields(string texture, string sound)
    {
        Texture = texture;
        Sound = sound;
    }
}
