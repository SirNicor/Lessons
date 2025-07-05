namespace LessonsOOP;

partial class Person //partial позволяет сделать частичный класс, разбив его на несколько файлов
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public partial string GetName(); //в рамках одного класса разбиение функции     
}