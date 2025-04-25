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
        return new SwordFactory().CreateWeapon();
    }
}

public class Barbarian : Character
{
    public override IWeapon GetWeapon()
    {
        return new AxeFactory().CreateWeapon();
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

public abstract class WeaponFactory
{
    public abstract IWeapon CreateWeapon();
}

public class SwordFactory : WeaponFactory
{
    public override IWeapon CreateWeapon()
    {
        return new Sword();
    }
}

public class AxeFactory : WeaponFactory
{
    public override IWeapon CreateWeapon()
    {
        return new Axe();
    }
}