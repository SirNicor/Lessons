namespace LessonsOOP;

public class Student
{
        public Guid id; //guid - структура для создания id
        public string FirstName;
        public string LastName;
        public string middleName;
        public int age;
        public string group;

        public void WriteStudent()
        {
             Console.WriteLine($"Student ID: {id}");
             Console.WriteLine($"First Name: {FirstName}");
             Console.WriteLine($"Last Name: {LastName}");
             Console.WriteLine($"Middle Name: {middleName}");
             Console.WriteLine($"Age: {age}");
             Console.WriteLine($"Group: {group}");
        }

        public string GetFullName()
        {
            return  $"{FirstName} {LastName} {middleName}";
        }
}

public class Student1
{
    //создание конструкторов классов с полным вводом информации и минимальным необходимым для существования смысла объекта этого класса
    public Student1(string firstName, string lastName, string middleName, int age, string group)
    {
        FirstName = firstName;
        LastName = lastName;
        this.middleName = middleName;
        this.age = age;
        this.group = group;
    }
    public Student1(string lastName, int age, string group)
    {
        LastName = lastName;
        this.age = age;
        this.group = group;
    }

    public Student1(Student1 student)
    {
        FirstName = student.FirstName;
        LastName = student.LastName;
        middleName = student.middleName;
        age = student.age;
        group = student.group;
    }
    public Guid id; //guid - структура для создания id
    public string FirstName;
    public string LastName;
    public string middleName;
    public int age;
    public string group;

    public void WriteStudent()
    {
        Console.WriteLine($"Student ID: {id}");
        Console.WriteLine($"First Name: {FirstName}");
        Console.WriteLine($"Last Name: {LastName}");
        Console.WriteLine($"Middle Name: {middleName}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Group: {group}");
    }

    public string GetFullName()
    {
        return  $"{FirstName} {LastName} {middleName}";
    }

    public void SetLastName(string newLastName)
    {
        LastName = newLastName;
    }
}