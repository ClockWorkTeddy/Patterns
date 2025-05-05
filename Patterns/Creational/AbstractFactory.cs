namespace Patterns.Creational.AbstractFactory;


public interface IChair
{
  public void Sit();
}

public interface ISofa
{
  public void LieDown();
}

public interface ICoffeeTable
{
  public void PlaceCoffee();
}

public class ModernChair : IChair
{
  public void Sit()
  {
    Console.WriteLine("Sitting on a modern chair.");
  }
}

public class ModernSofa : ISofa
{
  public void LieDown()
  {
    Console.WriteLine("Lying down on a modern sofa.");
  }
}
public class ModernCoffeeTable : ICoffeeTable
{
  public void PlaceCoffee()
  {
    Console.WriteLine("Placing coffee on a modern coffee table.");
  }
}

public class VictorianChair : IChair
{
  public void Sit()
  {
    Console.WriteLine("Sitting on a Victorian chair.");
  }
}

public class VictorianSofa : ISofa
{
  public void LieDown()
  {
    Console.WriteLine("Lying down on a Victorian sofa.");
  }
}

public class VictorianCoffeeTable : ICoffeeTable
{
  public void PlaceCoffee()
  {
    Console.WriteLine("Placing coffee on a Victorian coffee table.");
  }
}

public class ArtDecoChair : IChair
{
  public void Sit()
  {
    Console.WriteLine("Sitting on an Art Deco chair.");
  }
}

public class ArtDecoSofa : ISofa
{
  public void LieDown()
  {
    Console.WriteLine("Lying down on an Art Deco sofa.");
  }
}

public class ArtDecoCoffeeTable : ICoffeeTable
{
  public void PlaceCoffee()
  {
    Console.WriteLine("Placing coffee on an Art Deco coffee table.");
  }
}

public interface IFurnitureFactory
{
  public IChair CreateChair();
  public ISofa CreateSofa();
  public ICoffeeTable CreateCoffeeTable();
}

public class ModernFurnitureFactory : IFurnitureFactory
{
  public IChair CreateChair()
  {
    return new ModernChair();
  }

  public ISofa CreateSofa()
  {
    return new ModernSofa();
  }

  public ICoffeeTable CreateCoffeeTable()
  {
    return new ModernCoffeeTable();
  }
}

public class VictorianFurnitureFactory : IFurnitureFactory
{
  public IChair CreateChair()
  {
    return new VictorianChair();
  }

  public ISofa CreateSofa()
  {
    return new VictorianSofa();
  }

  public ICoffeeTable CreateCoffeeTable()
  {
    return new VictorianCoffeeTable();
  }
}

public class ArtDecoFurnitureFactory : IFurnitureFactory
{
  public IChair CreateChair()
  {
    return new ArtDecoChair();
  }

  public ISofa CreateSofa()
  {
    return new ArtDecoSofa();
  }

  public ICoffeeTable CreateCoffeeTable()
  {
    return new ArtDecoCoffeeTable();
  }
}

public class Client
{
  private readonly IChair _chair;
  private readonly ISofa _sofa;
  private readonly ICoffeeTable _coffeeTable;

  public Client(IFurnitureFactory factory)
  {
    _chair = factory.CreateChair();
    _sofa = factory.CreateSofa();
    _coffeeTable = factory.CreateCoffeeTable();
  }

  public void UseFurniture()
  {
    _chair.Sit();
    _sofa.LieDown();
    _coffeeTable.PlaceCoffee();
  }
}