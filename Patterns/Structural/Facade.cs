namespace Patterns.Structural;

public class RocketTable
{
  public bool IsFramesReleased { get; set; }
  public void ReleaseFrames()
  {
    // Logic to open the valve
    this.IsFramesReleased = true;
    Console.WriteLine("Frames released.");
  }
}

public class FuelUnit
{
  public bool IsFuelInjected { get; set; }
  public void InjectFuel()
  {
    // Logic to inject fuel
    this.IsFuelInjected = true;
    Console.WriteLine("Fuel injected.");
  }
}

public class NavigationSystem
{
  public bool IsCalibrated { get; set; }
  public void Calibrate()
  {
    // Logic to calibrate the navigation system
    this.IsCalibrated = true;
    Console.WriteLine("Navigation system calibrated.");
  }
}

public class Dispatcher
{
  private RocketTable _rocketTable;
  private FuelUnit _fuelUnit;
  private NavigationSystem _navigationSystem;

  public Dispatcher()
  {
    _rocketTable = new RocketTable();
    _fuelUnit = new FuelUnit();
    _navigationSystem = new NavigationSystem();
  }

  public void LaunchRocket()
  {
    Console.WriteLine("Preparing to launch the rocket...");

    _rocketTable.ReleaseFrames();
    _fuelUnit.InjectFuel();
    _navigationSystem.Calibrate();

    Console.WriteLine("Rocket launched successfully!");
  }
}