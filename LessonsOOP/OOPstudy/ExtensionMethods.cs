namespace LessonsOOP;

static class ExtensionMethods
{
    public static void Print(this DateTime dateTime) //this для модификации конкретного класса
    //первый параметр всегда необходимый класс
    {
        Console.WriteLine(dateTime);
        //модификация структуры DateTime, без изменения самого класса, с помощью extension methods
    }

    public static bool IsDayIsWeek(this DateTime dateTime, DayOfWeek dayOfWeek)
    {
        return dateTime.DayOfWeek == dayOfWeek;
    }
    //в одном пространстве имен всегда будут доступны все прописанные в этом пространстве extension methods
    //при нахождении в другом пространстве имен, для использования extension methods необходимо использовать using name
}