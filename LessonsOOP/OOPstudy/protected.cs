namespace LessonsOOP;

public class A
{
    public int publicField;
    private int privateField;
    protected int protectedField; 
    //на уровне одного класса private = protected
    public A()
    {
        Console.WriteLine(publicField);
        Console.WriteLine(privateField);
        Console.WriteLine(protectedField);
    }
}

public class B : A
{
    //на уровне наследования protected доступно, а private нет
    public B()
    {
        Console.WriteLine(publicField);
        //Console.WriteLine(privateField); невозможно получить доступ
        Console.WriteLine(protectedField); //возможно получить доступ
    }
}