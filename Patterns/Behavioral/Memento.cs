namespace Patterns.Behavioral;

public interface IOriginator
{
  IMemento Save();
}

public interface IMemento
{
  string Restore();
}

public class Originator : IOriginator
{
  public string State { get; set; } = "";

  public IMemento Save()
  {
    return new Memento(State, this);
  }
}

public class Memento : IMemento
{
  private readonly string _state;
  private readonly Originator _originator;
  public Memento(string state, Originator originator)
  {
    _state = state;
    _originator = originator;
  }

  public string Restore()
  {
    _originator.State = _state;
    return _state;
  }
}

public class Caretaker
{
  private readonly List<IMemento> _mementos = new();
  private readonly IOriginator _originator;
  public Caretaker(IOriginator originator)
  {
    _originator = originator; 
  }

  public void SaveMemento()
  {
    _mementos.Add(_originator.Save());
  }

  public void Undo()
  {
    if (_mementos.Count > 0)
    {
      _mementos.Last().Restore();
      _mementos.RemoveAt(_mementos.Count - 1);
    }
  }
}