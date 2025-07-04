using System.Runtime.InteropServices;

namespace LessonsOOP;

public class StaticClass
{
    public int a;
    public static int b; //общая область памяти для всех экземпляров класса
    //this нельзя использовать
    public void Printb()
    {
        Console.WriteLine("b_1: " + b);
    }

    public void SetB(int b)
    {
        StaticClass.b = b;
    }
}