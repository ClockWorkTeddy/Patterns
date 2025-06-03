namespace Patterns.Structural;

public interface ISender
{
  void SendMessage();
}

public class EmailSender : ISender
{
  public void SendMessage()
  {
    Console.WriteLine("Email sent");
  }
}

public class SenderDecorator : ISender
{
  private readonly ISender _sender;

  public SenderDecorator(ISender sender)
  {
    _sender = sender;
  }

  public virtual void SendMessage()
  {
    _sender.SendMessage();
  }
}

public class TgSenderDecorator : SenderDecorator
{
  public TgSenderDecorator(ISender sender) : base(sender)
  {
  }

  public override void SendMessage()
  {
    base.SendMessage();
    Console.WriteLine("Telegram message sent");
  }
}

public class SmsSenderDecorator : SenderDecorator
{
  public SmsSenderDecorator(ISender sender) : base(sender)
  {
  }

  public override void SendMessage()
  {
    base.SendMessage();
    Console.WriteLine("SMS message sent");
  }
}