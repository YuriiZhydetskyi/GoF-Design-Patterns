namespace Adapter;

internal class SiemensCallCenter : ISiemensCallCenter
{
    public void AnrufMachen()
    {
        Console.WriteLine("Allo");
    }
}
