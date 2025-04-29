namespace Patterns.Creational.FactoryMethod;

public abstract class Character
{
    abstract public IWeapon GetWeapon();
    
    public void Attack()
    {
        IWeapon weapon = GetWeapon();
        weapon.Hit();
    }
}

public class Knight : Character
{
    public override IWeapon GetWeapon()
    {
        return new Sword();
    }
}

public class Barbarian : Character
{
    public override IWeapon GetWeapon()
    {
        return new Axe();
    }
}

public interface IWeapon
{
    void Hit();
}

public class Sword : IWeapon
{
    public void Hit()
    {
        Console.WriteLine("Sword hits!");
    }
}

public class Axe : IWeapon
{
    public void Hit()
    {
        Console.WriteLine("Axe hits!");
    }
}

public class Battle
{
  private Character character;

  public Battle(string realm)
  {
    if (realm == "Castle")
    {
      this.character = new Knight();
    }
    else if (realm == "Forest")
    {
      this.character = new Barbarian();
    }
    else
    {
      throw new ArgumentException("Invalid realm");
    }
  }

  public void Fight()
  {
    this.character.Attack();
  }
}