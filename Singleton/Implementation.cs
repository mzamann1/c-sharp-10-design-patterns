namespace Singleton;

public class Logger
{
    //Lazy<T> for thread safety

    /// <summary>
    /// Provides support for lazy initialization.
    /// By default, all public and protected members of <see cref="Lazy{T}">; are thread-safe
    /// and may be used concurrently from multiple threads.
    /// </summary>

    private static readonly Lazy<Logger> _lazyLogger = new Lazy<Logger>(() => new Logger());


    //property to be available for the clients to get instance of the class
    public static Logger Instance
    {
        get
        {
            //returning the lazy value of logger
            return _lazyLogger.Value;
        }
    }

    protected Logger()
    {
    }

    //simple method
    public void Log(string message)
    {
        Console.WriteLine($"Message from {message}");
    }
}