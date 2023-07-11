using Flyweight;

var unitFactory = new UnitFactory();
var army = new List<Unit>
{
    unitFactory.GetUnit("Solder", 1),
    unitFactory.GetUnit("Solder", 2),
    unitFactory.GetUnit("Solder", 3),
    unitFactory.GetUnit("Tank", 1),
    unitFactory.GetUnit("Tank", 2),
    unitFactory.GetUnit("Tank", 3)
};


foreach (var unit in army)
{
    unit.X = new Random().Next(0, 100);
    unit.Y = new Random().Next(0, 100);
    unit.Draw();
}

var moveByX = 20;
var moveByY = 30;
Console.WriteLine($"Moving by {moveByX} {moveByY} ...");

foreach (var unit in army)
{
    unit.MoveBy(moveByX, moveByY);
    unit.Draw();
}

Console.ReadKey();