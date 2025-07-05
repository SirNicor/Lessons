namespace LessonsOOP;

class Person3
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public void PrintName()
    {
        Console.WriteLine($"My name is {FirstName}");
    }
}

class Student3:Person3 
{
    //множественного наследования в классах нет
     //унаследовал все методы и свойства из Person3
     //student - наследует класс Person3, класс Person3 - базовый/родительский класс
     public void Learn() //только для класса Student3
     {
         Console.WriteLine("I got 2 hours of passes.");
     }
}