namespace LessonsOOP
{
    enum Colors {Red, Green, Blue, Orange, Black, White}
    class Point //класс
    {
        public int x; 
        public int y;
        public Colors color;
    }


    class Program
    {
        static Student GetStudent()
        {
            Student student = new Student();
            student.id = Guid.NewGuid();
            student.FirstName = "N";
            student.LastName = "P";
            student.middleName = "I";
            student.age = 18;
            student.group = "191313-PRVB";
            return student;
        }

        static void PrintStudent(Student s)
        {
            Console.WriteLine("id: " + s.id + "and group = " + s.group);
            Console.WriteLine("FullName = " + s.FirstName + " " + s.LastName + " " + s.middleName + " and age = " + s.age);
        }
        static void Main(string[] args)
        {
            Point p1 = new Point(); //экземпляр класса
            p1.x = 10;
            p1.y = 20;
            Point p2 = new Point();
            p2.x = 15;
            p2.y = 30;
            Console.WriteLine($"p1 = [{p1.x},{p1.y}], p2 = [{p2.x},{p2.y}]");
            Point p3 = new Point();
            p3 = null; //нельзя получить доступ к полям x и y
            p1.color =  Colors.Red;
            p2.color =  Colors.Green;
            Console.WriteLine($"p1 = [{p1.x},{p1.y}] {p1.color}, p2 = [{p2.x},{p2.y}] {p2.color}");
            Console.WriteLine(p1.GetHashCode());
            Student s1 = GetStudent();
            PrintStudent(s1);
            Console.WriteLine("--");
            s1.WriteStudent(); //использования метода класса
            Console.WriteLine("default: ");
            var s2 = new Student();
            s2.WriteStudent();
            Console.WriteLine("FullName = " + s1.GetFullName());
            
            Point1 point1 = new Point1();
            point1.x = 10;//point1.y невозможно обратиться, т.к. private
            point1.PrintPoint();//point1.PrintX невозможно обратиться, т.к. private
            Gun gun1 = new Gun();
            gun1.Shoot();
            gun1.Shoot();
            Point2 p2_0 = new Point2(10, 15);
            Point2 p2_1 = new Point2(10, 15);
            p2_0.Print();
            p2_1.Print();
            Student1 Student1_0 = new Student1("1", 2, "3");
            Student1 Student1_1 = new Student1("1", "2", "3", 4, "5");
            Student1_0.WriteStudent();
            Student1_1.WriteStudent();
            Student1 Student1_2 = new Student1(Student1_1); //создание новой области памяти в куче, идентичной предыдущей, и ссылки на нее
            Student1 Student1_3 = Student1_1; //ссылка на те же данные в куче
            Student1_1.SetLastName("#####");
            Console.WriteLine("student1_1:");
            Student1_1.WriteStudent();
            Console.WriteLine("student1_2 = new Student(student1_1:)");
            Student1_2.WriteStudent();
            Console.WriteLine("student1_3 = student1_1:");
            Student1_3.WriteStudent();
            //this не работает в статический методах 
        }
    }
}
    