namespace Patterns.Structural;

public interface IDataBase
{
  string GetData(int id);
}

public class DataBase : IDataBase
{
  public string GetData(int id)
  {
    // Simulate a database call
    return $"Data for ID: {id}";
  }
}

public class DataBaseProxy : IDataBase
{
  private bool _accessGranted = true;
  private readonly DataBase _dataBase;

  public void RestrictAccess(bool isGranted)
  {
    _accessGranted = isGranted;
  }

  public DataBaseProxy()
  {
    _dataBase = new DataBase();
  }

  public string GetData(int id)
  {
    if (_accessGranted)
    {
      return _dataBase.GetData(id);
    }
    else
    {
      return "Access Denied";
    }
  }
}