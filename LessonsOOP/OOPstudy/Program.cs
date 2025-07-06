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
        static void Obj(object obj)
        {
            Point3d p = obj as Point3d; //возвращает null, если не Point
            if(p != null)
                p.Print();
            else
                Console.WriteLine("obj is null");
        }
        static void Obj2(object obj)
        {
            if(obj is Point3d p) //проверка на соответствие типов и возвращение при положительном результате в переменную
                p.Print();
            else
                Console.WriteLine("obj is null");
        }
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
            PointXY PointX1 =  new PointXY();
            PointX1.SetX(43);
            Console.WriteLine(PointX1.GetX());
            PointX1.SetX(-1);
            Console.WriteLine(PointX1.GetX());
            PointX1.SetX(45);
            Console.WriteLine(PointX1.GetX());
            PointX1.Prop = 50;
            Console.WriteLine(PointX1.Prop);
            PointX1.Z = 60; 
            Console.WriteLine(PointX1.Z);
            
            StaticClass MyClass1 = new  StaticClass();
            MyClass1.a = 44;
            StaticClass MyClass2 = new  StaticClass();
            MyClass2.a = 22;
            StaticClass.b = 23;
            Console.WriteLine("а_1: " + MyClass1.a +  " a_2: " + MyClass2.a);
            MyClass1.Printb();
            MyClass2.Printb();
            MyClass2.SetB(34);
            MyClass1.Printb();
            MyClass2.Printb();
            MyClass1.two();
            StaticClass.one();
            Console.WriteLine(MyClass.SetGet);
            for (int i = 0; i < 100; ++i)
            {
                new MyClass();
            }
            Console.WriteLine(MyClass.SetGet);
            
            Static2.Prov();
            StaticClass1.StaticBlock();
            
            
            DateTime currentDate = DateTime.Now;
            currentDate.Print();
            Console.WriteLine(currentDate.IsDayIsWeek(DayOfWeek.Friday));
            Console.WriteLine(currentDate.IsDayIsWeek(DayOfWeek.Monday));

            Person person1 = new Person("And", "Two");
            person1.Print();
            
            ReadOnlyClass ROC1 = new ReadOnlyClass(33);
            ROC1.Method();
            
            Cat cat1 = new Cat {age = 3, Name = "Roc"};//используется по умолчанию конструктор по умолчанию
            cat1.Print();
            Person2 Person2_0 = new Person2();
            Person2_0.FirstName = "Roc";
            Person2_0.LastName = "Doe";
            Address address = new Address();
            address.City = "<UNK>";
            address.Country = "UNK";
            address.Region = "<UNK>";
            Person2_0.Address = address;
            Person2_0.Print();
            Person2 Person2_1 = new Person2
            {
                 FirstName = "fhfh",
                 LastName = "fhf4242h",
                 Address = new  Address
                 {
                     Country = "12",
                     City = "123",
                     Region = "1324",
                 }
            };
            Person2_1.Print();
            Cat cat2 = new Cat("Barsik")
            {
                age = 9,
            };
            cat2.Print();
            Cat cat3 = new Cat("Barsik")
            {
                Name = "NeBarsik",
                age = 9,
            }; //инициализации>конструктора класса
            cat3.Print();
            
            Person3 person3_0 = new Person3{FirstName = "KKK"};
            person3_0.PrintName();
            Student3 Student3_0 = new Student3{FirstName = "KK",  LastName = "KKr"};
            Student3_0.PrintName();
            Student3_0.Learn();
            Person3 Student3_1 = new Student3();//все равно тип person3
            Student3_1.PrintName(); 
            
            Point3d p3d_1 = new Point3d(); //2 вывода, оба конструктора вызываются, родительский и дочерний
            //сначало родительский конструктор, затем дочерний
            p3d_1.Print();
            Point3d p3d_2 = new Point3d(12, 12, 14);
            p3d_2.Print();
            
            object ob = "fjdfj";
            Console.WriteLine(ob);
            object ob2 = new Point3d(10, 12, 13);
            Console.WriteLine(ob2);
            ((Point3d)ob2).Print(); //только явное преобразование
            var ob3 = new Point3d(12, 12, 14);
            ob3.Print();
            Obj(123);
            Obj(p3d_1);
            Obj2(123);
            Obj(p3d_2);
        }
    }
}
    