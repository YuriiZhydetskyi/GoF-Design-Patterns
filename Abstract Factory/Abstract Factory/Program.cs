using Abstract_Factory.BusinessLunchFactory;

Console.WriteLine("Hello, Client!");
Console.WriteLine($"Which type of business lunch do you want? {BusinessLunchTypes.American} {BusinessLunchTypes.Ukrainian} {BusinessLunchTypes.Japan}");
var lunchType = Console.ReadLine();
IBusinessLunchAbstractFactory businessLunchFactory;

if (lunchType == BusinessLunchTypes.American.ToString())
{
    businessLunchFactory = new AmericanBusinessLunchFactory();
}
else if (lunchType == BusinessLunchTypes.Ukrainian.ToString())
{
    businessLunchFactory = new UkrainianBusinessLunchFactory();
}
else if (lunchType == BusinessLunchTypes.Japan.ToString())
{
    businessLunchFactory = new JapanBusinessLunchFactory();
}
else
{
    Console.WriteLine("We don't serve this type of busines lunch!");
    Console.WriteLine("Get out of my sight!");
    Console.ReadKey();
    throw new ArgumentOutOfRangeException($"Invalid lunch type {lunchType}");
}

Console.WriteLine("Press any button to receive the first dish");
Console.ReadKey();
var firstDish = businessLunchFactory.CreateFirstDish();
firstDish.Serve();
Console.WriteLine("Press any button to receive the secont dish");
Console.ReadKey();
var secondDish = businessLunchFactory.CreateSecondDish();
secondDish.Serve();
Console.WriteLine("Press any button to receive a kompot");
Console.ReadKey();
var kompot = businessLunchFactory.CreateKompot();
kompot.Serve();
Console.WriteLine("Thank you, come again");
Console.ReadKey();


