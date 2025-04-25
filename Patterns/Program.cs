namespace Patterns;

using Patterns.Creational.FactoryMethod;

public class Program
{
    public static void Main(string[] args)
    {
      Console.WriteLine("Select the realm (Castle/Forest): ");
      var realm = Console.ReadLine();
      var battle = new Battle(realm);
      battle.Fight(); // Output: Sword hits!
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