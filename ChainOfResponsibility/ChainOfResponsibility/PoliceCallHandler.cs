namespace ChainOfResponsibility;

internal class PoliceCallHandler : EmergencyCallHandler
{
    public PoliceCallHandler(EmergencyCallHandler nextHandler) : base(nextHandler)
    {
    }

    public override void DoHandle(string emergency)
    {
        Console.WriteLine($"Поліція прострелила сусіду ногу. Більше він Вас не потурбує");
    }

    public override bool CanHandle(string emergency)
    {
        return emergency == "сусід зверху танцює";
    }
}
