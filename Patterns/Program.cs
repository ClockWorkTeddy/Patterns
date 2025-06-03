namespace Patterns;

using Patterns.Creational;
using Patterns.Structural;

public class Program
{
  public static void Main(string[] args)
  {
    var Drawer = new Drawer();
    var instanceBoxFactory = new InstanceBoxFactory();
    var instanceViewModel1 = new InstanceViewModel(instanceBoxFactory, Drawer, 10, 20, "LittleBox", "Red");
    var instanceViewModel2 = new InstanceViewModel(instanceBoxFactory, Drawer, 20, 40, "LittleBox", "Red");
    var instanceViewModel3 = new InstanceViewModel(instanceBoxFactory, Drawer, 30, 60, "LittleBox", "Red");
    var instanceViewModel4 = new InstanceViewModel(instanceBoxFactory, Drawer, 40, 80, "LittleBox", "Red");
    var instanceViewModel5 = new InstanceViewModel(instanceBoxFactory, Drawer, 50, 100, "LittleBox", "Red");
    var instanceViewModel6 = new InstanceViewModel(instanceBoxFactory, Drawer, 60, 120, "LittleBox", "Blue");

    instanceViewModel1.Draw();
    instanceViewModel2.Draw();
    instanceViewModel3.Draw();
    instanceViewModel4.Draw();
    instanceViewModel5.Draw();
    instanceViewModel6.Draw();
  }
}