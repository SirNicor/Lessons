using System.Runtime.InteropServices;

namespace LessonsOOP;

public class StaticClass
{
    public StaticClass()
    {
        Console.WriteLine("Constructor");
    }

    static StaticClass() //нет смысла от модификаторов доступа, только один
    { //выполняется только один раз
        Console.WriteLine("StaticConstructor");
    }
    public int a;
    public static int b; //общая область памяти для всех экземпляров класса
    private static int c;
    //this нельзя использовать
    public void Printb()
    {
        Console.WriteLine("b_1: " + b);
    }

    public void SetB(int b)
    {
        StaticClass.b = b;
    }

    public static void one() //нельзя вызвать через ссылка на экземпляр класса
    {
        Console.WriteLine("one");
        //нельзя использовать нестатические объекты
        Console.WriteLine(b);
    }

    public void two()
    {
        Console.WriteLine("two");
        Console.WriteLine(b); //нестатические методы могут использовать статические совйства и методы
        one();
    }

    public static int C
    {
        get { return c; }
        set { c = value; }
    }
}

class MyClass
{
    public MyClass()
    {
        counter++;
    }
    private static int counter;
    public static int SetGet
    {
        get { return counter;}
        private set { counter = value; } //сохранение принципа инкапсуляции, невозможно изменить counter с внешней стороны
    }
}

class Static2
{
    public Static2()
    {
        Console.WriteLine("Constructor2");
    }

    static Static2() 
    { 
        Console.WriteLine("StaticConstructor2"); //вызывается при любом взаимодействии с классом(даже без создания объекта)
    } //будет вызван лишь один раз

    public static void Prov()
    {
        Console.WriteLine("Prov");
    }
}