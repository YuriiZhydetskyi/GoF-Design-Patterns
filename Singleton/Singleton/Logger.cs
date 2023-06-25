namespace Singleton;

internal class Logger
{
    private const int _maxInstancesCount = 10;
    private static readonly List<Logger> Instances = new List<Logger>(_maxInstancesCount);
    private static Random rand = new Random();
    private static readonly object lockObject = new object();

    private Logger() { }

    public static Logger GetInstance()
    {
        lock (lockObject)
        {
            if (Instances.Count < _maxInstancesCount)
            {
                var result = new Logger();
                Instances.Add(result);
                Console.WriteLine("A new logger was created");
                return result;
            }
            else
            {
                return Instances[rand.Next(_maxInstancesCount)];
            }
        }
    }

    public void Introduce()
    {
        Console.WriteLine("Hello! I'm your logger");
    }
}
