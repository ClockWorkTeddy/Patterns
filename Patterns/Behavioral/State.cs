namespace Patterns.Behavioral;

public class Context
{
  private IState _state;

  public Context(IState state)
  {
    _state = state;
  }

  public void SetState(IState state)
  {
    _state = state;
  }

  public void Request()
  {
    _state.Handle(this);
  }
}

public interface IState
{
  void Handle(Context context);
}

public class ConcreteStateA : IState
{
  public void Handle(Context context)
  {
    Console.WriteLine("Handling request in ConcreteStateA");
    context.SetState(new ConcreteStateB());
  }
}

public class ConcreteStateB : IState
{
  public void Handle(Context context)
  {
    Console.WriteLine("Handling request in ConcreteStateB");
    context.SetState(new ConcreteStateA());
  }
}
