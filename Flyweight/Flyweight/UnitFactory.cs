namespace Flyweight;

internal class UnitFactory
{
    private readonly Dictionary<string, UnitSharedFields> _sharedFields = new();

    public UnitFactory()
    {
        _sharedFields.Add("Solder", new UnitSharedFields("SolderTexture.png", "SolderSound.wav"));
        _sharedFields.Add("Tank", new UnitSharedFields("TankTexture.png", "TankSound.wav"));
    }

    public Unit GetUnit(string unitType, int id)
    {
        switch (unitType)
        {
            case "Solder":
                return new Solder(id, _sharedFields[unitType]);
            case "Tank":
                return new Tank(id, _sharedFields[unitType]);
            default:
                throw new ArgumentException("Invalid unit type", nameof(unitType));
        }
    }
}
