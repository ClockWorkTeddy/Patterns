namespace Patterns.Structural;

public interface IComponent
{
  int GetPrice();
}

public class Good(int price, string name) : IComponent
{
  public string Name => name;
  public int GetPrice() => price;
}

public class Box : IComponent
{
  private readonly List<IComponent> _components = new();

  public void Add(IComponent component) => _components.Add(component);

  public int GetPrice()
  {
    var totalPrice = 0;

    foreach (var component in _components)
    {
      totalPrice += component.GetPrice();
    }

    return totalPrice;
  }
}