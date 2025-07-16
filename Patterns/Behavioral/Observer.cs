namespace Patterns.Behavioral;

public class Publisher
{
  public event Action<string>? Notify;

  public void Publish(string message)
  {
    Notify?.Invoke(message);
  }
}

public interface ISubscriber
{
  void Update(string message);
}

public class Subscriber : ISubscriber
{
  private readonly string _name;
  public Subscriber(string name)
  {
    _name = name;
  }
  public void Update(string message)
  {
    Console.WriteLine($"{_name} received message: {message}");
  }
}