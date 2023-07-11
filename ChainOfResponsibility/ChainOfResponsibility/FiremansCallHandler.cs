namespace ChainOfResponsibility;

internal class FiremansCallHandler : EmergencyCallHandler
{
    public FiremansCallHandler(EmergencyCallHandler nextHandler) : base(nextHandler)
    {
    }

    public override void DoHandle(string emergency)
    {
        Console.WriteLine($"Пш пш. Пожежники прибули і загасили Ваш пердак");
    }

    public override bool CanHandle(string emergency)
    {
        return emergency == "У мене палає";
    }
}