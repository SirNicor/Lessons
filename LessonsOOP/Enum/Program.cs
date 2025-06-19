using System.Diagnostics;
using System.Net.Http.Headers;

class Program
{
    
    enum DayOfWeek : byte
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    enum Color
    {
        White,
        Black,
        Red,
        Green,
        Blue,
        Yellow
    }
    static DayOfWeek NextDay(DayOfWeek day)
    {
        if (day < DayOfWeek.Sunday)
            return day + 1;
        return DayOfWeek.Monday;
    }
    static void Main(string[] args)
    {
        ConsoleKey key = Console.ReadKey().Key; //Key - объект типа enum
        int keyCode =  (int)key;
        Console.WriteLine($"\tEnum - {key}\tKey : {keyCode}");
        if (key == ConsoleKey.Enter)
        {
            Console.WriteLine("Вы нажали enter");
        }
        Console.WriteLine(Enum.GetUnderlyingType(typeof(DayOfWeek))); //получаем тип данных
        DayOfWeek dayOfWeek = DayOfWeek.Tuesday;
        Console.WriteLine(dayOfWeek); 
        Console.WriteLine((int)dayOfWeek);
        Console.WriteLine((DayOfWeek)3);
        Console.WriteLine(NextDay(DayOfWeek.Monday));
        Console.WriteLine(NextDay(DayOfWeek.Sunday));
        Console.WriteLine(NextDay(NextDay(DayOfWeek.Saturday)));
        DayOfWeek notCorrect = (DayOfWeek)0;
        Console.WriteLine(notCorrect);
        byte value = 10;
        DayOfWeek dayOfWeek2;
        var values = Enum.GetValues(typeof(Color));
        foreach(Color color in values)
            Console.Write(color + " ");
        Console.WriteLine();
        string str = Console.ReadLine();
        Color color2 = (Color)Enum.Parse(typeof(Color), str, ignoreCase: true);
        Console.WriteLine(color2);
        if (Enum.IsDefined(typeof(DayOfWeek), value))
            dayOfWeek2 = (DayOfWeek)value;
        else
            throw new Exception("Invalid value1");
        dayOfWeek2 = (DayOfWeek)1;
        Console.WriteLine(dayOfWeek2);
    }
}