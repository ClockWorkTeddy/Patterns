namespace Patterns;

using System.Runtime.InteropServices;
using Patterns.Creational;
using Patterns.Structural;
using Patterns.Behavioral;

public class Program
{
  public static void Main(string[] args)
  {
    //Chain of Responsibility
    IHandler handlerA = new ConcreteHandlerA();
    IHandler handlerB = new ConcreteHandlerB();
    handlerA.SetNext(handlerB);

    System.Console.WriteLine(handlerA.Handle("A")); // Handled by ConcreteHandlerA
    System.Console.WriteLine(handlerA.Handle("B")); // Handled by ConcreteHandlerB
    System.Console.WriteLine(handlerA.Handle("C")); // This will return null since no handler can process "C"
  }
}