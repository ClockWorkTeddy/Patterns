namespace Patterns.Structural;

public interface IDevice
{
  bool IsEnabled();
  void PowerOn();
  void PowerOff();
  void SetVolume(int volume);
  void SetChannel(int channel);
  int GetVolume();
  int GetChannel();
}

public class RemoteControl
{
  private readonly IDevice _device;

  public RemoteControl(IDevice device)
  {
    _device = device;
  }

  public void PressPowerBtn()
  {
    if (_device.IsEnabled())
    {
      _device.PowerOff();
    }
    else
    {
      _device.PowerOn();
    }
  }

  public void VolumeUp()
  {
    int currentVolume = _device.GetVolume();
    _device.SetVolume(currentVolume + 1);
  }

  public void VolumeDown()
  {
    int currentVolume = _device.GetVolume();
    _device.SetVolume(currentVolume - 1);
  }

  public void ChannelUp()
  {
    int currentChannel = _device.GetChannel();
    _device.SetChannel(currentChannel + 1);
  }

  public void ChannelDown()
  {
    int currentChannel = _device.GetChannel();
    _device.SetChannel(currentChannel - 1);
  }
}

public class TV : IDevice
{
  private bool _isEnabled;
  private int _volume;
  private int _channel;

  public bool IsEnabled() => _isEnabled;

  public void PowerOn()
  {
    _isEnabled = true;
    Console.WriteLine("TV is powered on.");
  }

  public void PowerOff()
  {
    _isEnabled = false;
    Console.WriteLine("TV is powered off.");
  }

  public void SetVolume(int volume)
  {
    _volume = volume;
    Console.WriteLine($"TV volume set to {_volume}.");
  }

  public void SetChannel(int channel)
  {
    _channel = channel;
    Console.WriteLine($"TV channel set to {_channel}.");
  }

  public int GetVolume()
  {
    return _volume;
  }

  public int GetChannel()
  {
    return _channel;
  }
}

public class Radio : IDevice
{
  private bool _isEnabled;
  private int _volume;
  private int _channel;

  public bool IsEnabled() => _isEnabled;

  public void PowerOn()
  {
    _isEnabled = true;
    Console.WriteLine("Radio is powered on.");
  }

  public void PowerOff()
  {
    _isEnabled = false;
    Console.WriteLine("Radio is powered off.");
  }

  public void SetVolume(int volume)
  {
    _volume = volume;
    Console.WriteLine($"Radio volume set to {_volume}.");
  }

  public void SetChannel(int channel)
  {
    _channel = channel;
    Console.WriteLine($"Radio channel set to {_channel}.");
  }

  public int GetVolume()
  {
    return _volume;
  }

  public int GetChannel()
  {
    return _channel;
  }
}

public class ImprovedRemoteControl : RemoteControl
{
  private readonly IDevice _device;
  public ImprovedRemoteControl(IDevice device) : base(device)
  {
    _device = device;
  }

  public void Mute()
  {
    _device.SetVolume(0);
    Console.WriteLine("Device is muted.");
  }
}
