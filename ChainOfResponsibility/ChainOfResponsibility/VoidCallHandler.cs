namespace ChainOfResponsibility;

internal class VoidCallHandler : EmergencyCallHandler
{
    public VoidCallHandler(EmergencyCallHandler nextHandler) : base(nextHandler)
    {
    }

    public override void DoHandle(string emergency)
    {
        Console.WriteLine($"Ви подзвонили на 112 без поважної причини. Поліція вже в дорозі, щоб прострелити Вам ногу");
    }

    public override bool CanHandle(string emergency)
    {
        return true;
    }
}
