namespace LessonsOOP;

public class car
{
    protected void StartEngine() 
    {
        Console.WriteLine("Engine started");
    }
    public virtual void Drive() //виртуальный метод
    {
        StartEngine();
        Console.WriteLine("Drive");
    }
}

class sportcar:car
{
    public override void Drive()//ключевое слово override позволяет переопределить
    {
        StartEngine();
        Console.WriteLine("OverDrive"); //пример полиморфизма, переопределение метода
    }
}

class Driver
{
    public void Drive(car car)
    {
        car.Drive();
    }
}