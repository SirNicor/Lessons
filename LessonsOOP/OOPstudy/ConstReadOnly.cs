class ReadOnlyClass
{
    public const int A = 100; //const, невозможно изменить во время работы проекта
    //проект не выполниться, если константа не задана до исполнения
    public const string MY_ERROR = "som error"; //для наименования рекомендуется использовать caps и _
    //избегание магических чисел по проекту
    //неявно статические поля, т.е. можно обращаться через обращения к классу
    public readonly int YourConst;
    //можно объявить без задания конкретного значения
    //не является неявно статическим полем
    //позволяет получить значения во время проекта один раз
    public static readonly int YourConst2;

    static ReadOnlyClass()
    {
        YourConst2 = 33;
    }
    public ReadOnlyClass(int a)
    {
        YourConst = a; //можно только один раз присвоить(только в конструкторе) 
    }

    public void Method()
    {
        Console.WriteLine(YourConst);
        Console.WriteLine(MY_ERROR);
        Console.WriteLine(A);
        Console.WriteLine(YourConst2);
    }
}