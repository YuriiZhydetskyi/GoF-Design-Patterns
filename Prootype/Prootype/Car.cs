namespace Prootype;

internal class Car : IPrototype<Car>
{
    public CarTypeEnum CarType { get; set; }
    public string Number { get; set; }
    public string Color { get; set; }
    public Car(CarTypeEnum carType, string number, string color)
    {
        CarType = carType;
        Number = number;
        Color = color;
    }

    public Car Clone()
    {
        return new Car(CarType, Number, Color);
    }

    public void Introduce()
    {
        Console.WriteLine($"Hello! My name is {Number}. I'm your new {CarType}");
    }
}
