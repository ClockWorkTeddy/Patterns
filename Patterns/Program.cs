namespace Patterns;

using Patterns.Creational.FactoryMethod;
using Patterns.Creational.AbstractFactory;

public class Program
{
    public static void Main(string[] args)
    {
      var circle = new Circle(5);
      var circleClone = circle.Clone();
      Console.WriteLine($"Original Circle Radius: {circle.Radius}");
      var rectangle = new Rectangle(10, 20);
      var rectangleClone = rectangle.Clone();
      Console.WriteLine($"Original Rectangle Width: {rectangle.Width}, Height: {rectangle.Height}");
    }
}