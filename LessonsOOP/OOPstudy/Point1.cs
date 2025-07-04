namespace LessonsOOP;

public class Point1
{
    public int x;
    private int y = 10;
    private int z = 3; // по умолчания всегда private
    private void PrintX()
    {
        Console.WriteLine($"x = {x}");
    }
    public void PrintY()
    {
        Console.WriteLine($"y = {y}");
    }

    public void PrintPoint()
    {
        PrintX();
        PrintY();
    }
}

public class Point2
{
    public Point2(int x, int y)
    {
        _x = x;
        _y = y;
    }
    //если написать собственный метод конструктора класса, то метод по умолчанию будет удален
    public Point2() //перегрузка метода
    {
        _x = _y = 1;
    }
    private int _x;
    private int _y;

    public void Print()
    {
        Console.WriteLine($"x = {_x}");
        Console.WriteLine($"y = {_y}");
    }
}