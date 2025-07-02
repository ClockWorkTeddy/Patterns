namespace Patterns.Behavioral;

public interface ICommand
{
  void Execute();
}

public class DisplayMessageButton
{
  private readonly ICommand _command;

  public DisplayMessageButton(ICommand command)
  {
    _command = command;
  }

  public void Click()
  {
    _command.Execute();
  }
}

public class DisplayMessageCommand : ICommand
{
  private readonly string _message;

  public DisplayMessageCommand(string message)
  {
    _message = message;
  }

  public void Execute()
  {
    System.Console.WriteLine(_message);
  }
}

public class DisplayCapitalizedMessageCommand : ICommand
{
  private readonly string _message;

  public DisplayCapitalizedMessageCommand(string message)
  {
    _message = message.ToUpper();
  }

  public void Execute()
  {
    System.Console.WriteLine(_message);
  }
}