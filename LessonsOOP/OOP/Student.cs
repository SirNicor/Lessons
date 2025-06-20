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