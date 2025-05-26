namespace Patterns.Creational;

public class Singleton
{
  private static Singleton? _instance;
  private static int counter = 0;

  private int id;

  private static readonly object _lock = new object();

  // Private constructor to prevent instantiation
  private Singleton(int id)
  {
    this.id = id;
  }

  // Public method to provide access to the instance
  public static Singleton Instance
  {
    get
    {
      lock (_lock)
      {
        if (_instance == null)
        {
          _instance = new Singleton(counter++);
        }
        return _instance;
      }
    }
  }

  // Example method
  public void DoSomething()
  {
    Console.WriteLine("Doing something from Singleton instance with ID: " + id);
  }
}