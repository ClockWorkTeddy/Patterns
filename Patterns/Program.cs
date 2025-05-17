namespace Patterns;

using Patterns.Creational;

public class Program
{
  public static void Main(string[] args)
  {
    var singleton = Singleton.Instance;
    singleton.DoSomething();
    var singleton2 = Singleton.Instance;
    singleton2.DoSomething();
  }
}