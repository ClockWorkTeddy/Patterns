namespace Patterns;

using System.Runtime.InteropServices;
using Patterns.Creational;
using Patterns.Structural;
using Patterns.Behavioral;

public class Program
{
  public static void Main(string[] args)
  {
    var displayMessageButton = new DisplayMessageButton(
      new DisplayCapitalizedMessageCommand("Hello, World!"));

    displayMessageButton.Click();
  }
}