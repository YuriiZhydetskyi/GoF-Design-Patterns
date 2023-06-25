namespace Prootype;

internal class CarPrototypeFactory
{
    public readonly Car _sedanPrototype;
    public readonly Car _pickupPrototype;
    public readonly Car _minivanPrototype;

    public CarPrototypeFactory()
    {
        _sedanPrototype = new Car(CarTypeEnum.Sedan, "", "black");
        _pickupPrototype = new Car(CarTypeEnum.Pickup, "", "black");
        _minivanPrototype = new Car(CarTypeEnum.Minivan, "", "black");
    }

    public Car GetSedan() { return _sedanPrototype.Clone(); }
    public Car GetPickup() { return _pickupPrototype.Clone(); }
    public Car GetMinivan() { return _minivanPrototype.Clone(); }

}
