namespace Patterns;

using System.Runtime.InteropServices;
using Patterns.Creational;
using Patterns.Structural;
using Patterns.Behavioral;

public class Program
{
  public static void Main(string[] args)
  {
    var initialState = new ConcreteStateA();
    var context = new Context(initialState);
    context.Request();
    var newState = new ConcreteStateB();
    context.SetState(newState);
    context.Request();
  }
}