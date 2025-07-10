namespace Patterns;

using System.Runtime.InteropServices;
using Patterns.Creational;
using Patterns.Structural;
using Patterns.Behavioral;

public class Program
{
  public static void Main(string[] args)
  {
    var originator = new Originator();
    var caretaker = new Caretaker(originator);
    originator.State = "State 0";
    caretaker.SaveMemento();
    originator.State = "State 1";
    caretaker.Undo();
    Console.WriteLine($"Restored State: {originator.State}");
  }
}