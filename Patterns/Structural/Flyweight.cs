namespace Patterns.Structural;

public class Drawer
{
  public void DrawBox(string color, int x, int y)
  {
    // Logic to draw the box at the specified coordinates
    Console.WriteLine($"Drawing box '{color}' at ('{x}', '{y}') with color ");
  }
}

public class InstanceBox
{
  public string Name { get; }
  public string Color { get; }

  public InstanceBox(string name, string color)
  {
    Name = name;
    Color = color;
  }

  public void Draw(Drawer drawer, int x, int y)
  {
    drawer.DrawBox($"{Color}_{Name}_{this.GetHashCode()}", x, y);
  }
}

public class InstanceViewModel
{
  private InstanceBoxFactory _instanceBoxFactory;
  private InstanceBox _instanceBox;
  private Drawer _drawer;
  private int _x;
  private int _y;

  public InstanceViewModel(InstanceBoxFactory instanceBoxFactory, Drawer drawer, int x, int y, string name, string color)
  {
    _instanceBoxFactory = instanceBoxFactory;
    _instanceBox = _instanceBoxFactory.GetInstanceBox(name, color);
    _drawer = drawer;
    _x = x;
    _y = y;
  }

  public InstanceBox InstanceBox => _instanceBox;
  public int X => _x;
  public int Y => _y;
  public Drawer Drawer => _drawer;

  public void Draw()
  {
    _instanceBox.Draw(_drawer, _x, _y);
  }
}

public class InstanceBoxFactory
{
  private readonly Dictionary<string, InstanceBox> _boxes = new();

  public InstanceBox GetInstanceBox(string name, string color)
  {
    var key = $"{name}-{color}";
    if (!_boxes.ContainsKey(key))
    {
      _boxes[key] = new InstanceBox(name, color);
    }
    return _boxes[key];
  }
}