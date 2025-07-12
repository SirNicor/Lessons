namespace LessonsOOP;

interface IInterfaceOne
{
    void Action();
}

interface IInterfaceTwo
{
    void Action();
}

class MyClass1 : IInterfaceOne, IInterfaceTwo
{
    public void Action()
    {
        Console.WriteLine("MyClass1.Action");
    }
}

class MyOtherClass : IInterfaceOne, IInterfaceTwo
{
    void IInterfaceOne.Action()
    {
        Console.WriteLine("MyClass1.Action1");
    }
    void IInterfaceTwo.Action()
    {
        Console.WriteLine("MyClass1.Action2");
    }
}

