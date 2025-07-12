using System.Collections.Generic;
List<string> myList0 = new List<string>(){"1", "2", "3"};
List<string> myList1 = new List<string>(myList0);
List<string> myList2 = ["Tom", "Bob", "Sam", "Hgg", "JKHJF"]; //задание с помощью коллекций
List<string> MyList3 = new List<string>(16); //задание начальной емкости
Console.WriteLine(myList1[0]);
Console.WriteLine(myList2.Count);
foreach (var i in myList0)
{
    Console.WriteLine(i);
}
myList0.Add("4");//добавление нового элемента в список
myList1.AddRange(["Tom", "Bob", "Sam"]);//добавление списка 
Console.WriteLine(myList0.BinarySearch("4"));//бинарный поиск
string[] Arr = new string[4];
myList0.CopyTo(Arr); //копирование списка в массив
Console.WriteLine(myList0.Contains("4"));//возвращает true, если элемент item есть в списке
myList1.Clear();//удаление всех элементов
//все find аналогично с массивами
foreach (string x in myList2.GetRange(1, 2))
{
    Console.WriteLine(x);
}
myList1.Reverse();
foreach (string x in myList1)
{
    Console.WriteLine(x);
}
myList2.Remove("Tom");
Console.WriteLine(myList2[0]);