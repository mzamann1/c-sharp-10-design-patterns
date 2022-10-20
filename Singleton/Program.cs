using Singleton;

Console.Title = "Singleton";


var logger = Logger.Instance;
var logger2 = Logger.Instance;

if (logger.Equals(logger2) && logger2.Equals(Logger.Instance))
{
    Console.WriteLine($"Same Instances");
}

logger.Log(nameof(logger));
logger.Log(nameof(logger2));
Logger.Instance.Log(nameof(Logger.Instance));
