namespace Patterns;

using Patterns.Creational.FactoryMethod;
using Patterns.Creational.AbstractFactory;

public class Program
{
    public static void Main(string[] args)
    {
      var factory = new ModernFurnitureFactory();
      var Client = new Client(factory);
      Client.UseFurniture();      
    }
}

public class Battle
{
  private Character character;

  public Battle(string realm)
  {
    if (realm == "Castle")
    {
      character = new Knight();
    }
    else if (realm == "Forest")
    {
      character = new Barbarian();
    }
    else
    {
      throw new ArgumentException("Invalid realm");
    }
  }

  public void Fight()
  {
    character.Attack();
  }
}