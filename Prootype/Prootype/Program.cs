using Prootype;

var carPrototypeFactory = new CarPrototypeFactory();
Console.WriteLine("Hello, Client!");
Console.WriteLine($"Which type of a car do you want? {CarTypeEnum.Sedan} {CarTypeEnum.Pickup} {CarTypeEnum.Minivan}");
var carType = Console.ReadLine();
Car yourNewCar;

if(carType == CarTypeEnum.Sedan.ToString())
{
    yourNewCar = carPrototypeFactory.GetSedan();
}
else if (carType == CarTypeEnum.Pickup.ToString())
{
    yourNewCar = carPrototypeFactory.GetPickup();
}
else if (carType == CarTypeEnum.Minivan.ToString())
{
    yourNewCar = carPrototypeFactory.GetMinivan();
}
else
{
    Console.WriteLine("We don't have this type of car!");
    Console.WriteLine("Get out of my sight!");
    Console.ReadKey();
    throw new ArgumentOutOfRangeException($"Invalid car type {carType}");
}

Console.WriteLine("Choose a license number");
yourNewCar.Number = Console.ReadLine();
yourNewCar.Introduce();
Console.ReadKey();


