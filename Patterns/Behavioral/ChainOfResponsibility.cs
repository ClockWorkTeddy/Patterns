namespace Patterns.Behavioral;

public interface IHandler
{
  void SetNext(IHandler handler);
  string Handle(string request);
}

public abstract class BaseHandler : IHandler
{
  private IHandler _nextHandler;

  public void SetNext(IHandler handler)
  {
    _nextHandler = handler;
  }

  public virtual string Handle(string request)
  {
    if (_nextHandler != null)
    {
      return _nextHandler.Handle(request);
    }

    return "None";
  }
}

public class ConcreteHandlerA : BaseHandler
{
  public override string Handle(string request)
  {
    if (request == "A")
    {
      return "Handled by ConcreteHandlerA";
    }
    else
    {
      return base.Handle(request);
    }
  }
}

public class ConcreteHandlerB : BaseHandler
{
  public override string Handle(string request)
  {
    if (request == "B")
    {
      return "Handled by ConcreteHandlerB";
    }
    else
    {
      return base.Handle(request);
    }
  }
}