namespace ChainOfResponsibility;

internal class AmbulanceCallHandler : EmergencyCallHandler
{
    public AmbulanceCallHandler(EmergencyCallHandler nextHandler) : base(nextHandler)
    {
    }

    public override void DoHandle(string emergency)
    {
        Console.WriteLine($"Ми вилікували Вашу ногу. Тепер Ви можете знову танцювати. Навіть голосніше ніж раніше.");
    }

    public override bool CanHandle(string emergency)
    {
        return emergency == "Поліція прострелила мені ногу";
    }
}