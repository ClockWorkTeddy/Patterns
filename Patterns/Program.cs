namespace Patterns;

using Patterns.Creational.FactoryMethod;
using Patterns.Creational.AbstractFactory;

public class Program
{
    public static void Main(string[] args)
    {
      var b = new KnightBuilder();
      var d = new Director(b);
      d.Construct();
      var knight = b.GetResult();
      Console.WriteLine($"Knight: {knight.Name}, Class: {knight.Class}, Mount: {knight.Mount}, Money: {knight.Money}");
    }
}