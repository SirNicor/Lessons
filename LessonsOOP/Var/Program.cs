class Program
{
    static void Main(string[] args)
    {
        var t = 5;
        Console.WriteLine(t.GetType());
        var z = "143";
        Console.WriteLine(z.GetType());
        var arr = new int[10];
        Console.WriteLine(arr.GetType());
        //var t = null, невозможно
        var l = new int[10];
        l = null; //уже есть тип - можно присваивать
        var D = new List<int>(); //сокращение записи
        Console.WriteLine(D.GetType());
        var t1 = new { Name = "Mart", Age = 18 };//работа с анонимными типами
        Console.WriteLine(t1.GetType());
        int[] num = { 1, 3, 5, 10, 25, 3, 105, 106 };
        var res = from i in num where i % 2 == 0 select i;
        foreach (var i in res)
            Console.Write(i+" ");
        Console.WriteLine();
        //var не может быть типом возвращаемого значения функции и аргументами функции
        //var не может быть полем класса    
    }
}