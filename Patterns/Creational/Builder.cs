public interface IBuilder
{
    void Reset();
    void SetName();
    void SetClass();
    void SetMount();
    void SetMoney();
}

public class Warrior
{
    public string? Name { get; set; }
    public string? Class { get; set; }
}

public class Knight
{
    public string? Name { get; set; }
    public string? Class { get; set; }
    public string? Mount { get; set; }
    public int Money { get; set; }
}

public class WariorBuiler : IBuilder
{
    private Warrior _warrior = new Warrior();

    public void Reset()
    {
        _warrior = new Warrior();
    }

    public void SetName()
    {
        _warrior.Name = "Warrior";
    }

    public void SetClass()
    {
        _warrior.Class = "Gladiator";
    }

    public Warrior GetWarrior()
    {
        return _warrior;
    }

    public void SetMount()
    {
        throw new NotImplementedException();
    }

    public void SetMoney()
    {
        throw new NotImplementedException();
    }

    public Warrior GetResult()
    {
        return _warrior;
    }
}

public class KnightBuilder : IBuilder
{
    private Knight _knight = new Knight();

    public void Reset()
    {
        _knight = new Knight();
    }

    public void SetName()
    {
        _knight.Name = "Knight";
    }

    public void SetClass()
    {
        _knight.Class = "Paladin";
    }

    public void SetMount()
    {
        _knight.Mount = "Horse";
    }

    public void SetMoney()
    {
        _knight.Money = 100;
    }

    public Knight GetResult()
    {
        return _knight;
    }
}

public class Director
{
    private IBuilder _builder;

    public Director(IBuilder builder)
    {
        _builder = builder;
    }

    public void Construct()
    {
        _builder.Reset();
        _builder.SetName();
        _builder.SetClass();
        
        if (_builder is KnightBuilder)
        {
            _builder.SetMount();
            _builder.SetMoney();
        }
    }

    public void changeBuilder(IBuilder builder)
    {
        _builder = builder;
    }
}
