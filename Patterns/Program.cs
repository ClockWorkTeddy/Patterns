namespace Patterns;

using Patterns.Creational.FactoryMethod;

public class Program
{
    public static void Main(string[] args)
    {
      Console.WriteLine("Select the realm (Castle/Forest): ");
      var realm = Console.ReadLine();
      var battle = new Battle(realm!);
      battle.Fight(); // Output: Sword hits!
    }
}