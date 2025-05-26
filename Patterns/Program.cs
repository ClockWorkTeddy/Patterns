namespace Patterns;

using Patterns.Creational;
using Patterns.Structural;

public class Program
{
  public static void Main(string[] args)
  {
    var good1 = new Good(100, "Good 1");
    var good2 = new Good(200, "Good 2");
    var box = new Box();
    var good3 = new Good(300, "Good 3");
    var good4 = new Good(400, "Good 4");
    var box2 = new Box();
    box2.Add(good3);
    box2.Add(good4);
    box2.Add(box);
    box.Add(good1);
    box.Add(good2);
    Console.WriteLine($"Total price of box2: {box2.GetPrice()}");
  }
}