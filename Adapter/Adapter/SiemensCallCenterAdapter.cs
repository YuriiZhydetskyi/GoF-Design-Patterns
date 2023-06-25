namespace Adapter;

internal class SiemensCallCenterAdapter : ICallCenterAdapter
{
    private readonly SiemensCallCenter _callCenter;
    public SiemensCallCenterAdapter()
    {
        _callCenter = new SiemensCallCenter();
    }
    public void MakeCall()
    {
        _callCenter.AnrufMachen();
    }
}
