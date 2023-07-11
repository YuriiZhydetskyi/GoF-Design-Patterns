using ChainOfResponsibility;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.InputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("Hello, World!");

var emergencyCallHandler = new PoliceCallHandler(new FiremansCallHandler(new AmbulanceCallHandler(new VoidCallHandler(null))));
Console.WriteLine("Яка у Вас проблема?");
Console.WriteLine("1. сусід зверху танцює");
Console.WriteLine("2. У мене палає");
Console.WriteLine("3. Поліція прострелила мені ногу");
Console.WriteLine("4. Я просто подзвонив, щоб поспілкуватись");

Console.Write("Ваша проблема: ");
var emergency = Console.ReadLine();

switch (emergency)
{
    case "1":
        emergency = "сусід зверху танцює";
        break;
    case "2":
        emergency = "У мене палає";
        break;
    case "3":
        emergency = "Поліція прострелила мені ногу";
        break;
    case "4":
        emergency = "Я просто подзвонив, щоб поспілкуватись";
        break;
    default:
        break;
}

emergencyCallHandler.Handle(emergency);
Console.ReadKey();

