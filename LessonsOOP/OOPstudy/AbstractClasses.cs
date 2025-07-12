namespace LessonsOOP;

class Player 
{
    public void Fire(Weapon weapon)
    {
        weapon.Fire();
    }

    public void CheckInfo(IShowInfo weapon)
    {
        weapon.ShowInfo();
    }
}

interface IShowInfo
{
    void ShowInfo();
}

interface IWeapon
{
    public abstract void Fire();
    public abstract int Damage { get; }
}
abstract class Weapon : IShowInfo, IWeapon//нельзя создать экземпляр класса
{
    //абстрактный метод только в абстрактных классах
    public abstract void Fire();
    public abstract int Damage { get; }

    public void ShowInfo()
        {
            Console.WriteLine(GetType().Name);
        }
}

class Gun1 : Weapon
{
    public override int Damage
    {
        get { return 4; }
    }

    public override void Fire()
    {
        Console.WriteLine("Gun1Fire " + Damage);
    }
}

class Gun2 : Weapon
{
    public override int Damage
    {
        get { return 6; }
    }
    public override void Fire()
    {
        Console.WriteLine("Gun2Fire " + Damage);
    }
}

class Gun3 : Weapon
{
    public override int Damage
    {
        get { return 38; }
    }

    public override void Fire()
    {
        Console.WriteLine("Gun3Fire " + Damage);
    }
}

class Box : IShowInfo
{
    public void ShowInfo()
    {
        Console.WriteLine("Коробка");
    }
}