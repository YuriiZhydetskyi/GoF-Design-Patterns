using Adapter;

ICallCenterAdapter callCenter = new SiemensCallCenterAdapter();
callCenter.MakeCall();
Console.ReadKey();