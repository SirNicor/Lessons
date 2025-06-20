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