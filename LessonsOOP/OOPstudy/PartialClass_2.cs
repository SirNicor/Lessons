namespace LessonsOOP;

partial class Person
{
    
    public partial string GetName()
    {
        return FirstName + " " + LastName;
    }

    public void Print()
    {
        Console.WriteLine(GetName());
    }
}