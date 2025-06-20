namespace LessonsOOP;

public class Gun //пример инкапсуляции
{
    private bool isLoaded; //состояние
    /*инкапсуляция заключается в невозможности изменить состояние объекта внешней программой, только внутренними средствами
    Инкапсуляция – это механизм контроля доступа.
    Инкапсуляция позволяет скрыть детали реализации, и открыть
    только то, что необходимо для последующего использования.
    предотвращает ошибки, позволяет избежать потери данных и действий
    правильно организовывать поведение объекта, так как задумывалось при разработке, а не пользователем*/

    private void Reload()
    {
        Console.WriteLine("Reloading...");
        isLoaded = true;
        Console.WriteLine("Reload");
    } //поведение

    public void Shoot()
    {
        if (!isLoaded)
        {
            Console.WriteLine("Not loaded");
            Reload();
        }

        Console.WriteLine("fire");
        isLoaded = false;
    } //поведение
}