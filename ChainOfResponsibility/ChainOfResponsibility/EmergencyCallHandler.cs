namespace ChainOfResponsibility;

internal abstract class EmergencyCallHandler
{
    private readonly EmergencyCallHandler _nextHandler;

    public EmergencyCallHandler(EmergencyCallHandler nextHandler)
    {
        _nextHandler = nextHandler;
    }

    public void Handle(string emergency)
    {
        if (CanHandle(emergency))
        {
            DoHandle(emergency);
        }
        else
        {
            _nextHandler?.Handle(emergency);
        }
    }

    public abstract void DoHandle(string emergency);
    public abstract bool CanHandle(string emergency);
}
