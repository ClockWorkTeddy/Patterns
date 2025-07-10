namespace Patterns.Behavioral;

public interface IMediator
{
  void Notify(object sender, string message);
}

public class ComponentA
{
  public IMediator? Mediator { get; set; }
  public bool State { get; set; }
}

public class ComponentB
{
  public IMediator? Mediator { get; set; }

  public void DoSomething()
  {
    // Logic for Component A
    Mediator?.Notify(this, "ComponentA did something");
  }

  public void DoSomethingAnother()
  {
    // Logic for Component B
    Console.WriteLine("Fine");
  }
}

public class ConcreteMediator : IMediator
{
  private readonly ComponentA _componentA;
  private readonly ComponentB _componentB;

  public ConcreteMediator(ComponentA componentA, ComponentB componentB)
  {
    _componentA = componentA;
    _componentB = componentB;
  }

  public void Notify(object sender, string message)
  {
    if (sender is ComponentB)
    {
      // Handle notification from Component B
      Console.WriteLine($"Mediator received from ComponentB: {message}");

      if (_componentA.State)
      {
        _componentB.DoSomethingAnother();
      }
    }
  }
}